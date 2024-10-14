using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Elegance : ICarType<Elegance>
    {
        public ICarType<Elegance> Identify()
        {
            return this;
        }
    }
}
