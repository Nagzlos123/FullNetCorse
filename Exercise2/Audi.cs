using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Audi : Car
    {
        public override void Honk()
        {
            Console.WriteLine("Audi Horn");
        }
        public override void Start()
        {
            Console.WriteLine("Start Audi!");
        }

        public override void Stop()
        {
            Console.WriteLine("Stop Audi!");
        }
    }
}
