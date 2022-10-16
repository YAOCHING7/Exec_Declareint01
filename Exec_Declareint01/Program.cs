using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Declareint01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 1 + ((2 + 2) * 3) - 1;
            Console.WriteLine(number1);

            int number2 = 120 / 7;
            int number3 = 120 % 7;
            Console.WriteLine(number2);
            Console.WriteLine(number3);

            int number4 = 9 % 2;
            Console.WriteLine(number4);
            int number5 = 202 % 2;
            Console.WriteLine(number5);

            int number6 = 2;
            int number7 = 3;
            int exchange = number6;

            number6 = number7;
            number7 = exchange;

            Console.WriteLine($"對調結果:number6={number6},number7={number7}");
            
        }
    }
}
