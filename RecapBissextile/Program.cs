

//Creer deux liste : bissextile et nonBissextile de type string
List<string> bissextile = new List<string>();
List<string> nonBissextile = new List<string>();

// dans une boucle demander une date à l'utilisateur ( 10x )
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Entrez une année!");
    string annee = Console.ReadLine();

    int anneeConverted = int.Parse(annee);

    if ((anneeConverted % 4 == 0 && anneeConverted % 100 != 0) || (anneeConverted % 400 == 0))
    {
        bissextile.Add(annee);
    }
    else
    {
        nonBissextile.Add(annee);
    }
}

Console.WriteLine("Les années Bissextiles");
foreach (string annee in bissextile)
{
    Console.WriteLine(annee);
}

Console.WriteLine();

Console.WriteLine("Les années non Bissextiles");
foreach (string annee in nonBissextile)
{
    Console.WriteLine(annee);
}