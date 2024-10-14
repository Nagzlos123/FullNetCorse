using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Service
{
    public class Cart : BaseId
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }

        public override string ToString()
        {
            return $"Id = {Id}; ProductId = {ProductId}; UserId = {UserId}";
        }
    }
}
