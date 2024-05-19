using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Real.Models
{
    public class Vehicle
    {
        private string ownerName;
        private int ownerBookingNumber;
        private DateOnly arrivalDate;
        private DateOnly departureDate;
        private string model;
        private string numberPlate;


        public string OwnerName
        { get; set; }

        public int OwnerBookingNumber
        { get; set; }

        public string NumberPlate
        { get; set; }

        public int ParkingSpotId
        { get; set; } 

        public DateOnly ArrivalDate
        { get; set; }

        public DateOnly DepartureTime
        { get; set; }

        public Vehicle(string ownerName, int ownerBookingNumber, string numberPlate, int parkingSpotId, DateOnly arrivalDate, DateOnly departureTime)
        {
            this.OwnerName = ownerName;
            this.OwnerBookingNumber = ownerBookingNumber;
            this.NumberPlate = numberPlate;
            this.ParkingSpotId = parkingSpotId;
            this.ArrivalDate = arrivalDate;
            this.departureDate = departureTime;
        }
    }
}
