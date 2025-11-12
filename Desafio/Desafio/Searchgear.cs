using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio
{
    public static class Searchgear
    {
        public static void Search(string[] array, string item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                string element = array[i];

                if(element == item)
                {
                    Console.WriteLine($"O elemento {element} está na posição {i} do vetor!");
                    return;
                }
            }

            Console.WriteLine("Não encontrado!");
        }
    }
}