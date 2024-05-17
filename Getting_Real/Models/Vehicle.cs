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

        public ParkingSpot ParkingSpotId
        { get; set; }

        public DateOnly ArrivalDate
        { get; set; }

        public DateOnly DepartureTime
        { get; set; }

        public Vehicle(string OwnerName, int OwnerBookingNumber, string NumberPlate, ParkingSpot parkingSpotId, DateOnly ArrivalDate, DateOnly DepartureTime)
        {
            this.OwnerName = OwnerName;
            this.OwnerBookingNumber = OwnerBookingNumber;
            this.NumberPlate = NumberPlate;
            this.ArrivalDate = ArrivalDate;
            this.departureDate = DepartureTime;
        }
    }
}
