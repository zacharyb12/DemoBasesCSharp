
// 1.
//Calcule de la division entière, du modulo et de la division de deux entiers.
//Résultat attendu pour 5 et 2 🡪
//Division entière : 2,
//Modulo: 1,
//Division: 2,5.

int a = 5;
int b = 2;

int resultat;

//Division entière : 2,
resultat = a / b;
Console.WriteLine($"Le resultat de {a} / {b} = {resultat}");

//Modulo: 1,
resultat = a % b;
Console.WriteLine($"Le resultat de {a} % {b} = {resultat}");


double c = 5.0;
double d = 2.0;
double resultatDouble;

//Division: 2,5
resultatDouble = c / d;
Console.WriteLine($"Le resultat de {c} / {d} = {resultatDouble}");

// ----------------------------------------------------------------------

// Verification Numero Compte


// Vérification d’un compte bancaire BBAN,
//si le compte est bon affichez OK sur la console sinon KO.

//Le modulo des 10 premiers chiffres par 97 donne les 2 derniers.
//Sauf si le modulo = 0 dans ce cas les 2 derniers chiffres sont 97.
//(utilisez la méthode « Substring » de la classe « string »).

// recuperation du numero compte
bool isCorrect = false;
string numeroCompteString = "";

while(!isCorrect)
{
    Console.WriteLine("Entrez un numero de compte de 12 chiffres : 1234 5678 9432");
    numeroCompteString = Console.ReadLine();

    if(numeroCompteString.Length == 12)
    {
        isCorrect = true;
    }
}


// extraction des 10 premiers et des 2 derniers
string tenFirstString = numeroCompteString.Substring(0, 10);
string twoLastString = numeroCompteString.Substring(10, 2);


// conversion des 10 premiers et des 2 derniers
long tenFirstLong = long.Parse(tenFirstString);
int twoLastInt = int.Parse(twoLastString);

// affichage si le compte est correct ou pas

if (tenFirstLong % 97 == twoLastInt || tenFirstLong % 97 == 0 && twoLastInt == 97)
{
    Console.WriteLine("Ok");
}
else
{
    Console.WriteLine("Ko");
}




