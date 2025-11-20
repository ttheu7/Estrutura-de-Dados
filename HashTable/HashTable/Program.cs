using System.Collections;

Hashtable ht = new Hashtable()
{
  {"Matheus","123"},  //chave-valor
  {"Ttheu","456"}  
};

ht["Sutema"] = "789"; //adiciona
ht.Add("Mago", "777"); //adiciona

if(ht.Count > 0)
{
    foreach (DictionaryEntry entry in ht)
    {
        Console.WriteLine($"Chave {entry.Key}, Valor: {entry.Value}");
    }
} else
{
    Console.WriteLine("Tabelha Hash vazia!");
}

/*Adicionar chave repetida à tabela, o programa interrompe a execução! Por isso usamos try {} e catch {}*/

Console.WriteLine("Informe a chave: ");
string ?key = Console.ReadLine();

Console.WriteLine("Informe o valor: ");
string ?value = Console.ReadLine();

try
{
    ht.Add(key!, value);
    Console.WriteLine("Adicionado!");
}
catch
{
    Console.WriteLine("Não é possível adicionar chaves iguais!");
}

Console.Write("O que procuras: ");
string ?search = Console.ReadLine();

if (ht.Contains(search!))
{
    Console.WriteLine($"Encontrado {search}, {ht[search!  ]}");
} else
{
    Console.WriteLine($"{search} não existe na tabela!");
}