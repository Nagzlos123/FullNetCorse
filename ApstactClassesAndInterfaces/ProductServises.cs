using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApstactClassesAndInterfaces
{
    public class ProductServises : IProductServise
    {
        public static string GetProductName()
        {
            throw new NotImplementedException();
        }

        public void Updata(Product product)
        {
            throw new NotImplementedException();
        }

        public int Add(Product product) 
        {
            return 1;
        }
    }
}
