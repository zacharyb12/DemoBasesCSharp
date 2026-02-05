
using LesEnums;

// recuperation d'une des valeurs de notre enum
Pays pays = Pays.Belgique;

int cle = (int)pays;
Pays pays1 = (Pays)cle;

Console.WriteLine($"clé : {cle}");
Console.WriteLine($"pays : {pays}");
Console.WriteLine($"paysFromClé : {pays1}");

Console.WriteLine();

// Parcourir une enum
foreach (Pays p in Enum.GetValues(typeof(Pays)))
{
    Console.WriteLine(p);
}

Console.WriteLine();
// -------------------------------------------------

Permissions permissionsUser1 = Permissions.Ecriture | Permissions.Lecture;

// verifier une permission : HasFlag()
Console.WriteLine($"Possède Lecture ? {permissionsUser1.HasFlag(Permissions.Lecture)}");
Console.WriteLine($"Possède Ecriture ? {permissionsUser1.HasFlag(Permissions.Ecriture)}");

Console.WriteLine();
// Ajout d'une permission
permissionsUser1 |= Permissions.Execution;
permissionsUser1 |= Permissions.Suppression;

Console.WriteLine();
// Verification de Tout
Console.WriteLine($"Possède toute les permissions ? {permissionsUser1.HasFlag(Permissions.Tout)}");


Console.WriteLine();
// Suppression d'une permission
permissionsUser1 &= Permissions.Suppression;


Console.WriteLine();
// Verification de Tout
Console.WriteLine($"Possède toute les permissions ? {permissionsUser1.HasFlag(Permissions.Tout)}");