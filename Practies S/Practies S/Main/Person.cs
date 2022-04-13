using System;
using System.Collections.Generic;
using System.Text;

namespace Practies_S.Main
{
    public class Person
    {
        private int _age;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { 
            get 
            {
                return _age;
            } 
            set 
            {
                if (value>0)
                {
                    _age = value;
                }
            } 
        }
    }
}
