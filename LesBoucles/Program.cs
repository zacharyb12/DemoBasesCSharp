
// Les boucles

// While( conditions )
// {
// }

bool Loop = true;

while (Loop)
{
    Console.WriteLine("La boucle tourne");
    Loop = false;
}
// ----

bool again = false;
int value = 0;
// verification de la recuparation de la valeur
while (!again)
{
    Console.WriteLine("Entrez un nombre");
    again = int.TryParse(Console.ReadLine(), out value);
}

// verification de la recuparation de la valeur
again = false;
string op = "";
while (!again)
{
    Console.WriteLine("Entrez un operateur : + - * / ");
    op = Console.ReadLine();

    if (op == "+" || op == "-" || op == "*" || op == "/")
    {
        again = true;
    }
}

// verification de la recuparation de la valeur
again = false;
int value2 = 0;
while (!again)
{
    Console.WriteLine("Entrez un nombre");
    again = int.TryParse(Console.ReadLine(), out value2);

}


switch (op)
{
    case "+":
        Console.WriteLine($"Le resultat de {value} {op} {value2} = {value + value2}");
        break;
    case "-":
        Console.WriteLine($"Le resultat de {value} {op} {value2} = {value + value2}");
        break;
}


// ---------------

// do While() : identique à la While
// La condition est vérifié apres une première itération
do
{

}
while (true);

// ----------------------------------------------------

// Pour / For
for (int i = 0; i < 10; i++)
{

}

// en incrementant
for (int i = 0; i < 10; i++)
{

}

// en decrementant
for (int i = 10; i > 0; i--)
{

}

// demo avec tableau
int[] ints = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Entrez une valeur pour l'emplacement {i + 1}");
    ints[i] = int.Parse(Console.ReadLine());
}

// ------------------------------------
// Permet de percourir quelque chose jusqu'a la fin 
// sans devoir preciser la taille
int[] ints1 = new int[5];

ints = [1, 2, 3, 4, 5];

foreach (int item in ints1)
{
    Console.WriteLine(item);
}
