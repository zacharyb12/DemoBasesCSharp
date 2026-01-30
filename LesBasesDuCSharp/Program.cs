
// un commentaire sur une seule ligne

/*
    un commentaire
    sur plusieurs lignes
 */

// raccourci pour commenter : ctrl + k + c | ctrl + e + c

// raccourci pour decommenter : ctrl + k + u | ctrl + e + u

// deplacer une ligne : alt + flèche haut/bas

// selection de plusieurs lignes : ctrl + alt

// copier une ligne : ctrl + c

// coller une ligne : ctrl + v

// -----------------------------------------------

// ecrire

// permet d'écrire du texte avec un retour à la ligne 
Console.WriteLine("hello world Writeline!");


// permet d'écrire du texte sans retour à la ligne 
Console.Write("hello world Write !");

Console.WriteLine();


// Concatenation

Console.WriteLine("voici un texte" + 14);


Console.WriteLine("voici un texte {0} , {1}" , 14,56);

Console.WriteLine($" voici un texte {15} et une autre valeur {56}");


// lire (toujours en chaine de caractère)

string reponse = Console.ReadLine();

Console.WriteLine(reponse);

// permet de bloquer le programme jusqu'a ce que l'utilisateur appuie sur enter
Console.ReadLine();

// Nettoyer la console
Console.Clear();

// -----------------------------------------------------------

// Les variables

// variable nom : Type

// declaration 
int monEntier;

// affectation
monEntier = 15;

// declaration et affectation 

int monAutreEntier = 42;


// declaration de plusieurs variables
// variable globale
int a, b, c;

a = 43;
b = 44;
c = 45;


void test()
{
    // variable locale
    int z = 5;
}


// Constantes

const Double PI = 3.14;


// Les types nullable

// Certains types sont nullables sinon il faut le preciser avec le " ? "

// ici on le precise
int? maValeur = null;

maValeur = 5;

// ici le type est déja nullable
string maValeurString = null;


// ------------------------------------------------------

// Valeur : on utilise la valeur de quelque chose 
int entierValeur = 5;

int entierValeurCopie = entierValeur;



// référence : on utilise la référence de quelque chose 
// adresse memoire qui est utilisé par autre chose 

Object o1 = new(); // 10CHQFDS09F

Object o2 = o1;   // 10CHQFDS09F


// -----------------------------------------------------------

//Les types de bases 

// Les entier : int
int valeurEntier = 5;

// uint : entier non-signé
uint valeurUint = 5;


// les valeur décimales 

// max : 2.147.483.648 
float valeurFloat = 5.14F;

// jusqu'à 17 chiffres
double valeurDouble = 1.54;

// jusqu'a 29 chiffres
decimal valeurDecimal = 1.54m;


// short : entier signé 
short valeurShort = -1;

// short non signé
ushort valeurUShort = 2;

// chaine de caractère
string valeurString = "ma valeur texte";

// caractère
char valeurChar = 'A';



// Les plus utilisés

// entier
int valeurA = 5;

int valeurB = 4;

int valeurC = valeurA + valeurB;

Console.WriteLine(valeurC);

// string 
string monMessage = Console.ReadLine();

Console.WriteLine(monMessage);


// Conversion de types 

//Pour convertir dans un type utilisation de la methode Parse : type.Parse()

// texte -> valeur numerique
double.Parse("5.14");

float.Parse("5.14");

int.Parse("5");


// Numerique -> texte
int valeurNum = 54;

string valeurNumString = valeurNum.ToString();




