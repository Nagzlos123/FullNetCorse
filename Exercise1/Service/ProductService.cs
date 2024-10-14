using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Service
{
    public class ProductService : Services
    {
        public void Add(Product product)
        {
            base.Add(product);
        }

        public Product? Get(int id)
        {
            return GetById(id) as Product;
        }

    }
}
