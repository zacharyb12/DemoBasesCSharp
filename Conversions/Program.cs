
// Conversion de types 

//Pour convertir dans un type utilisation de la methode Parse : type.Parse()

// texte -> valeur numerique
double.Parse("5.14");

float.Parse("5.14");

int.Parse("5");


// Numerique -> texte
int valeurNum = 54;

string valeurNumString = valeurNum.ToString();

//-----------------------------------------------------------------


// Conversions

// Vers String

int valeurInt = 10;
float valeurFloat2 = 3.14F;

string valeurString2 = valeurInt.ToString();
string valeurString3 = valeurFloat2.ToString();

// -------

// Vers type numerique

// Parse : Type.Parse( paramètre à convertir );

string valeurToConvert = "15";
int valeurConverted = int.Parse(valeurToConvert);

// -------

// Try.Parse : renvoie un booléen , prend deux paramètres 
// le premier la valeur à convertir
// le deuxième dans quoi envoyer la valeur qui à été convertie ( out )


string valeurToConvertTryParse = Console.ReadLine();

bool isConverted = false;


int valeurConvertedTryParse;

isConverted = int.TryParse(valeurToConvertTryParse, out valeurConvertedTryParse);

Console.WriteLine(valeurConverted);

// -------

// Convert

string valeurToConvert2 = Console.ReadLine();

int valueConverted = Convert.ToInt32(valeurToConvert2);

// -------

// Conversion implicite et explicite

// implicite n'implique aucune perte de valeur
int valeurIntImpl = 15;

float valeurFloatImpl = valeurIntImpl;

// explicite
float valeurFloatToInt = 3.14F;

int valeurIntFromFloat = (int)valeurFloatToInt;

// ----------------------------------------------
// boxing et unboxing

int maValueInt = 10;

// boxing

Object o = maValueInt;

// unboxing
maValueInt = (int)o;