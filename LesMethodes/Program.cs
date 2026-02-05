
// Les methodes

// type de retour         : void ( vide )
// nom de la methode      : Test
// les paramètres         : ( int x )
// le corps de la methode : code à executer -> { code ici } 
void Test(int x)
{
    Console.WriteLine(x);
}

Test(5);
// ----------------------------------------------------

// Procedure : ne renvoie rien pas de return
void AffichageMenu()
{
    Console.WriteLine("Commander - 1");
    Console.WriteLine("Informations - 2");
    Console.WriteLine("Operateur - 3");
}


// Fonction :  renvoie une valeur : return ( quelque chose )
int Addition(int x , int y)
{
    return x + y;
}

// ---------------------------------------------------------

// appel d'une methode

// ici pas de valeur à récupérer 
AffichageMenu();

// ici retour d'une valeur ,à récupérer dans quelque chose
int resultat = Addition(5,6);

// Execution de la methode 
AffichageMenu();

// transmettre la reference ( l'adresse )
//AffichageMenu


// --------------------------------------------------------

// Return : Permet de mettre fin a l'execution en cours
void Operation(int x)
{
    if(x > 99)
    {
        // ici on stoppe l'execution
        return;
    }
    else
    {
        Console.WriteLine($" La valeur de x : {x}");
    }

}

// Return : renvoie la valeur du type correspondant

string ReturnString()
{
    return "un message";
}

int ReturnInt()
{
    return 1;
}

double ReturnDouble()
{
    return 2.0;
}

// ------------------------------------------

// Les paramètres
int Soustraction(int x , int y)
{
    int resultat = 0;
    if(x > y)
    {
        resultat = x - y;
    }
    else
    {
        resultat = y - x;
    }

    return resultat;
}

int result1 = Soustraction(6, 7);

int a = 5;
int b = 6;
int result2 = Soustraction(a, b);

// -----------------------------------------------
// Les paramètres facultatifs

string Presentation(string nom , string prenom , string pays = "Belgique")
{
    string message = $"Bonjour je me nomme {nom} - {prenom} je viens de {pays}";

    return message;
}

string presentation1 = Presentation("John","Doe","France");
string presentation2 = Presentation("John","Doe");

// -----------------------------------------------

// Les paramètres nommés

int Multiplication(int a , int b , int c)
{
    return a * b * c;
}

// ici l'ordre des paramètres change , ils seront donc nommés à l'appel
int resultMultiplication = Multiplication(c : 5 , b : 7 , a : 8);


// ------------------------------------------------------------

// in : precise qu'un paramètre est en lecture seule

void AfficheInfo(in int x)
{
    // impossible de modifier le paramètre x ( in : lecture seule)
    Console.WriteLine(x);
    int y = x;
}

// ------------------------------------------------------------

// params : permet de passer un nombre indefinis de paramètres du même type

double Moyenne(params int[] notes)
{
    double moyenne = 0;

    foreach (int note in notes)
    {
        moyenne += note;
    }

    moyenne = moyenne / notes.Length;

    return moyenne;
}

double moyenneEleves1 = Moyenne(5, 6, 9);
double moyenneEleves2 = Moyenne(15, 16, 19, 10, 15, 18);

// ------------------------------------------------------

// par défaut les paramètres sont une copie de la valeur 

// Pour utiliser la variable réel on utilisera la référence de cette variable

void Increment(ref int valeur)
{
    valeur++;
}

int c = 0;

Increment(ref c);

Console.WriteLine(c);// 1

// -------------------------------------------------------------

// Retour de fonction par references

string[] firstnames = new string[5];

int GetIndex(string nom , string[] tabNames)
{
    int index = -1;

    for (int i = 0; i < tabNames.Length ; i++)
    {
        if (tabNames[i] == nom)
        {
            index = i;
        }
    }
    return index;
}

ref string? GetRefByNom(string nom, ref string[] tabNames)
{
    for (int i = 0; i < tabNames.Length; i++)
    {
        if (tabNames[i] == nom)
        {
            return ref tabNames[i];
        }
    }
    throw new Exception("Valeur introuvable");
}

// ----------------------------------------------------------
// out : permet d'obliger l'initialisation d'une variable dans notre methode

void InitialisationValeur(out int variable , int valeur)
{
    variable = valeur;
}

int i;
InitialisationValeur(out i, 5);

Console.WriteLine(i); // 5

// ----------------------------------------------------

// prototype :
// le niveau d'accès
// le type de retour
// Le nom de la methode
// les paramètres

//public void NomMethode2(int a, int b)
//{

//}

// - - -

// signature :
// Le nom
// Les paramètres

//NomMethode2(int a, int b);

// -------------------------------------------------------------

// surcharge de methodes

// aller voir Class Calculatrice 