using SelectionSort;

int[] integerValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
SelectionSort.SelectionSort.Sort(integerValues);
Console.WriteLine(string.Join(" | ", integerValues));

Console.WriteLine("---------------------------------------");

string[] stringValues = { "Caneta", "Azul", "Thais", "Confessing", "Jacaré Bangão" };
SelectionSort.SelectionSort.Sort(stringValues);
Console.WriteLine(string.Join(" | ", stringValues));