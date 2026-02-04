
// Creer une liste<string>
List<string> vehicules = new List<string>();

// ajouter cinq vehicules
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Entrez un vehicule num {i + 1}");

    vehicules.Add(Console.ReadLine());
}

// afficher le nombre d'element dans la liste
Console.WriteLine($"Il y a actuellement {vehicules.Count} vehicules dans le garage");

// afficher tout les elements de la liste avec un foreach
foreach (string vehicule in vehicules)
{
    Console.WriteLine(vehicule);
}


// -----------------------------------------------

//Creer un dictionnaire<int,string> 
Dictionary<int, string> myDico = new Dictionary<int, string>();


// ajouter cinq pays
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Entrez la clé du pays à ajouter (int)");
    int key = int.Parse(Console.ReadLine());

    Console.WriteLine("Entrez le pays à ajouter (string)");
    string valeur = Console.ReadLine();

    myDico.Add(key, valeur);
}

Console.WriteLine();

// afficher le nombre d'elements dans le dico
Console.WriteLine($"Il y a actuellement {myDico.Count} pays dans la liste");

Console.WriteLine();

//parcourir les clé et valeurs
foreach (KeyValuePair<int, string> kvp in myDico)
{
    Console.WriteLine($"L'élément {kvp.Key} est {kvp.Value}");
}

Console.WriteLine();
// parcourir les valeurs
foreach (string pays in myDico.Values)
{
    Console.WriteLine(pays);
}

Console.WriteLine();

// parcourir les clés

foreach (int key in myDico.Keys)
{
    Console.WriteLine(key);
}