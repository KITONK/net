using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Web_E_Tickets
{
    public class User : AbstractUser
    {
        private readonly string _password;
        public User()
        {
            Notify += WriteMessage;
           
        }

        public delegate void UserHandler(string message);

        public event UserHandler Notify;
        public User(AbstractUser usr): base (usr)
        {
            Notify += WriteMessage;
        }
        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }

        public User(string password, string name, string surname, float balance) : base(password,name,surname,balance)
        {
            Notify += WriteMessage;
        }
       
        public override bool CheckPassword(string password)
        {
            return _password.Equals(password);
        }
        public void RemoveTicket(Flight _flight)
        {
            var ticket = Tickets.FirstOrDefault(t => t.flight.Equals(_flight));
            if (ticket == null) return;
            Tickets.Remove(ticket);
            ticket.user = null;
            Notify?.Invoke($"Ticket {ticket.flight.CityArrival}  - {ticket.flight.CityDepature}delted");
        }

        public string CheckTickets()
        {
            Func<string, Ticket, string> func = delegate (string current, Ticket ticket)
            {
                return current + (ticket.flight.CityArrival + "\n");
            };
            return Tickets.Aggregate("", func);
        }
        public override void AddTIcket(Ticket ticket)
        {
            Tickets.Add(ticket);
        }
        public override string GetTickets()
        {
            string tickets = "";

            for (int i = 0; i < Tickets.Count; i++)
            {
                tickets += Tickets[i].flight.CityArrival;
            }
            return tickets;
        }
        public static User operator ++(User user)
        {
            ++user.Balance;
            return user;
        }
        public static User operator --(User user)
        {
            --user.Balance;
            return user;
        }
        public static User operator +(User user, float sum)
        {
            if (sum < 0) throw new ArgumentException("Sum should be >0");
            user.Balance += sum;
            return user;
        }
        public static User operator -(User user, float sum)
        {
            if (sum < 0) throw new ArgumentException("Sum should be >0");
            user.Balance -= sum;
            return user;
        }
        public static bool operator <(User user, Flight flight)
        {

            return user.Balance < flight.Price;
        }
        public static bool operator >(User user, Flight flight)
        {

            return user.Balance > flight.Price;
        }
        public static bool operator ==(User user, Flight flight)
        {

            return (user.Balance.Equals(flight.Price));
        }
        public static bool operator !=(User user, Flight flight)
        {

            return !(user.Balance.Equals(flight.Price));
        }

      





    }
}
