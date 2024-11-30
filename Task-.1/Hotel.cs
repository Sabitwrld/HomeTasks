using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_._1
{
    public class Hotel
    {
        public string Name { get; set; }
        private Room[] Rooms = new Room[0];

        public Hotel(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Hotel name cannot be null");

            Name = name;
        }

        public void AddRoom(Room room)
        {
            Array.Resize(ref Rooms, Rooms.Length + 1);
            Rooms[^1] = room;
        }

        public void MakeReservation(int roomId)
        {

            if(roomId == null)
            {
                throw new NullReferenceException("Room id cannot be null.");
            }

            Room room = Rooms[roomId];

            if (!room.IsAvailable) 
            {
                throw new NotAvailableException("Not available");
            }
            else
            {
                room.IsAvailable = false;
            }
        }     
    }
}
