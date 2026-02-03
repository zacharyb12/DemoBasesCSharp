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





// ---------------------------------------------------------

// avec une boucle Pour afficher les 25 premier nombre de fibbonnacci
// 1 , 2 ,  3 , 5 , 8