using System;
using System.Diagnostics;

namespace QuickSort
{
    internal class Program
    {

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        
        static int Sort(int[] array, int minIndex, int maxIndex)
        {
            int index = minIndex - 1;
            for (int i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    index++;
                    Swap(ref array[index], ref array[i]);
                }
            }
            index++;
            Swap(ref array[index], ref array[maxIndex]);
            return index;
        }

        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            int index = Sort(array, minIndex, maxIndex);
            QuickSort(array, minIndex, index - 1);
            QuickSort(array, index + 1, maxIndex);

            return array;
        }

        static int[] QuickSort(int[] array, int length)
        {
            return QuickSort(array, 0, length - 1);
        }


        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            string[] value = Console.ReadLine().Trim().Split();
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = Convert.ToInt32(value[i]);
            }

            QuickSort(array, length);
            //Array.Sort(array);

            Console.WriteLine(String.Join(" ", array));
        }
    }
}
