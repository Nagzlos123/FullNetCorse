using Exercise1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Service
{
    
    public class Services
    {
        protected List<BaseId> _object = new();

        protected void Add(BaseId obj)
        {
            int id = GetId();
            obj.Id = id;
            _object.Add(obj);
        }
        protected BaseId? GetById(int id)
        {
            foreach (BaseId obj in _object)
            {
                if (obj.Id == id)
                {
                    return obj;
                }
            }

            return null;
        }

        protected int GetId()
        {
            return _object.Count > 0 ? _object[^1].Id + 1 : 1;
        }
    }
}
