using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Part1EmilySierra
{
    internal class Person
    {

        private String name;
        public Person() { 
            name = " ";
        }

        public Person(string name)
        {
            this.name = name;
        }
        public Person(Person obj)
        {
            this.name = obj.name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return this.name;


        }
        public bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                Person obj2 = (Person)obj;
                return name == obj2.name;
            }

        }
    }
}
