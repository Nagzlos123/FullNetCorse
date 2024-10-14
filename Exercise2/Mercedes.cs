using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Mercedes : Car
    {
        public override void Start()
        {
            Console.WriteLine("Start Mercedes!");
        }

        public override void Stop()
        {
            Console.WriteLine("Stop Mercedes!");
        }
    }
}
