using Boguinho;

int[] array = { 5, 2, 8, 1, 9, 15, 58, 77, -1 };
string[] arrayA = {"Chico", "Sabo", "Tesao", "Aba", "Doodles" };

Console.WriteLine("Array original:");
Console.WriteLine(string.Join(", ", arrayA));

BogoSort.Sort(arrayA);

Console.WriteLine("\nArray ordenado:");
Console.WriteLine(string.Join(", ", arrayA));