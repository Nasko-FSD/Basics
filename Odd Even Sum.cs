Console.Write("Enter how many numbers you'r gonna enter: ");
var n = int.Parse(Console.ReadLine());
Console.WriteLine("Enter {0} numbers: ", n);
var oddsum = 0;
var evensum = 0;
for (int i = 1; i <= n; i++)
{
    Console.Write("num {0}= ", i);
    var num = int.Parse(Console.ReadLine());
    if (i % 2 == 0)
    {
    evensum = evensum + num;
    }
    else 
    {
    oddsum = oddsum + num;
    }
}
if (oddsum == evensum)
{
    Console.WriteLine("Yes, sum = " + oddsum);
}
else 
{
    int diff = Math.Abs(evensum - oddsum);
    Console.WriteLine("No, diff = " + diff);
}