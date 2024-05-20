using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Getting_Real.Models;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Getting_Real.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public Vehicle selectedVehicle;
        public DataHandler handler = new();
        public FileManager fileManager = new();

        public MainViewModel()
        {
            handler.LoadList();
            //handler.AddVehicle("test", 1, "test", 1, new DateOnly(1992,5,10), new DateOnly(2001,2,19));
            VehiclesVM = new ObservableCollection<Vehicle>();
            List<Vehicle> vehicles = handler.GetVehicles();

            foreach (Vehicle vehicle in vehicles)
            {
                VehiclesVM.Add(vehicle);
            }
        }

        public ObservableCollection<Vehicle> VehiclesVM
        { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void AddNewVehicle()
        {
            Vehicle newVehicle = new Vehicle
            {
                OwnerName = "Skriv navn",
                OwnerBookingNumber = 0000,
                NumberPlate = "Skriv nummerplade",
                ParkingSpotId = 0,
                ArrivalDate = new DateOnly(2001,1,1),
                DepartureDate = new DateOnly(2001, 1, 1)
                //test = new DateOnly(input)
                //int input = Convert.ToInt32("2024, 5, 20")
            };

            handler.AddVehicle("Skriv navn", 0000, "Skriv nummerplade", 0, new DateOnly(2001, 1, 1), new DateOnly(2001, 1, 1));
            VehiclesVM.Add(newVehicle);

            SelectedVehicle = newVehicle;
        }

        public void DeleteSelectedVehicle()
        {
            if (SelectedVehicle != null)
            {
                VehiclesVM.Remove(SelectedVehicle);
                SelectedVehicle = null;
            }
        }

        public Vehicle SelectedVehicle
        {
            get { return selectedVehicle; }
            set
            {
                selectedVehicle = value;
                OnPropertyChanged(nameof(SelectedVehicle));
            }
        }

    //    public void updatevehiclelist()
    //    {
    //        handler.updatelist(tolist(vehiclesvm));
    //    }
    }
}
