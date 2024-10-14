using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Sport : ICarType<Sport>
    {
        public ICarType<Sport> Identify()
        {
            return this;
        }
    }
}
