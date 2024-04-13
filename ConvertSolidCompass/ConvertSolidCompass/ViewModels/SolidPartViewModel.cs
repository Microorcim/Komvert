using ConvertSolidCompass.Models.Catalog;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSolidCompass.ViewModels
{
    internal class SolidPartViewModel : INotifyPropertyChanged
    {
        private TewCatreference _classification;

        public TewCatreference Classification 
        {
            get => _classification;
            set
            {
                if (_classification != value)
                {
                    _classification = value;
                    OnPropertyChanged("Classification");
                }
            }
        }

        public SolidPartViewModel(Guid classificationId)
        {
            Classification = GetClassification(classificationId);
        }

        public TewCatreference GetClassification(Guid classificationId)
        {
            using (var c = new TewCatalogContext())
            {
                return c.TewCatreferences.First(x => x.CreUid == classificationId);
            }
        }

        public void Save()
        {
            using (var c = new TewCatalogContext())
            {
                c.Entry(Classification).State = EntityState.Modified;
                c.SaveChanges();
            }
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
