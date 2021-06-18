using System;
using System.Collections.Generic;
using System.Text;

namespace Web_E_Tickets
{
    public class Flight
    {
        public string Plane { get; set; }
        public DateTime DateDepature { get; set; }
        public DateTime DateArrival { get; set; }
        public string CityDepature { get; set; }
        public string CityArrival { get; set; }
        public int TotalSeats { get; set; }
        public int FreeSeats { get; set; }
        public float Price { get; set; }
        public Flight()
        {
            DateDepature = DateTime.Now;
            DateArrival = DateTime.Now.AddHours(3);
            CityDepature = "City #1";
            CityArrival = "City #2";
            Plane = "Plane";
            TotalSeats = 10;
            FreeSeats = TotalSeats;
            Console.WriteLine($"{GetType().Name} default ctor called");
        }
        public Flight(DateTime dateDepature, DateTime dateArrival, string cityDepature, string cityArrival, string plane, int totalSeats)
        {
            DateDepature = dateDepature;
            DateArrival = dateArrival;
            CityDepature = cityDepature;
            CityArrival = cityArrival;
            Plane = plane;
            TotalSeats = totalSeats;
            FreeSeats = TotalSeats;
            Console.WriteLine($"{GetType().Name} initializer ctor called");
        }
        public Flight(Flight flt)
        {
            DateDepature = flt.DateDepature;
            DateArrival = flt.DateArrival;
            CityDepature = flt.CityDepature;
            CityArrival = flt.CityArrival;
            Plane = flt.Plane;
            TotalSeats = flt.TotalSeats;
            FreeSeats = flt.TotalSeats;
            Console.WriteLine($"{GetType().Name} copy ctor called");
        }
    }
}
