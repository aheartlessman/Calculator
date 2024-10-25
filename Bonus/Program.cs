using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет введи первое число");
            string summ = Console.ReadLine();
            Console.WriteLine("Привет введи второе число");
            string summ2 = Console.ReadLine();
            int number1 = Converter(summ);
            int number2 = Converter(summ2);
            Console.WriteLine("Что ты выберешь?\n+\n*\n/\n-");
            string operation = Console.ReadLine();
            
            switch(operation)
            {
                case "+":
                    plus(number1, number2);
                    break;
                    case "-":
                    minus(number1, number2);
                    break;
                    case "*":   
                    multi(number1, number2);
                    break;
                    case "/":
                    division(number1, number2); 
                    break;
            }
            Console.ReadKey();
        }

        static int Converter(string summ)
        {
            int number;
            int.TryParse(summ, out number);
            return number;
        }
        static void plus(int number1, int number2)
        {
                int sum = number1 + number2;
                Console.WriteLine("Результат: " + sum);
        }

        static void multi(int number1, int number2)
        {
            int sum = number1 * number2;
            Console.WriteLine("Результат: " + sum);
        }
        static void division (int number1, int number2)
        {
            int sum = number1 / number2;
            Console.WriteLine("Результат: " + sum);
        }

        static void minus(int number1, int number2)
        {
            int sum = number1 - number2;
            Console.WriteLine("Результат: " + sum);
        }

    }
}
