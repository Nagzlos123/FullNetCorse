using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_Inheritance
{
    public class Butterfly
    {
        private readonly FlyingAnimal _fly;

        public Butterfly(FlyingAnimal flyingAnimal)
        {
            _fly = flyingAnimal;
        }
    }
}
