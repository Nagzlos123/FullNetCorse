using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public interface IService<T>
       where T : class, IBaseDto
    {
        public int Add(T dto);
        public void Update(T dto);
        public void Delete(T dto);
        public T? Get(int id);
        public IList<T> GetAll();
    }
}
