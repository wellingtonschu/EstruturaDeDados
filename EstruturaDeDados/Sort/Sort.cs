using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Sort
    {

        public static void BubbleSort(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {

                for (int j = 0; j < array.Length - i - 1; j++)
                {

                    if (array[j] > array[j + 1])
                    {

                        int auxiliar = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = auxiliar;

                    }

                }

                Console.WriteLine("Após passo " + (i + 1));
                //Imprime arry após cada passo
                Console.WriteLine("[" + String.Join(" ", array) + "]" );

            }

        }

        public static void selectionSort(int[] arr)
        {

            int N = arr.Length;

            for (int i = 0; i < N; i++)
            {

                int menor = arr[i];
                int posicao = i;

                for (int j = i + 1; j < N; j++)
                {

                    if (arr[j] < menor)
                    {

                        menor = arr[j];
                        posicao = j;

                    }

                }

                int temp = arr[posicao];

                arr[posicao] = arr[i];
                arr[i] = temp;
                Console.WriteLine("Depois da iteração " + (i + 1));

            }

            Console.WriteLine(String.Join(" ", arr));
        }

        public static void insertionSort(int[] arr)
        {

            int N = arr.Length;
            for (int i = 1; i < N; i++)
            {

                int j = i - 1;
                int temp = arr[i];

                while (j >= 0 && temp < arr[j])
                {

                    arr[j + 1] = arr[j];
                    j--; ;

                }

                arr[j + 1] = temp;
                Console.WriteLine("After pass " + i);
                //Printing array after pass
                Console.WriteLine(String.Join(" ", arr));

            }

        }

    }

}
