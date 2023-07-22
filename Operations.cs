Console.Write("Enter the first number: ");
double num1 = double.Parse(Console.ReadLine());
Console.Write("Enter the second number: ");
double num2 = double.Parse(Console.ReadLine());
Console.Write("Enter an operator: ");
string operator1 = (Console.ReadLine());
if ((operator1 == "/" || operator1 == "%") && num2 == 0)
{
    Console.WriteLine("Cannot divide {0} by zero", num1);
}
if ( operator1 == "-" )
{
    {
        Console.WriteLine("{0} {1} {2} = {3} {4}", num1, operator1, num2, (num1 - num2),
            (num1 - num2) % 2 == 0 ? "- even" : "- odd");
    }
}
if ( operator1 == "+" )
{
    {
        Console.WriteLine("{0} {1} {2} = {3} {4} ", num1, operator1, num2, (num1 + num2),
            (num1 + num2) % 2 == 0 ? "- even" : "- odd");
    }
}
if (operator1 == "*")
{
    {
        Console.WriteLine("{0} {1} {2} = {3} {4}", num1, operator1, num2, (num1 * num2),
            (num1 * num2) % 2 == 0 ? "- even" : "- odd");
    }
}
if (operator1 == "/" && num2 != 0)
{
    {
        Console.WriteLine("{0} {1} {2} = {3:f2}", num1, operator1, num2, (num1 / num2));
    }
}
if (operator1 == "%" && num2 != 0)
{
    {
        Console.WriteLine("{0} {1} {2} = {3}", num1, operator1, num2, (num1 % num2));
    }
}