using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    public class Exception1 : Exception
    {
        public Exception1(string massage) : base(massage)
        {
            
        }
    }
}
