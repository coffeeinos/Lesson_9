using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson_9_part_2
{
    class Program
    {
        static void PrintUserSymbol (int numberSymbol, string symbol)
        {
            Console.WriteLine("");
            for (int i = 0; i < numberSymbol; i++)
            {
                Console.WriteLine((i+1) + " " + symbol);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter symbol");
            string symbol = Console.ReadLine();
            Console.WriteLine("Enter number of symbol");
            int numberSymbol = int.Parse(Console.ReadLine());
            PrintUserSymbol(numberSymbol, symbol);
        }
    }
}
