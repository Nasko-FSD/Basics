﻿Console.Write("Enter the vegetable price per kg: ");
double vegetable = double.Parse(Console.ReadLine());
Console.Write("Enter the fruit price per kg: ");
double fruit = double.Parse(Console.ReadLine());
Console.Write("Enter the total vegetable kg: ");
int vegetablekg = int.Parse(Console.ReadLine());
Console.Write("Enter the total fruit kg: ");
int fruitkg = int.Parse(Console.ReadLine());
double sum = ((vegetablekg * vegetable) / 1.94) + ((fruitkg * fruit) / 1.94);
Console.WriteLine("The total sum in Euro is: " + Math.Round(sum, 2));