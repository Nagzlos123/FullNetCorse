using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class Quest 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public QuestStatus Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}, Discryption: {Description}, Status: {Status}," +
                $" Created: {Created}, Modified: {Modified}";
        }
    }
}
