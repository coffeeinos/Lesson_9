using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson_9_part_3
{
    class Program
    {
        static void searchIndex (int number)
        {
            int[] array = new int[1000];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    Console.WriteLine("Index of your number is " + i);
                    return;
                }
            }
            Console.WriteLine("Your number wasn't found");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number the index of which you want to know");
            searchIndex(int.Parse(Console.ReadLine()));
        }
    }
}
