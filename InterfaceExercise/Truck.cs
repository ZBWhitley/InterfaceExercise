using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public bool Has4WD { get; set; }
        public string Cab { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int WheelCount { get; set; }
        public string Logo { get; set; }
        public bool Domestic { get; set; }
    }
}
