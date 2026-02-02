using System.Text;

Console.OutputEncoding = Encoding.UTF8;

string hobby;
string vehicule;
string destination;
int salaire;

Console.WriteLine("Entrez votre hobby :");
hobby = Console.ReadLine();

Console.WriteLine("Entrez votre vehicule favoris :");
vehicule = Console.ReadLine();

Console.WriteLine("Entrez votre destination de voyage favorites :");
destination = Console.ReadLine();


Console.WriteLine("Entrez votre salaire de rêve :");
string response = Console.ReadLine();
salaire = int.Parse(response);


Console.WriteLine($" Votre hobby est {hobby}");
Console.WriteLine($" Votre voiture favorites est {vehicule}");
Console.WriteLine($" votre destination de vacances est {destination}");
Console.WriteLine($" Votre salaire de rêve est de {salaire}€");

// --------------------------------------------------------------------


int nb1;
int nb2;
int resultat;

Console.WriteLine("Entrez une première valeur");
nb1 = int.Parse(Console.ReadLine());

Console.WriteLine("Entrez une deuxième valeur");
nb2 = int.Parse(Console.ReadLine());

resultat = nb1 + nb2;

Console.WriteLine($"Le resultat de {nb1} + {nb2} = {resultat}");