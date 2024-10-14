using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Lexus : Car
    {
        public override void Honk()
        {
            Console.WriteLine("Lexus Horn");
        }
        public override void Start()
        {
            Console.WriteLine("Start Lexus!");
        }

        public override void Stop()
        {
            Console.WriteLine("Stop Lexus!");
        }
    }
}
