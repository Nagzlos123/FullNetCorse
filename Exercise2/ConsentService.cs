using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class ConsentService
    {
        private readonly List<Consent> _list = new();

        public void Add(ConsentDto item)
        {
            _list.Add(item.AsBase());
        }

        public ConsentDto? Get(int id)
        {
            foreach (var item in _list)
            {
                if (item.Id == id)
                {
                    return new()
                    {
                        Id = item.Id,
                        Name = item.Name
                    };
                }
            }

            return null;
        }
    }
}
