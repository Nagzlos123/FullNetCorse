using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace ErrorHandling
{
    class Exceptions
    {
        public void Task1()
        {
            try
            {

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        public void Task2()
        {
            try
            {

            }
            catch (ArgumentNullException ex1)
            {

                Console.WriteLine(ex1.Message);
            }
            catch(FormatException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            catch(OverflowException ex3)
            {
                Console.WriteLine(ex3.Message);
            }
        }

        public void Task3()
        {
            try
            {
                Console.WriteLine("Type first number to sum:");
                var number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Type second number to sum:");
                var number2 = int.Parse(Console.ReadLine());
                var sum = number1 + number2;
                Console.WriteLine($"Sum: {sum}");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error: {ex.Message}");
            }
          
        }

        public void Task4()
        {
            try
            {
                Console.WriteLine("Type number:");
                var number = double.Parse(Console.ReadLine());
                var roundNumber = Math.Round(number, 2);

                Console.WriteLine($"roundNumber: {roundNumber}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void Task5()
        {
           

            try
            {
                Console.WriteLine("Type first number:");
                var number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Type second number:");
                var number2 = int.Parse(Console.ReadLine());
                var quotient = number1 / number2;
                Console.WriteLine($"Quotient: {quotient}");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Obsługa wyjątków
            Exceptions exceptions = new Exceptions();
            //1.Obsłuż wyjątki w metodzie Main
            exceptions.Task1();

            //2.Obsłuż kilka typów wyjątków ArgumentNullException, FormatException, OverflowException w metodzie Main
            exceptions.Task2();

            //3.Napisz program, który pobiera od użytkownika dwie liczby całkowite i wyświetla ich sumę.Wykorzystaj metodę Parse
            //do konwersji na typ całkowity.Pamiętaj, że ktoś może celowo podać literę zamiast cyfry. Spróbuj obsłużyć tą sytuację,
            //tak aby nie wystąpił wyjątek.
            //exceptions.Task3();

            //4.Napisz program, który pobiera od użytkownika liczbę i wyświetla jej wartość zaokrągloną do dwóch miejsc po przecinku.
            //Wykorzystaj metodę Parse do konwersji na typ zmiennoprzecinkowy.Pamiętaj, że ktoś może celowo podać literę zamiast cyfry.
            //Spróbuj obsłużyć tą sytuację, tak aby nie wystąpił wyjątek.
            //exceptions.Task4();

            //5.Napisz program, który pobiera od użytkownika dwie liczby i wyświetla ich iloraz.
            exceptions.Task5();
        }
    }
}
