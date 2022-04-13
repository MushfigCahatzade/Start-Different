using System;
using System.Collections.Generic;
using System.Text;

namespace Practies_S.Main
{
    public class Group
    {
        public Student[] Students = new Student[0];

        public int GroupNo { get; set; }

        public void AddStudent(Student Studentss)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = Studentss;
        }
    }
}
