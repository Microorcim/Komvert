using ConvertSolidCompass;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSolidCompass.HelpModels
{
    /// <summary>
    /// Класс для ячеек солида
    /// </summary>
    public class SolidNode
    {
        public SolidNode Parent { get; set; }
        public TewNode Current { get; set; }
        public ObservableCollection<SolidNode> Childrens { get; set; } = new ObservableCollection<SolidNode>();

        public SolidNode() { }

        public SolidNode(SolidNode parent) { Parent = parent; }
    }
}
