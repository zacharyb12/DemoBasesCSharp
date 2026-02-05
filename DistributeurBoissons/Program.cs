

// implementer le distributeur de boissons
// Il faut gérer le stock de boissons minimun 4 boissons
// 1. afficher le menu
// 2. demander a l'utilisateur son choix
// ( verifier si le choix est correct sinon l'utilisateur doit redonner son choix)
// 3.traiter le choix de l'utilisateur ( et adapter le stock )
// 4. l'utilisateur peut quitter depuis le menu


int coca = 5;
int fanta = 5;
int cafe = 5;
int eau = 5;

bool again = true;

int choix = -1;

while (again)
{
    if(coca > 0)
    {
        Console.WriteLine("Coca - 1");
    }
    
    if (fanta > 0)
    {
        Console.WriteLine("Fanta - 2");
    }
    
    if (cafe > 0)
    {
        Console.WriteLine("Café - 3");
    }

    if (eau > 0)
    {
        Console.WriteLine("Eau - 4");
    }

    Console.WriteLine("Quitter - 0");

    choix = -1;
    while (choix <  0 || choix > 4)
    {
        Console.WriteLine("Entrez votre choix");
        int.TryParse(Console.ReadLine(), out choix);
    }

    switch (choix)
    {
        case 0:
                again = false;
            break;

        case 1:
                if(coca > 0)
                {
                    Console.WriteLine("Voici un coca !");
                    coca--;
                }
            break;

        case 2:
            if (fanta > 0)
            {
                Console.WriteLine("Voici un fanta !");
                fanta--;
            }
            break;

        case 3:
            if (cafe > 0)
            {
                Console.WriteLine("Voici un café !");
                cafe--;
            }
            break;

        case 4:
            if (eau > 0)
            {
                Console.WriteLine("Voici une eau !");
                eau--;
            }
            break;

        default:
            Console.WriteLine("Choix invalide");
            break;
    }
    Console.ReadLine();
    Console.Clear();
}

