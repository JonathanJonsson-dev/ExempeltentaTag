using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift2
{
    public class Seat
    {
        public int SeatNumber { get; set; }
        public string Type { get; set; }
        public bool IsTaken { get; set; }

        public override string ToString()
        {
            if (IsTaken == true)
            {
                return $"Plats {SeatNumber} är upptagen";
            }
            else
            {
                return $"Plats {SeatNumber} är ledig";
            }
            
        }
    }
}
