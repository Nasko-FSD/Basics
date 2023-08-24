Console.Write("Enter first number: ");
var a = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
var b = int.Parse(Console.ReadLine());
while (b != 0)
{
    var oldB = b;
    b = a % b;
    a = oldB;
}
Console.WriteLine("The GCD is: {0}", a);