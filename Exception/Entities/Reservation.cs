using System;
using System.Collections.Generic;
using System.Text;

namespace Exception.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            RoomNumber = roomNumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Reservation: ");
            sb.Append("Room " + RoomNumber + ", ");
            sb.Append("Check-in: " + CheckIn.ToString("dd/MM/yyyy") + ", ");
            sb.Append("Check-out: " + CheckOut.ToString("dd/MM/yyyy") + ", ");
            sb.Append(Duration() + " nights");
            return sb.ToString();
        }
    }
}
