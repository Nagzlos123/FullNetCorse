using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class DbService
    {
        protected readonly DbConnection _dbConnection;

        public DbService(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public void Send<T>(T obj) where T : class
        {
            _dbConnection.Send(obj);
        }
    }
}
