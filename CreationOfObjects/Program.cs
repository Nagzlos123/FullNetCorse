namespace CreationOfObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Price price1 = Price.Create(100);
            Price price2 = Price.Create(100);
            Price price3 = Price.Create(50);
            Console.WriteLine(price1);
            Console.WriteLine(price1.Equals(price2));
            Console.WriteLine($"{price1.GetHashCode()} == {price2.GetHashCode()}");
            Console.WriteLine(price1 + price2);
            Console.WriteLine(price1 - price2);
            Console.WriteLine(price1 * price2);
            Console.WriteLine(price1 / price2);
            Console.WriteLine(price1.Equals(price3));
            Console.WriteLine(price1 == price3);
            Console.WriteLine(price2 != price3);
        }
    }
}
