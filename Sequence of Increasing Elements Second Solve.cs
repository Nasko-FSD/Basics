var n = int.Parse(Console.ReadLine());
var previous = int.MinValue;
var maxLenght = 0;
var lenght = 0;
for (int i = 0; i < n; i++)
{
    var CurrNumber = int.Parse(Console.ReadLine());
    if (CurrNumber > previous)
    {
        lenght++;
    }
    else
    {
        lenght = 1;
    }
    if (maxLenght < lenght)
    {
        maxLenght = lenght;
    }
    previous = CurrNumber;
}
Console.WriteLine(maxLenght);