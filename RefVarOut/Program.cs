namespace RefVarOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nummber = 0;
            SetTwoRef(ref nummber);
            Console.WriteLine($"Number: {nummber}");

            SetTwoOut(out int nummber2);
            Console.WriteLine($"Number: {nummber2}");
        }

        static void SetTwoRef(ref int i)
        {
            i = 2;
        }

        static void SetTwoOut(out int i)
        {
            i = 2;
        }


        
    }
}
