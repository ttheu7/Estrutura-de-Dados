using System.Collections;

Dictionary<int, int> dic = new Dictionary<int, int>
{
    {100001, 7984},
    {100002, 5484},
    {100003, 1313},
    {100004, 4646}
};

Console.WriteLine("Quantos produtos você deseja adicionar? ");
int n = int.Parse(Console.ReadLine()!);

for(int i = 0; i < n; i++)
{
    Console.Write("Digite o código de rastreio: ");
    int codigoRastreio = int.Parse(Console.ReadLine()!);

    Console.WriteLine();

    Console.Write("Digite o código de barras: ");
    int codigoBarras = int.Parse(Console.ReadLine()!);

    try
    {
        dic.Add(codigoRastreio, codigoBarras);
    }
    catch (ArgumentException)
    {
        Console.WriteLine("Código de rastreio já existente. Tente novamente.");
    }
}

Console.WriteLine();
Console.Write("Deseja rastrear o produto por código de rastreio (R) ou de barras (B): ");
char escolha = char.Parse(Console.ReadLine()!.ToUpper());

if(escolha == 'R')
{
    Console.Write("Digite o código de rastreio: ");
    int codigo = int.Parse(Console.ReadLine()!);

    if(dic.ContainsKey(codigo))
    {
        Console.WriteLine($"Código de barras: {dic[codigo]}");
    }
    else
    {
        Console.WriteLine("Código de rastreio não encontrado.");
    }
}
else if(escolha == 'B')
{
    Console.Write("Digite o código de barras: ");
    int codigo = int.Parse(Console.ReadLine()!);

    bool found = false;
    foreach(KeyValuePair<int, int> kvp in dic)
    {
        if(kvp.Value == codigo)
        {
            Console.WriteLine($"Código de rastreio: {kvp.Key}");
            found = true;
            break;
        }
    }

    if(!found)
    {
        Console.WriteLine("Código de barras não encontrado.");
    }
}
else
{
    Console.WriteLine("Opção inválida. Encerrando o programa.");
}