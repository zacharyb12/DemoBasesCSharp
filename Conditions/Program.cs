
// Le IF ... ELSE

// SI ( condition )
bool isTrue = true;

if (isTrue) // obligation de renvoyer un booléen
{
    Console.WriteLine("La valeur est vraie");
}

// SI ( condition) Sinon 

if (isTrue)
{
    Console.WriteLine("La valeur est vraie");
}
else
{
    Console.WriteLine("La valeur est fausse");
}


// Si ( condition ) SinonSi (condition) Sinon

int valueA = 5;
int valueB = 6;
if (isTrue)
{
    Console.WriteLine("Si la première condition est vrai ");
}
else if (valueA < valueB)
{
    Console.WriteLine("Si la première condition est fausse ");
    Console.WriteLine(" Et Si la deuxième condition est vraie ");

}
else
{
    Console.WriteLine("Si toutes les conditions sont fausses");
}

// Plusieurs conditions

Console.WriteLine("Entrez votre age");
string ageString = Console.ReadLine();

Console.WriteLine("Entrez votre role");
string role = Console.ReadLine();

int.TryParse(ageString, out int ageInt);

if (ageInt > 18 && role == "admin")
{
    Console.WriteLine($"L'utilisateur avec le role {role} est agé de {ageInt}");
}

// ------------------------------------------------

// Les opérateurs

int x = 5;
int y = 5;

// égalité
if (x == y)
{

}

//différence
if (x != y)
{

}

// Plus petit | plus petit ou égale

if (x < y)
{

}

if (x <= y)
{

}

// Plus grand | plus grand ou égale

if (x > y)
{

}

if (x >= y)
{

}

// negation

bool isCorrect = false;
if (!isCorrect) // isCorrect == false
{

}

if (isCorrect) // isCorrect == true
{

}

// ET : toutes les conditions doivent renvoyer vraies
if (x == 5 && y == 5)
{

}

// OU : au moins une des conditions doit renvoyer vrai
if (x == 5 || y == 5)
{

}

// Ou Exclusif : uniquement une seule des conditions peut renvoyer vrai
if (x == 5 ^ y == 5)
{

}

// ----------------------------------
// switch

string jourSemaine = "Lundi";

switch (jourSemaine)
{
    case "Lundi":
        Console.WriteLine("Premier jour de la semaine");
        break;
    case "Mardi":
        Console.WriteLine("Premier jour de la semaine");
        break;

    default:
        Console.WriteLine("Un autre jour de la semaine");
        break;
}