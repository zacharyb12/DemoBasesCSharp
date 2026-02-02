
string valeurToConvert = Console.ReadLine();

bool isConverted = false;


int valeurConverted;

isConverted = int.TryParse(valeurToConvert , out valeurConverted);

Console.WriteLine(valeurConverted);

