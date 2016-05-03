using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sort;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {

            Sort s = new Sort();

            int[] arr = { 10, 8, 3, 1, 9, 7, 4, 3 };

            Console.WriteLine("Initial Array");
            Console.WriteLine(String.Join(" ", arr));
            Console.ReadKey();

        }
    }
}
