using ExercicesStructure;


//Ecrire une structure pour définir un point possédant deux entier X, Y
//et créer un tableau deux dimensions de 5 sur 5 de type « Point » (nullable)
//et remplir une des diagonales
//ensuite à l’aide de deux boucles afficher les valeurs dans la console comme suit :
// X: 1 - Y : 1 
//                  X: 2 - Y : 2 
//                                  X: 3 - Y : 3 




Point?[,] mesPoints = new Point?[5, 5];

//mesPoints[0, 0] = new Point(1, 1);
//mesPoints[1, 1] = new Point(2, 2);

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if(i == j)
        {
            mesPoints[i, j] = new Point(i + 1 , j + 1);
        }
    }
}


for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (mesPoints[i,j] != null)
        {
            Console.Write($" X : {mesPoints[i,j].Value.X} - Y : {mesPoints[i,j].Value.Y}");
        }
        else
        {
            Console.Write("               ");
        }
    }
    Console.WriteLine();
}