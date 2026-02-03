// Les tableaux

// Tableau a une dimension

// le tableau demarre à 0 jusqu'a taille - 1

// déclaration du tableau
using System.Collections;

int[] monTableau = new int[3];
// [ 0 , 1 , 2 ]

// on accède au emplacements du tableau grace à l'index : [ ]
monTableau[0] = 1;
monTableau[1] = 2;
monTableau[2] = 3;

for (int i = 0; i < 3; i++)
{
    // affecter une valeur à un emplacement du tableau
    monTableau[i] = i;

    // lire une valeur dans le tableau
    Console.WriteLine(monTableau[i]);
}

// Declaration et affectation de valeurs au tableau

string[] myStringTab = ["premier", "deuxième", "troisième", "quatrième"];

// ----------------------------------------

int[ , ] myTabTwoDimension = new int[3,3];

// [0,0 | 0,1 | 0,2]
// [1,0 | 1,1 | 1,2]
// [2,0 | 2,1 | 2,2]

// affectation de valeur dans le tableau a deux dimensions
myTabTwoDimension[1,1] = 1;

// Parcourir un tableau a plusieurs dimension
for (int i = 0; i < 3; i++) // 0
{
    for (int j = 0; j < 3; j++) // 0
    {
        myTabTwoDimension[i, j] = int.Parse(Console.ReadLine());
      //myTabTwoDimension[1, 0] = 16
    }
}

string[,] myStringTab2 = { { "un", "deux", "trois" }, { "quatre", "cinq", "six" } };

// -----------------------------------------------------------------

// tableaux ortogonaux
// chaque dimensions à une taille variable

int[][] myInts = new int[3][];

int[][] myInts2 = { new int[] { 1, 2, 3 }, new int[] { 5, 6, 7 } };

// accéder au tableau

Console.WriteLine( myInts2[1][0] );

// ---------------------------------------------------

//Les collections


// ArrayList

ArrayList arrayList = new ArrayList();

//ajout dans l'ArrayList
arrayList.Add(10);
arrayList.Add("hello");
arrayList.Add(new object());

// vider l' ArrayList
arrayList.Clear();

// verifier si quelque chose est dans notre ArrayList
bool isInside = arrayList.Contains(10);

// Récuperation de l'index de quelque chose
int position = arrayList.IndexOf(10);

// Retirer quelque chose dans l'ArrayList
arrayList.Remove(10);

// ToArray : transforme en taableau
object[] tabObject = arrayList.ToArray();


// -------------------------------------------------
// Hashtable : Clé - valeur
Hashtable hashtable = new Hashtable();

// ajout de clé et de valeur
hashtable.Add(1,"valeur");

// recuperation d'un élément de ma hashTable
string result = (string)hashtable[0];

// -------------------------------------------------
// Queue : FIFO : First in First out

Queue queue = new Queue();

// ajout a la Queue
queue.Enqueue(result);

// retire le dernier element de la Queue
queue.Dequeue();

// -------------------------------------------------
// Stack : LIFO : Last in First Out

Stack stack = new Stack();

// ajout a la Stack
stack.Push(queue);

// retrait de la stack
stack.Pop();
// -------------------------------------------------


// Les collections génériques

// List

List<string> maList = new List<string>();

// -------------------------------------------------

// Dictionnaire

Dictionary<int,string> myDico = new Dictionary<int, string>();

// -------------------------------------------------
// Queue Générique

Queue<string > queue = new Queue<string>();

// -------------------------------------------------
// Stack Générique

Stack<string> stack = new Stack<string>();

// -------------------------------------------------


