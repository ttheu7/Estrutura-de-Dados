using System;
using SortBubble; 

Random random = new Random();
int[] numbers = new int[10];


for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(-100, 100);
}

Console.WriteLine("Array original:");
Console.WriteLine(string.Join(", ", numbers));

BubbleSort.Sort(numbers);

Console.WriteLine("\nArray ordenado (decrescente):");
Console.WriteLine(string.Join(", ", numbers));

Console.ReadKey();