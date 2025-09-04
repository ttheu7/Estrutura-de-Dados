using System.Collections.Generic;

Stack<char> chars = new Stack<char>();

Console.Write("Digite uma palavra: ");
string name = Console.ReadLine().toLower();
bool ch = true;

foreach(var c in name)
    chars.Push(c);

for (int i = 0; i < name.Length; i++)
{
    if (name[i] != chars.Pop())
    {
        ch = false;
        break;
    }
}

Console.WriteLine(ch ? "É palíndromo" : "Não é palíndromo");