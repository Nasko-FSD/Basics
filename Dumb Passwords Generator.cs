Console.Write("Enter a number in range from 1 to 9: ");
var num = int.Parse(Console.ReadLine());
Console.Write("Enter a number in range from 1 to 9: ");
var letter = int.Parse(Console.ReadLine());
for (int num1 = 1; num1 <= num; num1++)
{
    for (var num2 = 1; num2 <= num; num2++)
    {
        for (char letter1 = 'a'; letter1 < 'a' + letter; letter1++)
        {
            for (char letter2 = 'a'; letter2 < 'a' + letter; letter2++)
            {
                for (var num3 = Math.Max(num1, num2) + 1; num3 <= num; num3++)
                {
                    Console.Write("{0}{1}{2}{3}{4} ", num1, num2, letter1, letter2, num3);
                }
            }

        }

    }
}