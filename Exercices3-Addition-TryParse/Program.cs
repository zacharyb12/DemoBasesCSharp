// declarations des variables

string nb1String = "";
string nb2String = "";

bool isCorrect = false;

int nb1Int;
int nb2Int;
int resultat2;

// recuperation des valeurs en string
Console.WriteLine("Entrez une première valeur");
nb1String = Console.ReadLine();

Console.WriteLine("Entrez une deuxième valeur");
nb2String = Console.ReadLine();

// conversion en int
isCorrect = int.TryParse(nb1String, out nb1Int);
isCorrect = int.TryParse(nb2String, out nb2Int);

// addition des valeurs
resultat2 = nb1Int + nb2Int;

// affichage du message et du resultat
Console.WriteLine($"Le resultat de {nb1Int} + {nb2Int} = {resultat2}");