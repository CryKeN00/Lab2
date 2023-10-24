using System;

Console.WriteLine("Введите первую сторону треугольника");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите вторую сторону треугольника");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите длину основания треуголника");
double c = Convert.ToDouble(Console.ReadLine());
double p = (a + b + c) / 2;
double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
if (a + b > c && a + c > b && c + b > a)
{
    Console.WriteLine($"Площадь треуголника будет = {S}");
}
else
{
    Console.WriteLine("Треугольник не существует");
}