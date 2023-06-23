Console.Write("Enter the age on person: ");
var age = double.Parse(Console.ReadLine());
Console.Write("Enter the sex on person: ");
string gender = (Console.ReadLine());
if (gender == "m" && age >= 16)
{
    Console.WriteLine("Mr.");
}
else if (gender == "m" && age < 16)
{
    Console.WriteLine("Master");
}
if (gender == "f" && age >= 16)
{
    Console.WriteLine("Ms.");
}
else if (gender == "f" && age < 16)
{
    Console.WriteLine("Miss");
}