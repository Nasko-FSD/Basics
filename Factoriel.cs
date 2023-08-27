Console.Write("Enter the number for which you want caclulate the factoriel: ");
var n = int.Parse(Console.ReadLine());
var factoriel = 1;
do
{
    factoriel = factoriel * n;
    n--;
} while (n > 1);
Console.WriteLine(factoriel);