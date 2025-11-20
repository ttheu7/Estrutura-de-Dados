

Dictionary<string, int> dic = new Dictionary<string, int>
{
    {"Chave 1", 100},
    {"Chave 2", 200}
};

dic["Chave 3"] = 150; 
dic.Add("Chave 4", 300);

if(dic.ContainsKey("Chave 4"))
{
    Console.WriteLine($"Encontrou a chave: Chave 4 com valor {dic["Chave 4"]}");
}

foreach(KeyValuePair<string, int> kvp in dic)
{
    Console.WriteLine($"Chave: {kvp.Key}, Valor: {kvp.Value}");
}

