namespace StaticExtensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = "Lubie placki";
            string text2 = test.AddExtraLineWithText("Bigos");

            Console.WriteLine(text2);
        }
    }
}
