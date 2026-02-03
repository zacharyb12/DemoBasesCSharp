// Mini calculatrice

string num1String;
string op;
string num2String;

int num1Int;
int num2Int;
int result;


Console.WriteLine("Entrez une première valeur");
num1String = Console.ReadLine();
int.TryParse(num1String, out num1Int);

Console.WriteLine("Entrez un operateur : + - * /");
op = Console.ReadLine();

Console.WriteLine("Entrez une deuxième valeur");
num2String = Console.ReadLine();
int.TryParse(num2String, out num2Int);

switch (op)
{
    case "+":
        result = num1Int + num2Int;
        Console.WriteLine($"Le resultat de {num1Int} {op} {num2Int} = {result}");
        break;

    case "-":
        result = num1Int - num2Int;
        Console.WriteLine($"Le resultat de {num1Int} {op} {num2Int} = {result}");
        break;

    case "*":
        result = num1Int * num2Int;
        Console.WriteLine($"Le resultat de {num1Int} {op} {num2Int} = {result}");
        break;
    case "/":
        if (num2Int == 0)
        {
            Console.WriteLine("La division par zero est impossible");
        }
        else
        {
            result = num1Int / num2Int;
            Console.WriteLine($"Le resultat de {num1Int} {op} {num2Int} = {result}");
        }
        break;
    default:
        Console.WriteLine("Operateur invalide");
        break;
}
