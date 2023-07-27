Console.Write("Enter how many numbers you'r gonna enter: ");
var n = int.Parse(Console.ReadLine());
Console.Write("Enter {0} numbers: ", n);
var min = int.MaxValue;
for (int i = 1; i <= n; i++)
{
    Console.Write("num {0}= ", i);
    var num = int.Parse(Console.ReadLine());
    if (num < min)
    {
        min = num;
    }
}
Console.WriteLine("The Smallest number is: " + min);