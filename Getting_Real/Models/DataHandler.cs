using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Real.Models
{
    public class DataHandler
    {
        private List<ParkingSpot> parkingSpots = new();
        private List<Vehicle> vehicles = new();     
        private DateOnly currentTime = DateOnly.FromDateTime(DateTime.Now);
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

        public void AddVehicle(string ownerName, int ownerBookingNumber, string numberPlate, ParkingSpot parkingSpotId, 
                                                                            DateOnly arrivalDate, DateOnly departureDate)
        {
            ParkingSpot selectedParkingSpot = parkingSpots[0];

            foreach (ParkingSpot parkingSpot in parkingSpots)
            {
                if (parkingSpot.ParkingSpotFree)
                {
                    selectedParkingSpot = parkingSpot;
                    parkingSpot.ParkingSpotFree = false;
                    break;
                }
                else
                {
                    throw (new ArgumentException("No free parkingspots"));
                }
            }

            Vehicle currentVehicle = new Vehicle(ownerName, ownerBookingNumber, numberPlate, selectedParkingSpot, arrivalDate, departureDate);

            vehicles.Add(currentVehicle);
        }

    
        private void UpdateVehicles()
        {
            foreach(Vehicle vehicle in vehicles)
            {
                if (vehicle.DepartureTime <= currentTime)
                {
                    vehicles.Remove(vehicle);
                    ParkingSpot currentParkingSpotId = vehicle.ParkingSpotId;

                    foreach(ParkingSpot parkingSpot in parkingSpots)
                    {
                        if(currentParkingSpotId == parkingSpot)
                        {
                            parkingSpot.ParkingSpotFree = true;
                        }


                    }
                }


            }
        }

        //public Vehicle GetVehicle(ParkingSpot parkingSpodId)
        //    {
        //         foreach ()
        //    }
    }
}
