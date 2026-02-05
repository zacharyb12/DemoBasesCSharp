using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesMethodes
{
    internal class Calculatrice
    {
        // surcharge de methode 
        // du moment que la signature est différente
        // on peut utiliser plusieurs fois le même nom pour des methodes
        public void Addition(int a , int b)
        {
            Console.WriteLine(a+b);
        }

        public void Addition(int a, int b , int c)
        {
            Console.WriteLine(a + b);
        }

        public void Addition(double a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Addition(double a, double b)
        {
            Console.WriteLine(a + b);
        }
    }
}
