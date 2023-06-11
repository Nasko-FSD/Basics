Console.Write("Enter your first word: ");
string word1 = (Console.ReadLine());
Console.Write("Enter your second word: ");
string word2 = (Console.ReadLine());
if (word1.ToLower() == word2.ToLower())
{
    Console.WriteLine("yes");
}
else if (word1 != word2)
        {
    Console.WriteLine("no");
}