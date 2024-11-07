using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class MessageSender
    {
        public void SendMail(Message message)
        {
            Console.WriteLine("Sending mail");
        }

        public void SendHttpMessage(Message message)
        {
            Console.WriteLine("Sending http");
        }

        public void SendFtpMessage(Message message)
        {
            Console.WriteLine("Sending ftp");
        }
    }
}
