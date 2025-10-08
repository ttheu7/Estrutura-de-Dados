using System;
using SortBubble; 

string[] words = {
    "computador",
    "sol",
    "biblioteca",
    "lua",
    "carro",
    "amizade",
    "programação",
    "café",
    "universo",
    "som"
};


Console.WriteLine("Array original:");
Console.WriteLine(string.Join(", ", words));

BubbleSort.Sort(words);

Console.WriteLine("\nArray ordenado:");
Console.WriteLine(string.Join(", ", words));

Console.ReadKey();