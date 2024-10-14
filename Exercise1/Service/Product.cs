using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Service
{
    public class Product : BaseId
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            // description could be so long and don't want to show
            return $"Id = {Id}; Name = {Name}; Category = {Category}";
        }
    }
}
