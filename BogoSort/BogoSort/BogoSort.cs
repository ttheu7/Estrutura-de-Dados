using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boguinho
{
    public static class BogoSort
    {
        private static Random random = new Random();
    
        public static void Sort(int[] array)
        {
            int tries = 0;
            
            while (!IsOrdened(array))
            {
                Shuffle(array);
                tries++;
            }
            
            Console.WriteLine($"\nNúmero de tentativas: {tries}");
        }
        
        private static bool IsOrdened(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                    return false;
            }
            return true;
        }
        
        private static void Shuffle(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }

}

