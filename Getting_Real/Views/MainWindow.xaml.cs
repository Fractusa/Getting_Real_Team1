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
using Getting_Real.ViewModels;
using Getting_Real.Models;

namespace Getting_Real
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataHandler handler = new();
        FileManager file = new();

        public MainWindow()
        {
            
            handler.CreateParkingSpots();
            handler.AddVehicle("Bob", 123, "Hej123", handler.parkingSpots[0].ParkingSpotId, DateOnly.MaxValue, DateOnly.MinValue);
            handler.AddVehicle("Bo13b", 1663, "Hej12223", handler.parkingSpots[1].ParkingSpotId, DateOnly.MaxValue, DateOnly.MinValue);
            handler.AddVehicle("Bob", 14443, "Hej11523", handler.parkingSpots[2].ParkingSpotId, DateOnly.MaxValue, DateOnly.MinValue);
            file.WriteToFile("test.txt", handler.Vehicles());
            
            InitializeComponent();

        }      
    }
}