using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : ICompany, IVehicle
    {
        public int Passengers { get; set; }
        public bool CanTow { get; set; }
        public string Logo { get; set; }
        public bool Domestic { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int WheelCount { get; set; }
    }
}
