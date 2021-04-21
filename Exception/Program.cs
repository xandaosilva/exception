using Course_exception.Entities;
using Course_exception.Entities.Exceptions;
using System;

namespace Course_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Check-in date(dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date(dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine(reservation);

                Console.WriteLine("\nEnter data to update the reservation:");
                Console.Write("Check-in date(dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date(dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine(reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation : " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error : " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error : " + e.Message);
            }
        }
    }
}
