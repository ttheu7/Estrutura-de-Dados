using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortBubble
{
    public class BubbleSort
    {
        public static T[] Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                bool isAnyChange = false;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        isAnyChange = true;
                        Swap(array, j, j + 1);
                    }
                }

                if (!isAnyChange)
                {
                    break;
                }
            }
            return array;
        }

        private static void Swap<T>(T[] array, int i, int j)
        {
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}