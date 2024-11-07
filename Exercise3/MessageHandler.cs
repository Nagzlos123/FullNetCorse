using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class MessageHandler
    {
        public event EventHandler<string> OnSendMessage;
        public void SendMessage(string message)
        {
            Console.WriteLine($"Message Send {message}");
            OnSendMessage.Invoke( this, message );
        }
    }
}
