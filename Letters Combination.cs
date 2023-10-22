char First = char.Parse(Console.ReadLine().ToLower());
char Second = char.Parse(Console.ReadLine().ToLower());
char Third = char.Parse(Console.ReadLine().ToLower());
var combination = 0;
for (char one = First; one <= Second; one++)
{
    for (char two = First; two <= Second; two++)
    {
        for (char three = First; three <= Second; three++)
        {
            if (one != Third && two != Third && three != Third)
            {
                Console.Write("{0}{1}{2} ", one, two, three);
                combination++;
            }
        }
    }
}
Console.Write("{0} ", combination);