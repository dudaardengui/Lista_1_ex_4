using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, X, RESULTADO;
            Console.WriteLine("Digite um número:");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número:");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número:");
            X = int.Parse(Console.ReadLine());

            if (X < 5)
            {
                RESULTADO = (B - A) * X;
                Console.WriteLine();
                Console.WriteLine(RESULTADO);
            }
            else
            {
                RESULTADO = (A + B) * X;
                Console.WriteLine();
                Console.WriteLine(RESULTADO);
            }
            Console.ReadKey();
        }
    }
}
