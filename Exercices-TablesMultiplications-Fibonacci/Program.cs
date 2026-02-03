// 1:  Afficher les tables de multiplications de 1 à 10;

// 1 * 1 = 1
// 2 * 1 = 2

// 1 * 2 = 1
// 2 * 2 = 2

for (int i = 1; i < 11; i++)
{
    Console.WriteLine($"La table de {i}");

    for (int j = 1; j < 11; j++)
    {
        Console.WriteLine($" {j} * {i} = {j * i}");
    }

    Console.WriteLine();
}


// ---------------------------------------------------------

// demander a l'utilisateur quel table de multiplication afficher;

// demander a l'utilisateur quel table de multiplication afficher;

string reponse;
int choiceUser = 0;
bool isCorrect = false;

while (!isCorrect)
{
    Console.WriteLine("Quel table voulez-vous afficher?");
    reponse = Console.ReadLine();

    isCorrect = int.TryParse(reponse, out choiceUser);
}

Console.WriteLine($"La table de {choiceUser}");

for (int i = 1; i < 11; i++)
{
    Console.WriteLine($"{i} * {choiceUser} = {i * choiceUser}");
}



// ---------------------------------------------------------

// avec une boucle Pour afficher les 25 premier nombre de fibbonnacci
// 1 , 2 ,  3 , 5 , 8


int n = 26;
int a = 0;
int b = 1;

for (int i = 0; i < n; i++)
{
    Console.WriteLine($" valeur {i + 1} : {a}");
    int temp = a;
    a = b;
    b = temp + b;
}



