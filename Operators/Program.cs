namespace Conditions
{


    class ConditionalInstructions
    {
        public void Task1()
        {
            Console.WriteLine("Inser number:");
            var number1 = int.Parse(Console.ReadLine());
            var result = number1 % 2;
            if (result == 0)
            {
                Console.WriteLine("Numer is even");
            }
            else
            {
                Console.WriteLine("Number is not even");
            }
        }

        public void Task2() 
        {
            int number1 = 1;
            if (number1 > 0)
            {
                Console.WriteLine("Numer is positive");
            }
            else if (number1 == 0)
            {
                Console.WriteLine("Number is zero");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }
        }
        public void Task3()
        {
            int year = 2024;
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("This is leap year");
            }
            else
            {
                Console.WriteLine("This is not leap year");
            }
        }

        public void Task4()
        {
            string text1 = "abcd";
            if (text1.Contains('a', StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("String starts with a");
            }
            else
            {
                Console.WriteLine("String is not starting with a");
            }
        }

        public void Task5()
        {
            int number = 17;
            bool isPrime = true;
            for (int i = 2; i <= number / 2; i++) 
            {
                if (number % i == 0) 
                {
                   isPrime = false; 
                    break;
                }

                if (isPrime) 
                {
                    Console.WriteLine("Number is prime");
                }
            }
        }
    }

    class Loops
    {
        public void Task1()
        {
            int number = 12345;
            int result = 0;
            while (number != 0) 
            {
                result += number % 10;
                number /= 10;
            }
            Console.WriteLine($"The sum of the digits is {result}");
        }

        public void Task2()
        {
            for (int i = 2; i < 20; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void Task3()
        {
            Console.WriteLine("The program will write out the prime numbers from 2 to n");
            Console.WriteLine("Insert n:");
            var number = int.Parse(Console.ReadLine());

            for (int i = 2; i < number; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++) 
                {
                    if(i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }


        }

        public void Task4()
        {
            Console.WriteLine("The program will write out numbers divisible by 3 from 3 to n");
            Console.WriteLine("Insert n:");
            var number = int.Parse(Console.ReadLine());

            for (int i = 3;i <= number; i++)
            {
                if(i % 3 == 0) 
                    Console.WriteLine(i);
            }
        }

        public void Task5()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int number = 1;
            string text;
         
            // switch 
            switch (number)
            {
                case 1:
                    Console.WriteLine($"Number = {number}");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

            
            //switch expression

            text = number switch
            {
                1 => $"Number = {number}",
                _ => "default"
            };

            Console.WriteLine(text);


            //Instrukcje warunkowe

            ConditionalInstructions instructions = new ConditionalInstructions();
            //1.Napisz program, który sprawdzi czy podana liczba jest parzysta czy nieparzysta.
          
            //instructions.Task1();
            //2.Napisz program, który sprawdzi czy podana liczba jest dodatnia czy ujemna.
         
            //instructions.Task2();
            //3.Napisz program, który sprawdzi czy podany rok jest przestępny czy nieprzestępny.

            //instructions.Task3();

            //4.Napisz program, który sprawdzi czy podany ciąg znaków zaczyna się od litery a

            //instructions.Task4();
            //5.Napisz program, który sprawdzi czy podana liczba jest liczbą pierwszą.



            //Pętle
            Loops loops = new Loops();
            //1.Napisz program, który obliczy sumę cyfr podanej liczby.
            //loops.Task1();

            //2.Napisz program, który wypisze liczby parzyste od 2 do 20.
            //loops.Task2();

            //3.Napisz program, który wypisze liczby pierwsze od 2 do n, gdzie n jest podane przez użytkownika.
            loops.Task3();
            //4.Napisz program, który wypisze liczby podzielne przez 3 od 3 do n, gdzie n jest podane przez użytkownika.
            //loops.Task4();

            //5.Napisz program, który wypisze liczby od 10 do 1.
            //loops.Task5();
        }
    }
}
