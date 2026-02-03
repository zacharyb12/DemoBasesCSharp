// Les operateurs 

// Incrementation

int x = 0;

// Lecture de la valeur puis incrementation
// post-incrementation
x++;

// incrementation puis lecture de la valeur
// pré-incrementation
++x;

// ---------

// Decrementation

// Lecture de la valeur puis décrementation
// post-décrementation
x--;

// décrementation puis lecture de la valeur
// pré-décrementation
--x;

// ---------

//Autres symboles

// addition d'une valeur à x
x += 5;

// soustraction d'une valeur à x
x -= 5;

// multiplication de x
x *= 5;

// division
x /= 5;

// modulo
x %= 5;

// -----------------------------------------

// Ternaire
string result = "";

// sans Ternaire
if(x == 0)
{
    result = "x est à 0";
}
else
{
    result = "x n'est pas à 0";
}

//       condition     si Vrai         si Faux
result = (x == 0)  ? "x est à 0" : "x n'est pas à 0";


result = (x == 0) ? "valeur" : 
         (x == 5) ? " " : 
         (x == 10) ? " " : "";


// -----------------------------------------
// Coalesce
// permet de verifier la nullité d'une variable
// cherche la première valeur non-null

string message = null;
string message1 = null;
string message2 = null;

string valeur = message ?? message1 ?? message2 ?? "La variable est null";


// -----------------------------------------

// Recuperation du type 
// typeof(Type) : permet de cibler un type
// GetType() : permet de recuperer le type d'une variable

object valueObject = "voici du texte";

int variableInt = 0;
string variableString = "";


if (valueObject.GetType() == typeof(int))
{
    variableInt = (int)valueObject;

}
else if (valueObject.GetType() == typeof(string))
{
    variableString = (string)valueObject;
}

Console.WriteLine(variableInt);
Console.WriteLine(variableString);


// -----------------------------------------

// Le is effectue une comparaison

int maValue = 5;

// le comportement du == peut être modifié
if (maValue == 10 && maValue == 100)
{

}

// le comportement du is ne peut pas être modifié
if (maValue is > 10 && maValue is < 100)
{
    
}


// -----------------------------------------

// as type : convertir dans le type ou renvoie null
// permet de faire une conversion

// ici type non nullable je doit le rendre nullable
object myObj = 5;

int? myInt = myObj as int?;

// ici type nullable
object myObj2 = "texte";

string myString = myObj2 as string;


// -----------------------------------------

// checked & unchecked

// checked : permet de déclencher une erreur en cas de dépassement de limite

int a = int.MaxValue; // 2147483647


checked // le checked va déclencher une erreur 
{
    a += 1; // ici dépassement 

    Console.WriteLine(a);
}

// unchecked : permet de ne pas déclencher d'erreur en cas de dépassement de limite

unchecked // ne va pas déclencher d'erreur
{
    a += 1; // ici dépassement 

    Console.WriteLine(a); // -2147483648
}