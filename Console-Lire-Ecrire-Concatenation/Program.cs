

// ecrire

// permet d'écrire du texte avec un retour à la ligne 
Console.WriteLine("hello world Writeline!");


// permet d'écrire du texte sans retour à la ligne 
Console.Write("hello world Write !");

Console.WriteLine();


// Concatenation

Console.WriteLine("voici un texte" + 14);


Console.WriteLine("voici un texte {0} , {1}", 14, 56);

Console.WriteLine($" voici un texte {15} et une autre valeur {56}");


// lire (toujours en chaine de caractère)

string reponse = Console.ReadLine();

Console.WriteLine(reponse);

// permet de bloquer le programme jusqu'a ce que l'utilisateur appuie sur enter
Console.ReadLine();

// Nettoyer la console
Console.Clear();