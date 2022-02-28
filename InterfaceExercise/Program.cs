using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<IVehicle>();

            var c1 = new Car() { Year = 2003, Make = "Subaru", Model = "WRX", WheelCount = 4, Domestic = false, Logo = "Stars", Size = "Compact Sedan", Trunk = true };
            vehicles.Add(c1);
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(c1))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(c1);
                Console.WriteLine("{0} = {1}", name, value);
            }
            Console.WriteLine();
            Console.WriteLine();

            var t1 = new Truck() { Year = 1989, Make = "Chevy", Model = "K1500", WheelCount = 4, Domestic = true, Logo = "Bowtie", Cab = "Extended", Has4WD = false };
            vehicles.Add(t1);
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(t1))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(t1);
                Console.WriteLine("{0} = {1}", name, value);
            }
            Console.WriteLine();
            Console.WriteLine();

            var s1 = new SUV() { Year = 2016, Make = "Honda", Model = "CRV", WheelCount = 4, Domestic = false, Logo = "H", CanTow = false, Passengers = 5 };
            vehicles.Add(s1);
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(s1))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(s1);
                Console.WriteLine("{0} = {1}", name, value);
            }

            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
