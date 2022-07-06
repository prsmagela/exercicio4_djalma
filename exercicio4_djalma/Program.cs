using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4_djalma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contador do 1 ao 50");

            int num1, num2;

            num1 = 1;
            num2 = 50;

            for (; num1 <= num2; num1++)
            {
                Console.WriteLine(num1);
            }

            Console.ReadKey();
        }
    }
}
