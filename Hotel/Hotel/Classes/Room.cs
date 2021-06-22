using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Room
    {
        public int Number { get; set; }
        public bool IsBooked { get; set; }

        private float _cost;

        public float Cost
        {
            get { return _cost; }
            set 
            {
                if(_cost >= 0)
                _cost = value; 
            }
        }
        
        public Room(int number, bool isBooked, float cost)
        {
            Number = number;
            IsBooked = isBooked;
            Cost = cost;
            Console.WriteLine($"Ctor {GetType().Name} was called");
        }

    }
}
