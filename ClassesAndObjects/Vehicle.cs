using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Vehicle
    {
        public string Name { get; set; }
        public int EngineCapasity { get; set; }

        public string Color { get; set; } = "Green";

        public int Sound { get; set; } = 0;

        public Vehicle()
        {
            
        }

        public Vehicle(string name, int engineCapasity)
        {
            Name = name;
            EngineCapasity = engineCapasity;
        }
        public void Start()
        {
            Sound = 100;
        }


        public void Stop()
        {
            Sound = 0;
        }

        public override string ToString()
        {
            return $"Name: {Name}, EngineCapasity: {EngineCapasity}, Color: {Color}, Sound: {Sound} ";
        }
    }
}
