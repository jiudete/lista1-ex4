using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;
            int b;
            int h;
            Console.Write("Informe o valor da base do triângulo: "); 
            b = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor da altura do triângulo: ");
            h = int.Parse(Console.ReadLine());
            A = (b * h) / 2;
            Console.WriteLine("o valor da sua área é {0} ", A);
            
        }
    }
}
