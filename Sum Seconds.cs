var num = int.Parse(Console.ReadLine());
var num1 =int.Parse(Console.ReadLine());
var num2 =int.Parse(Console.ReadLine());
var seconds = num + num1 + num2;
var minutes = seconds / 60;
seconds = seconds % 60;

if (seconds < 10)
{
    Console.WriteLine(minutes + ":0" + seconds);

}
else
{
    Console.WriteLine(minutes + ":" + seconds);
}
