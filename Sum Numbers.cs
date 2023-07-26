Console.Write("Enter how many numbers you'r gonna sum: ");
var n = int.Parse(Console.ReadLine());
Console.Write("Enter {0} numbers: ", n);
var sum = 0;
for (int i = 0; i < n; i++)
{
    Console.Write("num {0} = ", i);
    var num = int.Parse(Console.ReadLine());
    sum = sum + num;
}
Console.Write("The sum is: " + sum);