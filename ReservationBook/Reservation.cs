﻿

namespace ReservationBook
{
    public class Reservation
    {
        public Reservation(DateTime @from, DateTime to)
        {
            From = @from;
            To = to;
        }
        public DateTime From { get; set; }
        public DateTime To { get; set; }

    }
}
