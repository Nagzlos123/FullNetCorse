namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? number= null;
            //number.Value = 20;
            

            if (number != null)
            {

            }

            if (number is not null) 
            { 

            }

            if (number.HasValue)
            {

            }

            Console.WriteLine(number.HasValue ? number.Value : 0);

            Console.WriteLine(number.GetValueOrDefault());
        }
    }
}
