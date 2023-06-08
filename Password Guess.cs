Console.Write("Enter the password: ");
var password = (Console.ReadLine());
string realpassword = "s3cr3t!P@ssw0rd";
if ( password != realpassword)
{
    Console.Write("Wrong password!");
}
else if ( password == realpassword)
{
    Console.WriteLine("Welcome");
}


