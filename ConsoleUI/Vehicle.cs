using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */
    public abstract class Vehicle
    {
      public string Model {  get; set; } = "Model";
      public string Make { get; set; } = "Make";
      public int Year { get; set; } = 1900;
       
        public abstract void DriveAbstract();

        public abstract void DriveVirtual();
    }
}
