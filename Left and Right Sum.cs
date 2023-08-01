Console.Write("Enter how many numbers you'r gonna enter: ");
var n = int.Parse(Console.ReadLine());
Console.WriteLine("Enter {0} numbers for left side: ", n);
var leftsum = 0;
var rightsum = 0;
for (int i = 1; i <= n; i++)
{
    Console.Write("num {0}=", i);
    var numsleftside = int.Parse(Console.ReadLine());
    leftsum = leftsum + numsleftside;
}
Console.WriteLine("Enter {0} numbers for rightside: ", n);
for (int i = 1; i <= n; i++)
{
    Console.Write("num {0}=", i);
    var numsrightside = int.Parse(Console.ReadLine());
    rightsum = rightsum + numsrightside;
}
if (leftsum == rightsum)
{
    Console.WriteLine("Yes, sum = " + leftsum);
}
else
    Console.WriteLine("No, diff = " + Math.Abs(rightsum - leftsum));