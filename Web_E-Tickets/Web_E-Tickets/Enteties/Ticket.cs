using System;
using System.Collections.Generic;
using System.Text;

namespace Web_E_Tickets
{
    public class Ticket
    {

        public int id;
        public Ticket(Ticket ticket)
        {
            user = ticket.user;
            flight = ticket.flight;

            Console.WriteLine($"{GetType().Name} copy ctor called");
        }
        public Ticket()
        {
            user = new User("pass", "name", "surname", 10);
            flight = new Flight(DateTime.Now, DateTime.Now.AddHours(3), "depart", "arrival", "plane", 20);
            Console.WriteLine($"{GetType().Name} default ctor called");
        }

        public Ticket(User user, Flight flight)
        {
            this.user = user;
            this.flight = flight;

            Console.WriteLine($"{GetType().Name} initializer ctor called");
        }
        public User user { get; set; }
        public Flight flight { get; set; }  
    }
}
