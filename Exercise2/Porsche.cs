using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Porsche : Car
    {
        public override void Honk()
        {
            Console.WriteLine("Porsche Horn");
        }
        public override void Start()
        {
            Console.WriteLine("Start Porsche!");
        }

        public override void Stop()
        {
            Console.WriteLine("Stop Porsche!");
        }
    }
}
