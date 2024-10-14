using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class License
    {
        public string Value { get;}
        public License(string value)
        {
            ValidationOfLicense(value);
            Value = value;
        }
        private static void ValidationOfLicense(string value)
        {
            
            //brak możliwości podania pustego znaku / znaków
            //licencja nie powinna być krótsza niż 11 znaków
            //brak możliwości wpisania pustej wartości
            //brak możliwości wpisania wartości null
            if (string.IsNullOrEmpty(value) || value.Length < 11)
            {
                throw new ArgumentException("License is invalid!");
            }

            //przykład jak ma wyglądać licencja {rok}/{miesiąc}/{dzień}/{nr_licencji}

            //podzielenie wartości na cześci używając seperatora '/'
            string[] licentsParts = value.Split('/');
            if (licentsParts.Length < 4)
            {
                throw new ArgumentException("License is invalid!");
            }

            //proba konversji stringa na liczby

            if(!int.TryParse(licentsParts[0], out int year) ||
               !int.TryParse(licentsParts[1], out int month) ||
               !int.TryParse(licentsParts[2], out int day) ||
               !int.TryParse(licentsParts[3], out int licenceNumber)
               )
            {
                throw new ArgumentException("License is invalid!");
            }

            //dotatkowe warunki

            if(day < 10 && licentsParts[2].Length == 1 || month < 10 && licentsParts[1].Length == 1)
            {
                throw new ArgumentException("License is invalid!");
            }

            if (year < 2020 || month < 1 || month > 12|| day < 1 || day > 31 || licenceNumber > 1)
            { 
                throw new ArgumentException("License is invalid!");
            }

        }
        public override string ToString()
        {
            return Value;
        }
    }
}
