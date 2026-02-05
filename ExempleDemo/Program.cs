

void GetRandom()
{
    Random random = new Random();

    int chanceux = random.Next(12);

    Console.WriteLine(chanceux);
}

int GetNumber()
{
    bool isCorrect = false;
    int valeur = -1;

    while (!isCorrect)
    {
        Console.WriteLine("Entrez une valeur");
        string reponse = Console.ReadLine();

        isCorrect = int.TryParse(reponse, out valeur);
    }

    return valeur;
}

void JeuDuNombre()
{
    Random rnd = new Random();
    int valeur = rnd.Next(101);
    bool win = false;
    int nbVie = 1;
    int choix = 0;

        Console.WriteLine("Entrez un nombre de vie");
        nbVie = int.Parse(Console.ReadLine());

    while (!win) 
    {
        Console.WriteLine("Entrez un nombre entre 1 et 100");
        choix = int.Parse(Console.ReadLine());

        if (choix > valeur)
        {
            Console.WriteLine("La valeur est plus petite");
            nbVie--;
        }
        else if (choix < valeur) 
        {
            Console.WriteLine("La valeur est plus grande");
            nbVie--;
        }else
        {
            Console.WriteLine($"Bravo vous avez trouvé le nombre : {valeur}");
            win = true;
        }

        if(nbVie == 0)
        {
            win = true;
            Console.WriteLine("Vous avez perdu !");
        }

    }
}


//GetRandom();

//int number = GetNumber();

//Console.WriteLine(number);

void Game()
{
    bool quit = false;
    int choix = -1;

    while (!quit)
    {
        Console.WriteLine("Faites votre choix");
        Console.WriteLine("Quitter - 0");
        Console.WriteLine("Jeu du nombre - 1");

        choix = GetNumber();

        switch (choix)
        {
            case 0:
                quit = true;
                break;

            case 1:
                JeuDuNombre();
                break;

            default:
                Console.WriteLine("Le choix est incorrect");
                break;
        }
    }
}



Game();