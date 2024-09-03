using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Real.Models
{
    public class DataHandler
    {
        private FileManager fileManager = new();
        public List<ParkingSpot> parkingSpots = new();
        public List<Vehicle> vehicles = new();     
        private DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
        private Vehicle vehicle;
        private ParkingSpot parkingSpot;
        private int numberOfParkingSpots = 8;

        public void CreateParkingSpots()
        {
            for (int i = 1; i <= numberOfParkingSpots; i++)
            {
                parkingSpots.Add(new ParkingSpot(i, true));
            }
        }

        public List<Vehicle> Vehicles()
        { return vehicles; }

        public string ConvertTypeToString<T>(T typeToConvert)
        {
            string strConversion;

            //if (typeToConvert is ParkingSpot parking)
            //{
            //    strConversion = $"{parking.ParkingSpotId},{parking.ParkingSpotFree}";
            //}
            if (typeToConvert is Vehicle vehicle)
            {
                //vehicle.ParkingSpotId = parkingSpot;

                strConversion = $"{vehicle.OwnerName},{vehicle.OwnerBookingNumber},{vehicle.NumberPlate},{vehicle.ParkingSpotId}," +
                                                                                   $"{vehicle.ArrivalDate},{vehicle.DepartureDate}";
            }
            else
            {
                return strConversion = "Conversion failed";
            }

            return strConversion;
        }

        public void AddVehicle(string ownerName, int ownerBookingNumber, string numberPlate, int parkingSpotId, 
                                                                            DateOnly arrivalDate, DateOnly departureDate)
        {
            int selectedParkingSpot = 0;

            foreach (ParkingSpot parkingSpot in parkingSpots)
            {
                if (parkingSpot.ParkingSpotFree)
                {
                    selectedParkingSpot = parkingSpotId;
                    parkingSpot.ParkingSpotFree = false;
                    break;
                }
                //else
                //{
                //    throw (new ArgumentException("No free parkingspots"));
                //}
            }            

            Vehicle currentVehicle = new Vehicle(ownerName, ownerBookingNumber, numberPlate, selectedParkingSpot, arrivalDate, departureDate);

            vehicles.Add(currentVehicle);
        }

        public List<Vehicle> GetVehicles()
        {
            return vehicles;
        }

        public List<Vehicle> UpdateVehicles()
        {
            List<Vehicle> vehiclesToRemove = new();
            int listLength = vehicles.Count;

            for(int i = 0; i < listLength; i++)
            {                
                Vehicle vehicle = vehicles[i];
                if (vehicle.DepartureDate.CompareTo(currentDate) <= 0)
                {
                    vehiclesToRemove.Add(vehicle);
                    int currentParkingSpotId = vehicle.ParkingSpotId;

                    foreach (ParkingSpot parkingSpot in parkingSpots)
                    {
                        if (currentParkingSpotId == parkingSpot.ParkingSpotId)
                        {
                            parkingSpot.ParkingSpotFree = true;
                        }
                    }
                }
            }
            foreach (Vehicle vehicle in vehiclesToRemove)
            {
                int j = 0;
                if(vehicle == vehicles[j])
                {
                    vehicles.Remove(vehicle);
                    if(j < vehicles.Count)j++;
                    else
                    {
                        return vehiclesToRemove;
                    }
                }
            }

            return vehiclesToRemove;
        }

        public void LoadList()
        {
            vehicles = fileManager.ReadFromFile2("test.txt");
        }        
    }
}