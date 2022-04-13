using System;
using System.Collections.Generic;
using System.Text;

namespace Practies_S.Main
{
    internal class Teacher:Person
    {
        private int _exp;
        private static int _id = 0;
        public int id { get; }
        public Teacher()
        {
            _id++;
            id = _id;
        }

        public int Experiance { 
            get 
            { 
                return _exp;
            }
            set 
            {
                if (value >= 1 && value <= 80)
                {
                    value = _exp;
                }
            } 
        }



    }
}
