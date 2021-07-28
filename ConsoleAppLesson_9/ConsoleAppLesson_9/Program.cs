using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson_9
{
    // функции и методы 
    class Program
    {
        static int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum of these numbers is " + Sum(firstNumber, secondNumber));
        }
    }
}
