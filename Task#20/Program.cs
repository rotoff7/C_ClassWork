// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Console.Write("Введите координаты точки A: \r\nX: ");
// double ax = Convert.ToDouble(Console.ReadLine());
// Console.Write("Y: ");
// double ay = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координаты точки B: \r\nX: ");
// double bx = Convert.ToDouble(Console.ReadLine());
// Console.Write("Y: ");
// double by = Convert.ToDouble(Console.ReadLine());

// double DistanceAB(double axc, double xyc, double bxc, double byc)
// {
//     double result = Math.Sqrt((bxc - axc) * (bxc - axc) + (byc - xyc) * (byc - xyc));
//     return (result);
// }
// double dist = DistanceAB(ax, ay, bx, by);
// Console.WriteLine(Math.Round(dist, 2, MidpointRounding.ToZero));

Console.Write("Введите координаты точки A: \r\nX: ");
double ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Y: ");
double ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B: \r\nX: ");
double bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Y: ");
double by = Convert.ToDouble(Console.ReadLine());

double dist = DistanceAB(ax, ay, bx, by);
Console.Write("Расстояние между точками A и B: ");
Console.WriteLine(Math.Round(dist, 2, MidpointRounding.ToZero));

double DistanceAB(double axc, double xyc, double bxc, double byc)
{
    double result = Math.Sqrt(Math.Pow((bxc - axc), 2) + Math.Pow((byc - xyc), 2));
    return (result);
}