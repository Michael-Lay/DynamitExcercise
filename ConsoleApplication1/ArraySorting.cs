using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    static class ArraySorting
    {
        public static int[] SortArray(int[] array)
        {
            if (IsSorted(array))
                return array;
            else
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    int firstInt, secondInt;
                    firstInt = array[i];
                    secondInt = array[i + 1];

                    if (firstInt < secondInt)
                    {
                        array[i] = secondInt;
                        array[i + 1] = firstInt;
                    }
                }
                return SortArray(array);
            }
        }

        public static int[] sortTwoArrays(int[] firstArray, int[] secondArray){
            List<int> firstList = firstArray.ToList();
            List<int> secondList = secondArray.ToList();
            firstList.AddRange(secondList);
            return SortArray(firstList.ToArray());
        }


        private static bool IsSorted(int[] array)
        {
            bool sorted = true;
            for (int i = array.Length-1; i > 0; i--)             
                if (array[i] > array[i - 1])
                    sorted = false;
            return sorted;
        }

    }
}
