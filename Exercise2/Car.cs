using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public abstract class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public void Abs()
        {
            Stop();
        }
        public virtual void Honk()
        {
            Console.WriteLine("Horn");
        }

        public abstract void Start();


        public abstract void Stop();
     
    }
}
