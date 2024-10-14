using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Car: Vehicle
    {
        public Car(string name, int engineCapacity) : base(name, engineCapacity)
        {
            vin = 20;
        }

        public override void Start()
        {
            Sound = 150;
            base.Start();
        }

        public override void Stop()
        {
            base.Stop();
        }

        public void SetColor(string color)
        {
            Color = color;
        }
    }
}
