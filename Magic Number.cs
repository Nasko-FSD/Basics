Console.Write("Enter the magic number that you want to produce: ");
var magicnumber = int.Parse(Console.ReadLine());
for (int numb1 = 0; numb1 <= 9; numb1++)
{
    for (int numb2 = 0; numb2 <= 9; numb2++)
    {
        for (int numb3 = 0; numb3 <= 9; numb3++)
        {
            for (int numb4 = 0; numb4 <= 9; numb4++)
            {
                for (int numb5 = 0; numb5 <= 9; numb5++)
                {
                    for (int numb6 = 0; numb6 <= 9; numb6++)
                    {
                        if (numb1 * numb2 * numb3 * numb4 * numb5 * numb6 == magicnumber)
                        {
                            Console.Write("{0}{1}{2}{3}{4}{5} ", numb1, numb2, numb3, numb4, numb5, numb6);
                        }
                    }
                }
            }
        }
    }
}