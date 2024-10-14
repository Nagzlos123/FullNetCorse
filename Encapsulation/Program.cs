namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product = new Product(1, "abc", 100);
            Console.WriteLine(product.Id);
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Price);
        }
    }
}
