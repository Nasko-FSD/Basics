Console.Write("Enter the volume of the pool: ");
int volume = int.Parse(Console.ReadLine());
Console.Write("Enter the flow rate of the first pipe per hour: ");
int pipe1 = int.Parse(Console.ReadLine());
Console.Write("Enter the flow rate of the second pipe per hour: ");
int pipe2 = int.Parse(Console.ReadLine());
Console.Write("Enter the hours that the worker is absent: ");
double hours = double.Parse(Console.ReadLine());
double water = pipe1 * hours + pipe2 * hours;
if ( water <= volume)
{
    Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
    Math.Truncate(water / volume * 100),
    Math.Truncate(pipe1 * hours / water * 100),
    Math.Truncate(pipe2 * hours / water * 100));
}
else
{
    Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, water - volume);
}
