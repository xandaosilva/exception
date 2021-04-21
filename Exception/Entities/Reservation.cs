using Exception.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course_exception.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out must be after check-in.");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Reservetion dates for updates must be future dates.");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out must be after check-in.");
            }
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
