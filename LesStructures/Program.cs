

// references = l'adresse de l'objet est copié
using LesStructures;

Object o = new Object();

Object o2 = o;

// valeur = la valeur est copié dans b
int a  = 1;

int b = a;

// ---------------------------------------

Animal monAnimal = new Animal();

Animal monAnimal2 = new();

monAnimal.Age = 12;
monAnimal.Nom = "Rex";
monAnimal.Couleur = "Noir";

Animal monAnimal3 = new(11 , "le Chien" , "blanc");

Console.WriteLine(monAnimal3.Age);
Console.WriteLine(monAnimal3.Nom);
Console.WriteLine(monAnimal3.Couleur);

Console.WriteLine($"L'animal {monAnimal3.Nom} à {monAnimal3.Age} ans et est de couleur {monAnimal3.Couleur}");
