using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Exercise2;

namespace Exercise2.Management
{
    public class UserDto : BaseDto
    {
        public string UserName { get; set; }
        public string Role { get; set; }
        public List<Claim> Claims { get; set; }
    }
}
