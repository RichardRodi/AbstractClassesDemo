using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles


            //*Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle(use explicit typing) but use constuctors from derived classes

            //* Set the properties values with object initializer syntax

            Car myAudi = new Car
            { Model = "A4",
                Make = "Audi",
                Year = 2021,
                HasTrunk = true,
            };

            MotorCycle myMotorCycle = new MotorCycle
            { Model = "Katana",
                Make = "Suzuki",
                Year = 2024,
                HasSideCar = true,
            };

            Vehicle myVehicle1 = new Car
            { Model = "Focus",
            Make = "Ford",
            Year = 2023,
            };

            Vehicle myVehicle2 = new MotorCycle
            {
                Model = "Tenere",
                Make = "Yamaha",
                Year = 2022,
            };

            // Create a list of Vehicle called vehicles
            //*Add the 4 vehicles to the list

            List<Vehicle> vehicles = new List<Vehicle> { myAudi, myMotorCycle, myVehicle1, myVehicle2 };


            /* Using a foreach loop iterate through the list and display each of the properties
            */
            // Call each of the drive methods for one car and one motorcycle
            foreach (var automobile in vehicles )
            {
                Console.WriteLine($"{automobile.Year}\t{automobile.Make}\t{automobile.Model}\n");
                
                automobile.DriveAbstract();
                automobile.DriveVirtual();
             
                    
                if (automobile is MotorCycle motorCycle)
                {
                    Console.WriteLine($"This Vehicle has a Side Car: {motorCycle.HasSideCar}\n");
                }
                if (automobile is Car car)
                {
                    Console.WriteLine($"This Vehicle has a Trunk: {car.HasTrunk}\n");
                }
            }

            Console.ReadLine();
        }
    }
}
#endregion