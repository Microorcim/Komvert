using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSolidCompass.HelpModels
{
    /// <summary>
    /// Класс для дерева ячеек компаса
    /// </summary>
    public class CompassNode
    {
        public CompassNode Parent { get; set; }
        public string CurrentName 
        { 
            get
            {
                if (Hierarchy != null)
                    return Hierarchy.Name;
                else if (Table != null)
                    return Table.Name;
                else 
                    return string.Empty;
            }
        }
        public Hierarchy? Hierarchy { get; set; }
        public Table? Table { get; set; }
        public ObservableCollection<CompassNode> Childrens { get; set; } = new ObservableCollection<CompassNode>();
        public CompassNode() { }

        public CompassNode(CompassNode parent) { Parent = parent; }
    }
}
