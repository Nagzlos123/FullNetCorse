using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Service
{
    public class UserService : Services
    {
       
        public void Add(User user)
        {
            base.Add(user);
        }

        public User? Get(int id)
        {
            return GetById(id) as User;
        }

   
    }
}
