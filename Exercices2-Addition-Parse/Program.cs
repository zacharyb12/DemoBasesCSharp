int nb1;
int nb2;
int resultat;

Console.WriteLine("Entrez une première valeur");
nb1 = int.Parse(Console.ReadLine());

Console.WriteLine("Entrez une deuxième valeur");
nb2 = int.Parse(Console.ReadLine());

resultat = nb1 + nb2;

Console.WriteLine($"Le resultat de {nb1} + {nb2} = {resultat}");