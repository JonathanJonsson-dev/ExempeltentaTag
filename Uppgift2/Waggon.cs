using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift2
{
    public class Waggon
    {
        public List<Seat> Seats { get; set; }

        public Waggon(int numberOfSeats)
        {
            Seats = new List<Seat>(numberOfSeats);
            InitializeSeats(numberOfSeats);
        }

        public void InitializeSeats(int numberOfSeats)
        {
            
            for (int i = 0; i < numberOfSeats; i++)
            {
                Seat seat = new Seat();
                seat.SeatNumber = i + 1;
                Seats.Add(seat);
            }
            
        }

        public void FillSeats()
        {
            Random random = new Random();
            foreach (Seat seat in Seats)
            {
                if (random.NextDouble() <= 0.5)
                {
                    seat.IsTaken = true;
                }
                else
                {
                    seat.IsTaken = false;
                }
            }
        }

        

    }
}
