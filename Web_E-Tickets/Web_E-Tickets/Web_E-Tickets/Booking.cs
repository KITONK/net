using System;
using System.Collections.Generic;
using System.Text;

namespace Web_E_Tickets
{
    public class Booking:IOpperate 
    {
        public bool Excecute(User user,Flight flight)
        {
            user.Balance = user.Balance - flight.Price;
            Ticket ticket = new Ticket(user,flight);
            flight.FreeSeats = flight.FreeSeats - 1;
            user.AddTIcket(ticket);
            return true;
        }
        
    }
}
