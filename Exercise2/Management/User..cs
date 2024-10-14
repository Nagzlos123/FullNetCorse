using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.Management
{
    public class User : BaseId
    {
        public string UserName { get; set; }
        public string Role { get; set; }
        public List<Claim> Claims { get; set; }
    }
}
