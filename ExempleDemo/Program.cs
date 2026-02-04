

List<string> maList = new List<string>();


for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Entrez un element à ajouter à la liste");
    string element = Console.ReadLine();

    maList.Add(element);
}

Console.WriteLine($"Il y a {maList.Count} elements dans la liste");

foreach (string value in maList)
{
    Console.WriteLine(value);
}