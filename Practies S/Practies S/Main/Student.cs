using System;
using System.Collections.Generic;
using System.Text;

namespace Practies_S.Main
{
    public class Student:Person
    {
        private static int _id;
        public int Id { get; }
        public Student()
        {
            _id++;
            Id = _id;
        }

        string[] Lesson; 
    }
}
