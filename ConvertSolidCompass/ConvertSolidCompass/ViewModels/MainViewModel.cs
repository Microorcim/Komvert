using ConvertSolidCompass.HelpModels;
using ConvertSolidCompass.Models.Catalog;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace ConvertSolidCompass
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        //Переменная которая может быть Null Которая хранит в себе выбранный элемент класса
        /// <summary>
        /// Выбранный класс
        /// </summary>
        private SolidNode? _selectedNode;
        private CompassNode? _selectedCompassNode;
        private TewCatreference? _tewCatreference;
        private Record? _record;

        //Создаем коллекцию которая выкидывает ивент при добавлении/изменении/удалении элемента внутри (Что бы во время работы с базой при работе программы ничего не сломалось)
        /// <summary>
        /// Коллекция классов размещения деталей SOLID
        /// </summary>
        public ObservableCollection<SolidNode> SolidNodes { get; set; } = new ObservableCollection<SolidNode>();
        public ObservableCollection<CompassNode> KompassNodes { get; set; } = new ObservableCollection<CompassNode>();

        /// <summary>
        /// свойство для выбранного класса
        /// </summary>
        public SolidNode? SelectedNode
        {
            get => _selectedNode;
            set
            {
                if (_selectedNode != value)
                {
                    CatReferences.Clear();
                    _selectedNode = value;
                    if (_selectedNode != null)
                        //Если выбранный класс не Null отображаем его детали производителя
                        ChangeCatReference(_selectedNode);
                    OnPropertyChanged("SelectedNode");
                }
            }
        }

        /// <summary>
        /// Свойство для выбранного класса
        /// </summary>
        public CompassNode? SelectedKompassNode
        {
            get => _selectedCompassNode;
            set
            {
                if (_selectedCompassNode != value)
                {
                    Records.Clear();
                    _selectedCompassNode = value;
                    if (_selectedCompassNode != null && _selectedCompassNode.Table != null)
                        //Если выбранный класс не Null отображаем его детали производителя
                        ChangeParts(_selectedCompassNode.Table);
                    OnPropertyChanged("SelectedKompassNode");
                }
            }
        }

        public TewCatreference? TewCatreference
        {
            get => _tewCatreference;
            set
            {
                if (_tewCatreference == null || _tewCatreference != value)
                {
                    _tewCatreference = value;
                    OnPropertyChanged("TewCatreference");
                }
            }
        }

        public Record? Record
        {
            get => _record;
            set
            {
                if (_record == null || _record != value)
                {
                    _record = value;
                    OnPropertyChanged("Record");
                }
            }
        }

        //Создаем коллекцию которая выкидывает ивент при добавлении/изменении/удалении элемента внутри (Что бы во время работы с базой при работе программы ничего не сломалось)
        /// <summary>
        /// Коллекция деталей производителей
        /// </summary>
        public ObservableCollection<TewCatreference> CatReferences { get; set; } = new ObservableCollection<TewCatreference>();
        public ObservableCollection<Record> Records { get; set; } = new ObservableCollection<Record>();

        /// <summary>
        /// Конструктор класса модель 
        /// </summary>
        public MainViewModel()
        {
            UpdateSolidTree();
            UppdateCompassTree();
        }

        #region Солид

        /// <summary>
        /// Рекурсия для обхода дерева
        /// </summary>
        /// <param name="node">Родитель</param>
        /// <param name="context">Контекст БД классификации</param>
        public void GetSolidTree(SolidNode node, TewClassificationContext context)
        {
            //новая коллекция детей
            List<TewNode> children = new List<TewNode>();

            //Находим ID Детей по ID Родителей
            var childrensid = context.TewNodenodes.Where(x => x.NndParentid == node.Current.NodId).Select(x => x.NndChildid).ToList();
            //Выбираем всех детей
            children = context.TewNodes.ToList().Where(x => childrensid.Contains(x.NodId)).ToList();

            //Проходим всех детей и заполняем поля с переводом класса
            foreach (var x in children)
            {
                var nodeText = context.TewTranslatedtexts.FirstOrDefault(tt => tt.TraObjectid == x.NodId && tt.TraLanStrid == "ru");
                if (nodeText == null)
                    continue;
                x.NodTranlatedName = nodeText.Tra0;
                var newNode = new SolidNode(node) { Current = x };
                node.Childrens.Add(newNode);
                GetSolidTree(newNode, context);
            };
        }

        /// <summary>
        /// Обновление дерева классов
        /// </summary>
        public void UpdateSolidTree()
        {
            //Обновление дерева классов
            //Они храниться в Базе данных Tew_classification
            using (TewClassificationContext c = new TewClassificationContext())
            {
                //Берем таблицу Tew_Nodes 
                //В ней храниться информация о том какой класс на какой глубине находиться
                var nodes = c.TewNodes.ToList();
                //Берем таблицу Tew_Nodenodes в ней храниться информация о том какой класс в каком находиться (Кто родитель кто ребенок)
                var sxf = c.TewNodenodes.ToList();

                //Из таблицы Родителей и детей берем родителей
                var parents = sxf.Select(s => s.NndParentid).ToList();
                //Берем детей этих родителей
                var P2 = parents.Where(p => !sxf.Select(x => x.NndChildid).Contains(p)).ToList().Distinct();

                //Берем родителей которые находятся в корне классов 
                var P2Nodes = nodes.Where(x => P2.Contains(x.NodId)).ToList();

                //Переводим классы в человеко понятный вид
                foreach (var x in P2Nodes)
                {
                    //Названия всех классов храниться в таблице с переводами на другие языки 
                    //таблица с переводом Tew_translatedtexts в столбце TraLanStrid храниться сокращения языка выводим русский
                    var nodeText = c.TewTranslatedtexts.FirstOrDefault(tt => tt.TraObjectid == x.NodId && tt.TraLanStrid == "ru");
                    //Если не находим перевод то пропускаем этот класс 
                    if (nodeText == null)
                        continue;
                    //Выбираем только переведенное оно храниться в tra_0
                    x.NodTranlatedName = nodeText.Tra0;
                    //TODO: Описать создание класса и для чего он нужен
                    SolidNode node = new SolidNode() { Current = x };
                    //TODO:
                    SolidNodes.Add(node);

                }

                //Выводим полученное выше в дерево отображения СолидВоркс
                foreach (var item in SolidNodes)
                {
                    GetSolidTree(item, c);
                }
            }
        }

        /// <summary>
        /// выбираем все детали на основе выбранного класса
        /// </summary>
        /// <param name="selectedNode">Выбранный класс</param>
        public void ChangeCatReference(SolidNode selectedNode)
        {
            List<TewCatreference> allElements;
            using (var c = new TewCatalogContext())
            {
                allElements = c.TewCatreferences.Where(tref => tref.CreNodClauid == selectedNode.Current.NodClauid).ToList();
            }

            foreach (var e in allElements)
            {
                CatReferences.Add(e);
            }
        }

        /// <summary>
        /// Удаление детали Солид
        /// </summary>
        public void Delete()
        {
            if (TewCatreference != null)
            {
                using (var c = new TewCatalogContext())
                {
                    c.TewCatreferences.Remove(TewCatreference);
                    c.SaveChanges();
                }
            }
        }

        #endregion

        #region Компасс

        /// <summary>
        /// Получить дерево не корневых КОМПАС
        /// </summary>
        /// <param name="node">Ребенок</param>
        /// <param name="c">Context</param>
        private void GetCompassTree(CompassNode node, Kampas3Context c)
        {
            //Рекурсия
            
            if (node.Hierarchy != null)
            {
                //Перебор иерархий на детей
                var ChildHierarchies = c.Hierarchies.Include(x => x.Tables).Where(x => x.ParentId == node.Hierarchy.Id);
                foreach (var item in ChildHierarchies)
                {
                    var Newnode = new CompassNode()
                    {
                        Hierarchy = item
                    };
                    node.Childrens.Add(Newnode);
                    GetCompassTree(Newnode, c);
                }


                var ChildTables = node.Hierarchy.Tables;

                //Перебор нижней иерархии на предмет таблиц
                foreach (var item in ChildTables)
                {
                    var Newnode = new CompassNode()
                    {
                        Table = item
                    };
                    node.Childrens.Add(Newnode);
                }
            }
        }

        /// <summary>
        /// Запись Иерархий и таблиц в дерево КОМПАС
        /// </summary>
        public void UppdateCompassTree()
        {
            //Обновление дерева классов
            //Они храниться в Базе данных Kampas3
            using (Kampas3Context context = new Kampas3Context())
            {
                //Из таблицы Hierarchies берем строки в которых столбец Tables содержит ParentId равный 0
                var roots = context.Hierarchies.Include(x => x.Tables).Where(x => x.ParentId == 0 && x.Id != x.ParentId);

                //Перебираем и записываем корневые
                foreach (var item in roots)
                {
                    var node = new CompassNode()
                    {
                        Hierarchy = item
                    };
                    KompassNodes.Add(node);
                    GetCompassTree(node, context);
                }
            }
        }

        /// <summary>
        /// Отображение деталей в гриде 
        /// </summary>
        /// <param name="table">Выбранная таблица</param>
        public void ChangeParts(Table table)
        {
            using (var c = new Kampas3Context())
            {
                table.Records.Clear();
                table.Records = c.Records.Where(r => r.Table == table).ToList();
                foreach (var item in table.Records)
                {
                    Records.Add(item);
                }
            }

        }

        /// <summary>
        /// Удаление деталей Компас
        /// </summary>
        public void DeleteKompass()
        {
            if (Record != null)
            {
                using (var c = new Kampas3Context())
                {
                    c.Records.Remove(Record);
                    c.SaveChanges();
                }
            }
        }
        #endregion

        /// <summary>
        /// КОнвертирование из солида в компас
        /// </summary>
        public void SolidToCompass()
        {
            //проверка на выделенные элементы
            if (SelectedKompassNode.Table == null || TewCatreference == null)
            {
                MessageBox.Show("Выбраны не все элементы.", "Варинг");
                return;
            }
                

            using (var c = new Kampas3Context())
            {
                var newSupplier = c.Suppliers.Where(x => x.Name == TewCatreference.CreSuppliername).FirstOrDefault();

                if (newSupplier == null && TewCatreference.CreSuppliername != string.Empty)
                {
                    newSupplier = new Supplier()
                    {
                        Id = c.Suppliers.Count(),
                        Name = TewCatreference.CreSuppliername,
                    };

                    c.Suppliers.Add(newSupplier);
                    c.SaveChanges();
                }

                var record = new Record()
                {
                    Id = Guid.NewGuid().ToString().Replace("-",""),
                    Group = TewCatreference.CreLibName,
                    Name = TewCatreference.CreReference,
                    SupplierId = TewCatreference.CreSuppliername != string.Empty ? c.Suppliers.FirstOrDefault(x => x.Name == TewCatreference.CreSuppliername).Id : 1,
                    Kind = 5,
                    Length = (double)TewCatreference.CreImplantz,
                    Width = (double)TewCatreference.CreImplantx,
                    Hight = (double)TewCatreference.CreImplanty,
                    TableId = SelectedKompassNode.Table.Id
                };

                c.Records.Add(record);
                c.SaveChanges();
            }
            Records.Clear();
            ChangeParts(SelectedKompassNode.Table);
        }

        /// <summary>
        /// Конвертирование из компаса в солид
        /// </summary>
        public void CompassToSolid()
        {
            if (SelectedNode == null || Record == null)
            {
                MessageBox.Show("Выбраны не все элементы.", "Варинг");
                return;
            }

            var catref = new TewCatreference()
            {
                CreLibName = Record.Group,
                CreReference = Record.Name,
                CreSuppliername = Record.Supplier?.Name,
                CreObjecttype = 0,
                CreImplantz = Record.Length,
                CreImplantx = Record.Width,
                CreImplanty = Record.Hight,
                CreNodClauid = SelectedNode.Current.NodClauid,
            };

            using (var c = new TewCatalogContext())
            {
                c.TewCatreferences.Add(catref);
                c.SaveChanges();
            }

            CatReferences.Clear();
            ChangeCatReference(SelectedNode);
        }

        //Ивент изменения свойства 
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Вызов ивента Об изменении свойства (реализация интерфейса INotifyPropertyChanged)
        /// </summary>
        /// <param name="prop">Измененное свойство</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
