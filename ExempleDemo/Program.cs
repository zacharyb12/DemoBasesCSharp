


int a = int.MaxValue;

Console.WriteLine(a);


unchecked
{
    a += 1;

    Console.WriteLine(a);
}