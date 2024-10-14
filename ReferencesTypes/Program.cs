using System;

namespace ReferencesTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 10;
            int secondNumber = firstNumber;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);

            secondNumber = 35;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);

            Price price = new Price();
            price.Value = 45;
            Price price2 = price;
            Console.WriteLine(price.Value);
            Console.WriteLine(price2.Value);

            price2.Value = 400;

            Console.WriteLine(price.Value);
            Console.WriteLine(price2.Value);

            string charakter = $"price = {price2.Value}";
            Console.WriteLine(charakter);

            //Typy referencyjne

            //1.Napisz klasę o nazwie „car”.

            //2.Napisz zmienną, która będzie przechowywać ciąg znaków o nazwie name i przypisz jej wartość „Cathy”.
            string name = "Cathy";
        }
    }
}
