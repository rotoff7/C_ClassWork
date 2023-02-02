// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Способ 1. Нахождение координат точки пересечения отдельными методами.

double UserInput()
// Попробовал объединить проверку введенных данных в метод, вроде все работает и код выглядит приятно.
// Надеюсь только вот эта хитрость с Environment.Exit(0) действует так, как думаю.
// Если же так делать не стоит, то тогда бы сделал обычную инициализацию переменных с конвертацией.
{
    double coefficient;
    if (double.TryParse(Console.ReadLine(), out coefficient));
    else
    {
        Console.WriteLine("Введено некорректное значение.");
        Environment.Exit(0);
    }
    return coefficient;
}

double IntersectionPointCoorX(double coefK1, double coefB1, double coefK2, double coefB2)
{
    double resX = ((coefB1 - coefB2)) / ((coefK1 - coefK2) * -1);
    return resX;
}

double IntersectionPointCoorY(double coefK2, double coordinateX, double coefB2)
{
    double resY = (coefK2 * coordinateX + coefB2);
    return resY;
}

Console.WriteLine("Нахождение точки пересечения двух прямых, заданных уравнением вида:"
+ "\r\n'y = kx + b'.");
Console.WriteLine("Введите коэффициенты k1, b1, k2, b2.");
Console.Write("Введите коэффициент k1: ");
double k1 = UserInput();
Console.Write("Введите коэффициент b1: ");
double b1 = UserInput();
Console.Write("Введите коэффициент k2: ");
double k2 = UserInput();
Console.Write("Введите коэффициент b2: ");
double b2 = UserInput();

if (k1 != k2)
{
    double coordX = IntersectionPointCoorX(k1, b1, k2, b2);
    double coordY = IntersectionPointCoorY(k2, coordX, b2);
    Console.WriteLine($"При коэффициентах: k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2}"
    + $" -> Координаты точки пересечения прямых "
    + $"- (X: {Math.Round(coordX, 1, MidpointRounding.ToZero)}; Y: {Math.Round(coordY, 1, MidpointRounding.ToZero)})");
}
else if (b1 != b2) Console.WriteLine("Прямые параллельны. Точек пересечения нет.");
else Console.WriteLine("Прямые совпадают. Бесконечное число точек пересечения.");