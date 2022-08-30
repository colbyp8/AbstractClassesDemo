using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Default";
        public string Model { get; set; } = "Default";

        public abstract void DriveAbstract(); //stubbed out method

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }
    }
    
}
