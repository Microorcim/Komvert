using ConvertSolidCompass.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ConvertSolidCompass
{
    /// <summary>
    /// Логика взаимодействия для SolidAddPart.xaml
    /// </summary>
    public partial class SolidAddPart : Window
    {
        SolidPartViewModel vm;

        public SolidAddPart(Guid claId)
        {
            InitializeComponent();

            vm = new SolidPartViewModel(claId);
            this.DataContext = vm;
        }

        private void SaveBt_Click(object sender, RoutedEventArgs e)
        {
            vm.Save();
            Close();
        }

        private void CansleBt_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
