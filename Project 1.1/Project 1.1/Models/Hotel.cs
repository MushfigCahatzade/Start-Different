using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1._1.Models
{
    internal class Hotel
    {
        public string Name { get; set; }
        private Room[] Rooms=new Room[0];
        public void AddStudent(Room Roomss)
        {
            Array.Resize(ref Rooms, Rooms.Length + 1);
            Rooms[Rooms.Length - 1] = Roomss;
        }
        public void MakeReservation()
        {

        }
        public Hotel(string name)
        {
            Name = name;
        }
    }
}
