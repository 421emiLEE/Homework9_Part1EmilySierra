using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Part1EmilySierra
{
    internal class Vehicle
    {
        public enum ManufacturerName { GMC, CHEVROLET, GEM, JEEP, TESLA };
        protected ManufacturerName manufacturer;
        protected int numberOfCylinders;
        protected Person owner;
        public Vehicle() {
            manufacturer = ManufacturerName.GMC;
            numberOfCylinders = 0;
            owner = new Person();
        }

        public Vehicle(ManufacturerName manufacturer, int numberOfCylinders, Person owner)
        {
            this.manufacturer = manufacturer;
            this.numberOfCylinders = numberOfCylinders;
            this.owner = owner;
        }

        public Person getOwner()
        {
            return owner;
        }
        public void setOwner(Person owner)
        {
            this.owner = owner;
        }

        public override string ToString()
        {
            return $"Manufacturer: {manufacturer}, Number of Cylinders: {numberOfCylinders}, Owner: {owner}";
        }

        //getters and setters
        public int getNumberOfCylinders()
        {
            return numberOfCylinders;
        }
        public void setNumberOfCylinders(int numberOfCylinders)
        {
            this.numberOfCylinders = numberOfCylinders;
        }
    }
}
