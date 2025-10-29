using Boguinho;

int[] array = { 5, 2, 8, 1, 9, 15, 58, 77, -1 };

Console.WriteLine("Array original:");
Console.WriteLine(string.Join(", ", array));

BogoSort.Sort(array);

Console.WriteLine("\nArray ordenado:");
Console.WriteLine(string.Join(", ", array));