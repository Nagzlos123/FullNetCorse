using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public interface ICarType<T>
        where T : ICarType<T>
    {
        public ICarType<T> Identify();
    }
}
