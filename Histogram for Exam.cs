double p1Percentage = 0;
double p2Percentage = 0;
double p3Percentage = 0;
double p4Percentage = 0;
double p5Percentage = 0;
int cntP1 = 0;
int cntP2 = 0;
int cntP3 = 0;
int cntP4 = 0;
int cntP5 = 0;
double n = double.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    double num = double.Parse(Console.ReadLine());
    if (num < 200)
    {
        cntP1++;
    }
    else if (num >= 200 && num < 400)
    {
        cntP2++;
    }
    else if (num >= 400 && num < 600)
    {
        cntP3++;
    }
    else if (num >= 600 && num < 800)
    {
        cntP4++;
    }
    else
    {
        cntP5++;
    }
}
p1Percentage = cntP1 * 100 / n;
p2Percentage = cntP2 * 100 / n;
p3Percentage = cntP3 * 100 / n;
p4Percentage = cntP4 * 100 / n;
p5Percentage = cntP5 * 100 / n;
Console.WriteLine("{0:f2}%", p1Percentage);
Console.WriteLine("{0:f2}%", p2Percentage);
Console.WriteLine("{0:f2}%", p3Percentage);
Console.WriteLine("{0:f2}%", p4Percentage);
Console.WriteLine("{0:f2}%", p5Percentage);