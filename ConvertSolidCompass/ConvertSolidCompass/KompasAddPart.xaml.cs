using ConvertSolidCompass.ViewModels;
using System.Windows;


namespace ConvertSolidCompass
{
    /// <summary>
    /// Логика взаимодействия для KompasAddPart.xaml
    /// </summary>
    public partial class KompasAddPart : Window
    {
        CompassRecordViewModel vm;

        public KompasAddPart(string id)
        {
            InitializeComponent();

            vm = new CompassRecordViewModel(id);

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
