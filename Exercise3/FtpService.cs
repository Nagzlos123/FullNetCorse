using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class FtpService
    {
        protected readonly FtpConnection _ftpConnection;

        public FtpService(FtpConnection ftpConnection)
        {
            _ftpConnection = ftpConnection;
        }
        public void Send<T>(T obj) where T : class
        {
            _ftpConnection.Send(obj);
        }
    }
}
