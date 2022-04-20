using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1._1.Models
{
    internal class Room
    {
        private static int _id;
        public int Id { get;}
        public Room()
        {
            _id++;
            Id = _id;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; }

        public string ShowInfo()
        {
            return $"Name--{Name} Price--{Price} PersonCapacith--{PersonCapacity} IsAvailable--{IsAvailable}";
        }

        public Room(string name,double price,int personcapacith)
        {
            Name = name;
            Price = price;
            PersonCapacity = personcapacith;           

        }

        
    }
}
