double Savings = double.Parse(Console.ReadLine());
double FloorWidth = double.Parse(Console.ReadLine());
double FloorLength = double.Parse(Console.ReadLine());
double SideTriangle = double.Parse(Console.ReadLine());
double HeightTriangle = double.Parse(Console.ReadLine());
double TilePrice = double.Parse(Console.ReadLine());
double Salary = double.Parse(Console.ReadLine());
double FloorArea = FloorWidth * FloorLength;
double TriangleArea = (SideTriangle * HeightTriangle) / 2;
double TilesPcs = Math.Ceiling(FloorArea / TriangleArea);
double TotalTiles = TilesPcs + 5;
double TotalTilePrice = TilePrice * TotalTiles;
double RepairMoney = Salary + TotalTilePrice;
if (Savings >= RepairMoney)
{
    double Left = Savings - RepairMoney;
    Console.WriteLine("{0:f2} lv left.", Left);
}
else
{
    double Insufficient = Math.Abs(Savings - RepairMoney);
    Console.WriteLine("You'll need {0:f2} lv more.", Insufficient);
}