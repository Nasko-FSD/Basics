Console.Write("Enter the area of the vine yard: ");
var vineyardArea = double.Parse(Console.ReadLine());
Console.Write("Enter the grapes per square: ");
var grapePerSquare = double.Parse(Console.ReadLine());
Console.Write("Enter the needed liters: ");
var neededLiters = double.Parse(Console.ReadLine());
Console.Write("Enter the workers: ");
var workers = int.Parse(Console.ReadLine());
var harvestPerVine = (vineyardArea * grapePerSquare) * 0.4;
var vine = harvestPerVine / 2.5;
if (vine >= neededLiters)
{
    var vineleft = vine - neededLiters;
    Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(vine));
    Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(vineleft),
        Math.Ceiling(vineleft / workers));
}
else
{
    Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",
        Math.Floor(neededLiters - vine));
}