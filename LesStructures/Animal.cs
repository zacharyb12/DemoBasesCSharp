using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesStructures
{
    internal struct Animal
    {
        // les champs ne peuvent pas être initialisés 
        // sauf si ils sont déclaré const ou static
        public int Age;

        public string Nom;

        public string Couleur;

        public const bool EstSage = true;

        // les structures peuvent avoir un constructeur
        public Animal(int age , string nom , string couleur)
        {
            Age = age;
            Nom = nom;
            Couleur = couleur;
        }

        // les structures sont de type valeur
        // Les structures n'utilisent pas l'héritage
    }
}
