using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Lista06
{
    class Ex03
    {

        public static double sum(double i)
        {

            if (i == 1)

                return 2 * Math.Pow(i, 2) + 2 * i + 8;

            else

                return (2 * Math.Pow(i, 2) + 2 * i + 8) + sum(i - 1);

        }

    }
}
