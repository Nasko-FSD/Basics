Console.Write("Enter an animal: ");
var animal = (Console.ReadLine());
if ( animal == "tortoise" || animal == "snake" || animal == "crocodile")
{
    Console.WriteLine("reptile");
}
else if (animal == "dog")
{
    Console.WriteLine("mammal");
}
else
{
    Console.WriteLine("unknown");
}