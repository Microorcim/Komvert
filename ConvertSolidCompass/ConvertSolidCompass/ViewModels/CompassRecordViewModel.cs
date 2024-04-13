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
    internal class CompassRecordViewModel : INotifyPropertyChanged
    {
        private Record _record;
        public Record Record
        {
            get => _record;
            set
            {
                if (_record != value)
                {
                    _record = value;
                    OnPropertyChanged("Record");
                }
            }
        }

        public List<Supplier> Suppliers { get; set; } = new List<Supplier>();

        public CompassRecordViewModel(string recordId)
        {
            Record = GetRecord(recordId);
        }

        public Record GetRecord(string recordId)
        {
            using (var c = new Kampas3Context())
            {
                c.Suppliers.ForEachAsync(Suppliers.Add);
                Suppliers.OrderBy(x => x.Name);
                return c.Records.Include(x => x.Supplier).First(x => x.Id == recordId);
            }
        }

        public void Save()
        {
            using (var context = new Kampas3Context())
            {
                // The next step implicitly attaches the entity
                context.Entry(Record).State = EntityState.Modified;
                // Do some more work...
                context.SaveChanges();
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
