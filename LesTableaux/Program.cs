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

// ==================================================================

// ---------------------------------------------------

//Les collections

// ---------------------------------------------------

// ArrayList
// necessite d'utiliser le unboxing

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

// necessite d'utiliser le unboxing
string element = (string)arrayList[0];


// -------------------------------------------------
// Hashtable : Clé - valeur
Hashtable hashtable = new Hashtable();

// ajout de clé et de valeur
hashtable.Add(1,"valeur1");
hashtable.Add(2,"valeur2");

// supprimer un element
hashtable.Remove(1);

// vider la hashtable
hashtable.Clear();

// verifier si la hashtable contient une clé
bool hasKey = hashtable.ContainsKey(1);

// verifier si la hashtable contient une valeur
bool hasValue = hashtable.ContainsValue("valeur1");

// récuperation d'une valeur
string value = (string)hashtable[1];

// recuperation d'un élément de ma hashTable
string result = (string)hashtable[0];

// -------------------------------------------------
// Queue : FIFO : First in First out

Queue queue = new Queue();

// ajout a la Queue
queue.Enqueue("valeur1");

// retire le dernier element de la Queue
queue.Dequeue();

// Retourne le premier élément dans l'ordre sans le retirer de la file
string elementDeLaQueue = (string)queue.Peek();

// -------------------------------------------------
// Stack : LIFO : Last in First Out

Stack stack = new Stack();

// ajout a la Stack
stack.Push("valeur1");

// retrait de la stack
stack.Pop();

//// Retourne le premier élément dans l'ordre sans le retirer de la file
string elementDeLaStack = (string)queue.Peek();


// ========================================================================
// -------------------------------------------------
// Les collections génériques
// -------------------------------------------------

// List

List<string> maList = new List<string>();

// ajout 
maList.Add("element 1");

// retrait de la liste
maList.Remove("element 1");

// recuperation de la taille
int taille = maList.Count;

// verifie la présence d'un element dans la liste
maList.Contains("element 1");

// permet de vider la liste
maList.Clear();


// -------------------------------------------------

// Dictionnaire

Dictionary<int,string> myDico = new Dictionary<int, string>();

// ajout d'un élément dans le dictionnaire ( clé et valeur )
myDico.Add(1,"element 1");

// retirer un element de la liste avec la clé
myDico.Remove(2);

// vider le dictionnaire
myDico.Clear();

// verifier si le dictionnaire contient une clé
bool containKey = myDico.ContainsKey(1);

// verifier si le dictionnaire contient une valeur
bool containValue = myDico.ContainsValue("element 1");


// accéder a un element par l'index ( sans unboxing )
string elementDico = myDico[1];

// parcourir les clés et valeurs
foreach (KeyValuePair<int,string> kvp in myDico)
{
    Console.WriteLine(kvp.Value);
    Console.WriteLine(kvp.Key);
}

// parcourir les clés
foreach (int key in myDico.Keys)
{
    Console.WriteLine(key);
}

// parcourir les valeurs
foreach (string valeur  in myDico.Values)
{
    Console.WriteLine(valeur);
}


// -------------------------------------------------
// Queue Générique : FiFo ( First in First out )

Queue<string > queueGenerique = new Queue<string>();

// ajout d'un element
queueGenerique.Enqueue("element 1");

// retrait d'un element
queueGenerique.Dequeue();

// recuperer un element sans le retirer de la file
queueGenerique.Peek();

// vider la file
queueGenerique.Clear();

// -------------------------------------------------
// Stack Générique : LiFo ( Last in First out )

Stack<string> stackGenerique = new Stack<string>();

// ajout d'un element
stackGenerique.Push("element 1");

// retrait d'un element
stackGenerique.Pop();

// recuperer un element sans le retirer de la file
stackGenerique.Peek();

// vider la file
stackGenerique.Clear();


// -------------------------------------------------


