using System.Text;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Immutable;

namespace Arrays_Lists
{
    class Arrays
    {
        public void Task1() 
        {
            int[] ints = new int[10] { 1,2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }

        public void Task2()
        {
            StringBuilder stringBuilder = new StringBuilder();
            int[] ints2 = new int[5];
            int element;
            for (int i = 0; i < ints2.Length; i++) 
            {
                Console.WriteLine($"Insert array element {i}:");
                element = int.Parse(Console.ReadLine());
                ints2[i] = element;
                stringBuilder.Append(element + ",");
            }
            Console.WriteLine($"Array: {stringBuilder}");
        }

        public void Task3()
        {
            int[] ints = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int totalResult = 0;

            for (int i = 0; i < ints.Length; i++) 
            {
                totalResult += ints[i];
            }

            Console.WriteLine($"totalResult: {totalResult}");
        }

        public void Task4()
        {
            int[] ints = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int maxElement = ints.Max();

            Console.WriteLine($"maxElement: {maxElement}");
        }

        public void Task5()
        {
            StringBuilder stringBuilder = new StringBuilder();
            int[] ints = new int[10] { 1, 2, 3, 13, 5, 61, 27, 8, 9, 10 };
           
            Array.Sort(ints);

            for (int i = 0; i < ints.Length; i++) 
            {
                stringBuilder.Append(ints[i] + ",");
            }

            Console.WriteLine($"increasOrder arrey: {stringBuilder}");
        }

    }

    class Lists
    {
        public void Task1()
        {
            StringBuilder sb = new StringBuilder();
            List<int> list1 = new List<int>();

            list1.AddRange( new int[] { 1, 2, 3, 4, 5 } );

            foreach (int i in list1) 
            { 
                sb.Append(i + ",");
            }
            Console.WriteLine($"List 1: {sb}");

        }

        public void Task2()
        {
            StringBuilder builder = new StringBuilder();
            List<string> list = new List<string>();
            string element = "";
            int length = 3;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Type string element {i}:");
                element = Console.ReadLine();
                list.Add(element);
                
                if(i == length - 1)
                {
                    builder.Append(element);
                }
                else
                {
                    builder.Append(element + ",");
                }
            }

            Console.WriteLine($"List 2: {builder}");
        }

        public void Task3()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }); 

            var result = list.Aggregate((x,y) => x + y);

            Console.WriteLine($"List total: {result}");
        }

        public void Task4()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 1, 22, 35, 14, 51, 6, 75, 98 });

            var maxElement = list.Max();
            Console.WriteLine($"Max elemet: {maxElement}");
        }

        public void Task5()
        {
            StringBuilder builder = new StringBuilder();
            List<int> list = new List<int>();
            list.AddRange(new int[] { 1000, 22, 35, 14, 51, 6, 75, 98 });

            list.Sort();

            foreach (int element in list) 
            {
                builder.Append(element + " ");
            }

            Console.WriteLine($"List: {builder}");

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tablica
            Arrays arrays = new Arrays();

            //1.Napisz program, który utworzy tablicę 10 liczb całkowitych i wypełni ją wartościami od 1 do 10.
            //arrays.Task1();

            //2.Napisz program, który utworzy tablicę 5 liczb całkowitych i wypełni ją wartościami podanymi przez użytkownika.
            //arrays.Task2();

            //3.Napisz program, który wypisze sumę elementów tablicy.
            //arrays.Task3();

            //4.Napisz program, który wypisze największy element tablicy.
            //arrays.Task4();

            //5.Napisz program, który posortuje elementy tablicy rosnąco.
            //arrays.Task5();

            //Lista
            Lists lists = new Lists();
            //1.Napisz program, który utworzy listę 5 liczb całkowitych i wypełni ją wartościami od 1 do 5.
            //lists.Task1();

            //2.Napisz program, który utworzy listę 3 napisów i wypełni ją wartościami podanymi przez użytkownika.
            //lists.Task2();

            //3.Napisz program, który wypisze sumę elementów listy.
            //lists.Task3();

            //4.Napisz program, który wypisze największy element listy.
            //lists.Task4();

            //5.Napisz program, który posortuje elementy listy rosnąco
            lists.Task5();
        }
    }
}
