using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    class Program
    {
        static void Main(string[] args)
        {
            bubbleSort b = new bubbleSort();
            selectionSort s = new selectionSort();
            insertionSort i = new insertionSort();

            int[] array = { 10, 8, 3, 1, 9, 7, 4, 3 };

            Console.WriteLine("Array inicial - Bubble Sort");
            Console.WriteLine(String.Join(" ", array));
            b.BubbleSort(array);
            Console.ReadKey();

            Console.WriteLine("\nArray inicial - Selection Sort");
            Console.WriteLine(String.Join(" ", array));
            s.SelectionSort(array);
            Console.ReadKey();

            Console.WriteLine("\nArray inicial - Insertion Sort");
            Console.WriteLine(String.Join(" ", array));
            i.InsertionSort(array);
            Console.ReadKey();

        }
    }
}
