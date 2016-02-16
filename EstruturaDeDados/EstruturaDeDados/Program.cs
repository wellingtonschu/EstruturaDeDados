using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            aritmetica minhasContas = new aritmetica();
            int num1, num2, resultado;

            Console.WriteLine("Digite dois números");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            resultado = minhasContas.soma(num1, num2);

            Console.WriteLine("resultado = " + resultado);

            Console.ReadKey();
        }
    }
}
