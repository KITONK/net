using System;
using System.Collections.Generic;
using System.Text;

namespace Web_E_Tickets
{
    public abstract class AbstractUser 
    {
        private readonly string _password;

        public int id { get; set; }
        public string Name { get; }
        public string Surname { get; }
        public float Balance { get; set; }

        public abstract bool CheckPassword(string password);
        public abstract void AddTIcket(Ticket ticket);
        public abstract string GetTickets();

        protected  List<Ticket> Tickets;
        public AbstractUser()
        {
            _password = "password";
            Name = "name";
            Surname = "surname";
            Balance = 1;
            Tickets = new List<Ticket>();
            Console.WriteLine($"{GetType().Name} default ctor called");
        }
        public AbstractUser(string password, string name, string surname, float balance)
        {
            _password = password;
            Name = name;
            Surname = surname;
            Balance = balance;

            Console.WriteLine($"{GetType().Name} initialize ctor called");
        }
        public AbstractUser(AbstractUser usr)
        {
            _password = usr._password;
            Name = usr.Name;
            Surname = usr.Surname;
            Balance = usr.Balance;

            Console.WriteLine($"{GetType().Name} copy ctor called");
        }
 
    }
}
