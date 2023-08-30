Console.Write("Enter a number to check Fibonacci's sequence: ");
var n = int.Parse(Console.ReadLine());
var fibonacci0 = 1;
var fibonacci1 = 1;
for ( int i = 1; i <= n - 1; i++)
{
    var FibonacciNext = fibonacci0 + fibonacci1;
    fibonacci0 = fibonacci1;
    fibonacci1 = FibonacciNext;
}
Console.WriteLine("Fibonacci's sequence: {0}" , fibonacci1);