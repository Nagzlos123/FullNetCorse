﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class DbConnection
    {
        public DbConnection()
        {
            Console.WriteLine("Connection with Database established");
        }

        public void Send<T>(T obj) where T : class
        {
            Console.WriteLine($"Send {obj.GetType().FullName}");
        }
    }
}

