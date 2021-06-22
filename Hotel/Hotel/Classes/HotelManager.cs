using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class HotelManager<T> where T : User
    {
        public List<Room> rooms { get; set; } = new List<Room>();
        public List<Visitor> visitors { get; set; } = new List<Visitor>();

        public HotelManager()
        {
            Room room1 = new Room(1, false, 50);
            Room room2 = new Room(2, true, 100);
            Room room3 = new Room(3, true, 125);
            Visitor visitor1 = new Visitor(1, 1000, "Lucie", "Mcgee", room1);
            Visitor visitor2 = new Visitor(2, 1000, "Parker", "Lugo", room2);

            rooms.Add(room1);
            rooms.Add(room2);
            rooms.Add(room3);
            visitors.Add(visitor1);
            visitors.Add(visitor2);
            
            Console.WriteLine($"Ctor {GetType().Name} was called");
        }

        public void BookRoom(int roomNumber, int userId)
        {
            Visitor visitor = FindVisitorByNumber(userId);
            visitor.Notify += User_Notify;
            Room room = FindRoomByNumber(roomNumber);

            if (room.IsBooked)
            {
                room.IsBooked = false;
                visitor.BookRoom(room);
            }
            else
            {
                throw new HotelException("Выбранная комната уже забронирована!");
            }
        }

        public Room FindRoomByNumber(int roomNumber)
        {               
            return rooms.FirstOrDefault(r => r.Number == roomNumber);
        }

        public Visitor FindVisitorByNumber(int id)
        {
            return visitors.FirstOrDefault(u => u.Id == id);
        }

        public List<Room> GetFreeRooms()
        {
            List<Room> freeRooms = new List<Room>();
            foreach (var item in rooms)
            {
                if(item.IsBooked)
                {
                    freeRooms.Add(item);
                }
            }

            return freeRooms;
        }

        public List<Room> GetRooms()
        {
            return rooms;
        }

        public List<Visitor> GetVisitors()
        {
            return visitors;
        }


        private static void User_Notify(string message)
        {
            Console.WriteLine(message);
        }
    }
}
