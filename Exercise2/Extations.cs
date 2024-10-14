using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public static class Extations
    {
        public static Headphones AsBase(this HeadphonesDto dot) 
        {
            return new Headphones
            {
                Id = dot.Id,
                Name = dot.Name,
            };
        }

        public static HeadphonesDto AsDot(this Headphones hp)
        {
            return new HeadphonesDto
            {
                Id = hp.Id,
                Name = hp.Name,
            };
        }


        public static Consent AsBase(this ConsentDto dot)
        {
            return new Consent
            {
                Id = dot.Id,
                Name = dot.Name,
            };
        }

        public static ConsentDto AsDot(this Consent hp)
        {
            return new ConsentDto
            {
                Id = hp.Id,
                Name = hp.Name,
            };
        }
    }
}
