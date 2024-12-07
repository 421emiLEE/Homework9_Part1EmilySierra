using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Part1EmilySierra
{
    internal class Truck : Vehicle
    {
        private double loadCapacity;
        private int towingCapacity;
        public Truck() {
            
        }

        //public Truck(int numberOfCylinders, Person owner, double loadCapacity, int towingCapacity)
        //{
        //    setNumberOfCylinders(numberOfCylinders);
        //    this.loadCapacity = loadCapacity;
        //    this.towingCapacity = towingCapacity;
        //}
        public Truck(ManufacturerName manufacturer, int numberOfCylinders, Person owner, double loadCapacity, int towingCapacity)

        {
            this.manufacturer = manufacturer;
            this.numberOfCylinders = numberOfCylinders;
            this.owner = owner;
            this.loadCapacity = loadCapacity;
            this.towingCapacity = towingCapacity;
        }
        public double getLoadCapacity()
        {
            return loadCapacity;
        }
        public void setLoadCapacity(double loadCapacity)
        {
            this.loadCapacity = loadCapacity;
        }

        public int getTowingCapacity()
        {
            return towingCapacity;
        }
        public void setTowingCapacity(int towingCapacity)
        {
            this.towingCapacity = towingCapacity;
        }

        //private Person Person(Person owner)
        //{
        //    throw new NotImplementedException();
        //}


        public override string ToString()
        {
            return base.ToString() + $", Load Capacity: {loadCapacity} tons, Towing Capacity: {towingCapacity} pounds";
        }
    }
}
