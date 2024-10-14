using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.Management
{
    public class Permission : BaseId
    {
        public string PermisionName { get; set; }
        public string PermissionValue { get; set; }
    }
}
