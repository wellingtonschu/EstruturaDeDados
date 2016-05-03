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
            mergeSort m = new mergeSort();

            int[] arrayBubble = { 10, 6, 8, 3, 1, 5, 9, 7, 4, 2 };
            int[] arraySelection = { 10, 6, 8, 3, 1, 5, 9, 7, 4, 2 };
            int[] arrayInsertion = { 10, 6, 8, 3, 1, 5, 9, 7, 4, 2 };
            int[] arrayMerge = { 10, 6, 8, 3, 1, 5, 9, 7, 4, 2 };

            Console.WriteLine("Array inicial - Bubble Sort");
            Console.WriteLine(String.Join(" ", arrayBubble));
            b.BubbleSort(arrayBubble);
            Console.ReadKey();

            Console.WriteLine("\nArray inicial - Selection Sort");
            Console.WriteLine(String.Join(" ", arraySelection));
            s.SelectionSort(arraySelection);
            Console.ReadKey();

            Console.WriteLine("\nArray inicial - Insertion Sort");
            Console.WriteLine(String.Join(" ", arrayInsertion));
            i.InsertionSort(arrayInsertion);
            Console.ReadKey();

            Console.WriteLine("\nArray inicial - Merge Sort");
            Console.WriteLine(String.Join(" ", arrayMerge));
            m.MergeSort(arrayMerge, 0, arrayMerge.Length - 1);
            Console.ReadKey();

        }
    }
}
