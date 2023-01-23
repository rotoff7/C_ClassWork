// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double DistanceAB(double axc, double xyc, double xzc, double bxc, double byc, double bzc)
{
    double result = Math.Sqrt(Math.Pow((bxc - axc), 2) + Math.Pow((byc - xyc), 2) + Math.Pow((bzc - xzc), 2));
    return (result);
}

Console.Write("Введите координаты точки A: \r\nX: ");
double ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Y: ");
double ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Z: ");
double az = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B: \r\nX: ");
double bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Y: ");
double by = Convert.ToDouble(Console.ReadLine());
Console.Write("Z: ");
double bz = Convert.ToDouble(Console.ReadLine());

double dist = DistanceAB(ax, ay, az, bx, by, bz);
Console.Write("Расстояние между точками A и B: ");
Console.WriteLine(Math.Round(dist, 2, MidpointRounding.ToZero));
// Не до конца разобрался с стратегиями округления, и как именно работает параметр "MidpointRounding.ToZero", просто оставил его из семинара.
// В интернете описание: Стратегия направленного округления к нулю, с результатом, ближайшим к и не превышающим бесконечно точный результат.