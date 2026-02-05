

//Ecrire une structure pour définir un point possédant deux entier X, Y et créer un tableau
//deux dimensions de 5 sur 5 de type « Point » (nullable) et remplir une des diagonales,
//ensuite à l’aide de deux boucles afficher les valeurs dans la console comme suit :
// X: 1 - Y : 1 
//                  X: 2 - Y : 2 
//                                  X: 3 - Y : 3 


int[,] ints = new int[3,3];
//[0.0 , 0.1 , 0.2]
//[1.0 , 1.1 , 1.2]
//[2.0 , 2.1 , 2.2]

ints[0, 0] = 1;
ints[1, 1] = 1;
ints[2, 2] = 1;

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(ints[i,j]);
    }
    Console.WriteLine();
}

