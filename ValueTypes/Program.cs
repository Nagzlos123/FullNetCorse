using System.Runtime.CompilerServices;

namespace ValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int number1 = 0;
            float number2 = 4.5f;
            double number3 = 5.7;
            decimal number4 = 2.567m;
            char charakter = 'a';
            bool isValid = false;
            Price price1 = new Price();

            // Typy wartościowe

            //1.Zadeklaruj zmienną typu całkowitego o nazwie number i przypisz jej wartość 200
            int number = 200;

            //2.Zadeklaruj stałą typu znak o nazwie new line i przypisz jej wartość "\"
            const char newLine = '\\';

            //3.Zadeklaruj stałą typu zmiennoprzecinkowego o nazwie weight i przypisz jej wartość 25.5
            const double weight = 25.5;

            //4.Zadeklaruj zmienną typu zmiennoprzecinkowego o stałej precyzji o nazwie price i przypisz jej wartość 1250
            decimal price = 1250m;

            //5.Zadeklaruj zmienną typu logicznego o nazwie is loading i przypisz jej wartość true
            bool isLoading = true;
        }
    }

    struct Price 
    {
        public int Value;
        public Price(int value) { 
        Value = value;
        }
    }
}
