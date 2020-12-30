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
                seat.Type = SetType(seat);
                Seats.Add(seat);
            }
            
        }

        public string SetType(Seat seat)
        {
            if (seat.SeatNumber % 2 == 0)
            {
                return "Gång";
            }
            else
            {
                return "Fönster";
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

        public List<Seat> GetFreeSeats(int numberOfSeats)
        {
            int counter = 0;
            List<Seat> freeSeats = new List<Seat>();
            foreach (Seat seat in Seats)
            {
                if (seat.IsTaken != true & counter < numberOfSeats)
                {
                    freeSeats.Add(seat);
                    counter++;
                }

            }

            return freeSeats;
        }

    }
}
