Console.Write("Enter score: ");
var num = double.Parse(Console.ReadLine());
var bonus = 0.0;

if (num <= 100)
{
    bonus = bonus + 5;
}
else if (num <= 1000)
{
    bonus = bonus + num * 0.2;
}
else if (num > 1000)
        {
    bonus = bonus + num * 0.1;
}

if (num % 2 == 0)
{
    bonus = bonus + 1;
}
else if (num % 10 == 5)
{
    bonus = bonus + 2;
}
Console.WriteLine("Bonus score: " + bonus);
Console.WriteLine("Total score: {0}",num + bonus);