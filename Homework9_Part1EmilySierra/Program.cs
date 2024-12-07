using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Part1EmilySierra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a class called Vehicle that has the Manufracturer name (enum), number of Cyclinders in the engine (int), and the owner (Person, see below). 
            //Then create a class called Truck that is derived from Vehicle and has the additional following properties: the load capacity in tons (double), and towing capacity in pounds (int). 
            //Make sure your class has a reasonable set of constructors, getters/setters, properties and suitably defined ToString and Equals methods.  Write a driver program to test all your methods. 

            Person owner = new Person("Emily");
            Vehicle vehicle = new Vehicle(Vehicle.ManufacturerName.CHEVROLET, 4, owner);
            Truck truck = new Truck(Vehicle.ManufacturerName.GMC, 8, owner, 2.5, 5000);
            Console.WriteLine(vehicle.getOwner().GetName());

            Console.WriteLine("Vehicle: " +vehicle.getNumberOfCylinders());
            Console.WriteLine("Truck: " +truck.getNumberOfCylinders());
            
            Console.WriteLine("Vehicle " + vehicle.ToString());
            Console.WriteLine("Truck " + truck.ToString());
            Person p1 = new Person("John");
            Console.WriteLine(p1.ToString());
            Person p2 = new Person("John");
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.Equals(new Person("Jane")));


        }
    }
}
