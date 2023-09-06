Console.Write("Enter 3 numbers: ");
var num1 = int.Parse(Console.ReadLine());
var num2 = int.Parse(Console.ReadLine());
var num3 = int.Parse(Console.ReadLine());
if (num1 + num2 == num3)
{
    if(num1 < num2)
    {
        Console.WriteLine("{0} + {1} = {2}", num1, num2, num3);
    }
    else
    {
        Console.WriteLine("{0} + {1} = {2}", num2, num1, num3);
    }
}
else if (num1 + num3 == num2)
{
    if (num1 < num3)
    {
        Console.WriteLine("{0} + {1} = {2}", num1, num3, num2);
    }
    else
    {
        Console.WriteLine("{0} + {1} = {2}", num3, num1, num2);
    }
}
else if (num2 + num3 == num1)
{
    if (num2 < num3)
    {
        Console.WriteLine("{0} + {1} = {2}", num2, num3, num1);
    }
    else
    {
        Console.WriteLine("{0} + {1} = {2}", num3, num2, num1);
    }
}
else
{
    Console.WriteLine("No");
}