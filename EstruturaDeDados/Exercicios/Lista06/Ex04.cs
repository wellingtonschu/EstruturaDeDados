using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Lista06
{
    class Ex04
    {

        public static double sum(double i)
        {

            double soma = 0;

            for (double aux = i; i >= 1; i--)
            {

                soma = soma + 2 * Math.Pow(i, 2) + 2 * i + 8;

            }

            return soma;

        }

    }
}
