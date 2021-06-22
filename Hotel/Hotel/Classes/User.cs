using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class User
    {
        public User()
        {

        }
        public User(int id, float balance, string firstName, string lastName)
        {
            Id = id;
            Balance = balance;
            FirstName = firstName;
            LastName = lastName;
            Console.WriteLine($"Ctor {GetType().Name} was called");
        }

        public int Id { get; set; }
        public float Balance { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract bool CheckIsRoomFree(Room room);
    }
}
