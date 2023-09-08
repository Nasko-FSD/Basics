var n = int.Parse(Console.ReadLine());
var CurrentLenght = 0;
var maxLenght = 0;
var previousNumber = int.MinValue;
for (int i = 0; i < n; i++)
{
    var CurrentNumber = int.Parse(Console.ReadLine());
    if (CurrentNumber > previousNumber)
    {
        CurrentLenght++;
    }
    else
    {
        if (maxLenght < CurrentLenght)
        {
            maxLenght = CurrentLenght;
        }
        CurrentLenght = 1;
    }
    previousNumber = CurrentNumber;
}
if (maxLenght < CurrentLenght)
{
    maxLenght = CurrentLenght;
}
Console.WriteLine(maxLenght);