using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApstactClassesAndInterfaces
{
    public interface IProductServise
    {
        void Updata(Product product);

        static abstract string GetProductName();
        int Add(Product product)
        {
            return 0;
        }

    }
}
