using ConvertSolidCompass.HelpModels;
using ConvertSolidCompass.Models.Catalog;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;

namespace ConvertSolidCompass
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();

            viewModel = new MainViewModel();
            this.DataContext = viewModel;
        }

        private void Import_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Export_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TVClasses_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            viewModel.SelectedNode = (SolidNode)e.NewValue;
        }
         
        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var catreference = ((DataGridRow)sender).Item as TewCatreference;

            if (catreference != null)
            {
                SolidAddPart solid = new SolidAddPart(catreference.CreUid);
                solid.ShowDialog();
                viewModel.CatReferences.Clear();
                viewModel.ChangeCatReference(viewModel.SelectedNode);
            }

        }

        private void DataGridRow_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            var record = ((DataGridRow)sender).Item as Record;

            if (record != null)
            {
                KompasAddPart kompas = new KompasAddPart(record.Id);
                kompas.ShowDialog();
                viewModel.Records.Clear();
                viewModel.ChangeParts(viewModel.SelectedKompassNode.Table);
            }
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            viewModel.SelectedKompassNode = (CompassNode)e.NewValue;
        }

        private void BDKMu_Click(object sender, RoutedEventArgs e)
        {
            //Открытие сторонних программ
            System.Diagnostics.Process.Start($"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\\ASCON\\KOMPAS-Electric v22\\BDK_Mng.exe");
        }

        private void UBDMu_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start($"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\\ASCON\\KOMPAS-Electric v22\\BDK_Update.exe");
        }

        private void EBDMu_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start($"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\\ASCON\\KOMPAS-Electric v22\\BDK_Copying.exe");

        }

        private void FOMu_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start($"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\\ASCON\\KOMPAS-Electric v22\\BFO_Mng.exe");

        }

        private void UGOMu_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start($"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\\ASCON\\KOMPAS-Electric v22\\BUGO_Mng.exe");

        }

        private void SolidToCompass(object sender, RoutedEventArgs e)
        {
            viewModel.SolidToCompass();
        }

        private void CompassToSolid(object sender, RoutedEventArgs e)
        {
            viewModel.CompassToSolid();
        }

        private void DataGridRow_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            viewModel.Delete();
            viewModel.CatReferences.Clear();
            viewModel.ChangeCatReference(viewModel.SelectedNode);
        }

        private void DataGridRow_MouseRightButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            viewModel.DeleteKompass();
            viewModel.Records.Clear();
            viewModel.ChangeParts(viewModel.SelectedKompassNode.Table);
        }
    }
}