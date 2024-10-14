using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_Inheritance
{
    public class Lion 
    {
        private readonly LandAnimal _landAnimal;
        public Lion(LandAnimal landAnimal)
        {
            _landAnimal = landAnimal;
        }
    }
}
