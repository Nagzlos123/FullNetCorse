using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Country
    {
        public string Name { get; private set; }
        public string Code { get; private set; }

        private Country(string name, string code )
        {
            Name = name;
            Code = code;
        }

        public Country ChangeName(string name) 
        {
            Name = name;
            return this;
        }

        public Country ChangeCode(string code)
        {
            Code = code;
            return this;
        }

        public static Country Create(string name, string code)
        {
            return new Country(name, code);
        }
    }
}
