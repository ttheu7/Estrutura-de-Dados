using Boguinho;

int[] array = { 5, 2, 8, 1, 9, 15, 58, 77, -1 };
string[] arrayA = {"Chico", "Sabo", "Tesao", "Aba", "Doodles" };

Console.WriteLine("Array original (Números):");
Console.WriteLine(string.Join(", ", array));

BogoSort.Sort(array);

Console.WriteLine("\nArray ordenado:");
Console.WriteLine(string.Join(", ", array));

Console.WriteLine("\n========================================\n");

Console.WriteLine("Array original (Strings):");
Console.WriteLine(string.Join(", ", arrayA));

BogoSort.Sort(arrayA);

Console.WriteLine("\nArray ordenado:");
Console.WriteLine(string.Join(", ", arrayA));