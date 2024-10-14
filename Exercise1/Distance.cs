using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Distance
    {
        public const double VALUE_OF_ONE_MILE = 0.621371192;
        public double Value { get; private set; }

        private Distance(double value)
        {
            ChangeValue(value);
            Value = value;
        }

        public static Distance New(double value)
        {
            return new Distance(value);
        }

        public Distance ChangeValue(double value)
        {
            CheckValue(value);
            Value = value;
            return this;
        }
        public string DisplayASKilomiters()
        {
            return $"{Math.Round(Value, 4)} km";
        }
        public string DisplayASMiles()
        {
            return $"{Math.Round(Value * VALUE_OF_ONE_MILE, 4)} mi";
        }

        public static void CheckValue(double value) 
        {
            if (value < 0) 
            {
                throw new ArgumentException($"Value '{value}' can not be negative!");
            }
        }
    }
}
