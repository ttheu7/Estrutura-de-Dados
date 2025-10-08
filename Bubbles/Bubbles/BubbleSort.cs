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
            for (int i = array.Length - 1; i > 0; i--)
            {
                bool isAnyChange = false;
                for (int j = 1; j <= i; j++)
                {
                    if (array[j - 1].CompareTo(array[j]) < 0)
                    {
                        isAnyChange = true;
                        Swap(array, j, j - 1);
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