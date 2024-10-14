using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Service
{
    public class CartService : Services
    {
        public void Add(Cart cart)
        {
            base.Add(cart);
        }

        public Cart? Get(int id)
        {
            return GetById(id) as Cart;
        }

    }
}
