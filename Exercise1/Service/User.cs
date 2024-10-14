using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Service
{
    public class User : BaseId
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            // password shouldn't be visible
            return $"Id = {Id}; Name = {Name}; Email = {Email};";
        }
    }
}
