using System;

namespace Lecture4HomeWork
{
    class Program
    {

        static int MinArrayElementFinder(int[] array)
        {
            return array[MinArrayIndexFinder(array)];
        }

        static int MaxArrayElementFinder(int[] array)
        {
            return array[MaxArrayIndexFinder(array)];
        }

        static int MinArrayIndexFinder(int[] array)
        {
            int minArrayIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[minArrayIndex])
                {
                    minArrayIndex = i;
                }
            }

            return minArrayIndex;
        }

        static int MaxArrayIndexFinder(int[] array)
        {
            int maxArrayIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[maxArrayIndex])
                {
                    maxArrayIndex = i;
                }
            }

            return maxArrayIndex;
        }
        static int GetSumOfOddArrayElements(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum += array[i];
                }
            }

            return sum;
        }

        static int[] Reverse(int[] array)
        {
            int halfArray = array.Length / 2;
            for (int i = 0; i < halfArray; i++)
            {
                Swap(ref array[i], ref array[array.Length - 1 - i]);
            }
            return array;
        }

        static int CountOddElements(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    count += array[i];
                }
            }
            return count;
        }

        static int[] SwapHalfArray(int[] array)
        {
            int halfArray = array.Length / 2;
            int rightPos = halfArray + array.Length % 2;
            for (int i = 0; i < halfArray; i++)
            {
                Swap(ref array[i], ref array[rightPos + i]);
            }
            return array;
        }

        static int[] AscendingInsertOrderArray(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int number = array[i];
                for (int j = i - 1; j>= 0;)
                {
                    if(number < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = number;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return array;
        }

        static int[] SelectionDescendingArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int smallestIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[j] > array[smallestIndex])
                    {
                        smallestIndex = j;
                    }    
                }
                Swap(ref array[smallestIndex], ref array[i]);
            }
            return array;
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[9];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 10);
            }
            PrintArray(arr);
            PrintArray(SelectionDescendingArray(arr));
            //Console.WriteLine(CountOddElements(arr));
        }

        #region Utils
        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }

        #endregion
    }
}
