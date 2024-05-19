using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Real.Models
{
    public class ParkingSpot
    {
        private int parkingSpotId;
        private bool parkingSpotFree = true;

        public int ParkingSpotId
        { get; set; }

        public bool ParkingSpotFree
        { get; set; }

        public ParkingSpot(int parkingSpotId, bool parkingSpotFree)
        {
            this.ParkingSpotId = parkingSpotId;
            this.ParkingSpotFree = parkingSpotFree;
        }

        public ParkingSpot()
        {

        }
    }
}
