using System.ComponentModel;
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
using Getting_Real.Models;
using Getting_Real.ViewModels;

namespace Getting_Real
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mvm = new();

        public MainWindow()
        {           
            mvm.handler.CreateParkingSpots();
            DataContext = mvm;

            InitializeComponent();
        }

        private void btnAddParking_Click(object sender, RoutedEventArgs e)
        {
            mvm.AddNewVehicle();
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            List<Vehicle> listConversion = mvm.VehiclesVM.ToList();
            mvm.fileManager.WriteToFile("test.txt", listConversion);
        }

        private void btnDeleteParking_Click(object sender, RoutedEventArgs e)
        {
            mvm.DeleteSelectedVehicle();
        }

        private void btnUpdateList_Click(object sender, RoutedEventArgs e)
        {
            mvm.UpdateVMList(mvm.handler.UpdateVehicles());
        }
    }
}