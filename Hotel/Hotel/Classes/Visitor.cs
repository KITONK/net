using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Visitor : User
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;
        
        public Visitor(int id, float balance, string firstName, string lastName, Room room) : base(id, balance, firstName, lastName)
        {
            Room = room;
            Console.WriteLine($"Ctor {GetType().Name} was called");
        }

        public Room Room { get; set; }
        
        public override bool CheckIsRoomFree(Room room)
        {
            if(room.IsBooked)
            {
                return true;
            }
            return true;
        }

        public void BookRoom(Room room)
        {            
            if (Balance >= room.Cost)
            {
                Balance -= room.Cost;
                Notify?.Invoke($"Со счёта были сняты средства: {room.Cost}");
            }
            else
            {
                Notify?.Invoke($"Для совершения операции недостаточно средств. Ваш текущий баланс: {Balance}");
            }
        }
    }
}
