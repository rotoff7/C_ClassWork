// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Нахождение координат точки пересечения двух прямых в одном методе через массив.

double UserInput()
{
    double coefficient;
    if (double.TryParse(Console.ReadLine(), out coefficient)) ;
    else
    {
        Console.WriteLine("Введено некорректное значение.");
        Environment.Exit(0);
    }
    return coefficient;
}

double[] IntersectionPointXY(double coefK1, double coefB1, double coefK2, double coefB2) 
{
    double[] coordinates = new double[2];
    coordinates[0] = ((coefB1 - coefB2)) / ((coefK1 - coefK2) * -1);
    coordinates[1] = (coefK2 * coordinates[0] + coefB2);
    return coordinates;
}

void PrintAnswer(double[] resultArray)
{
    Console.WriteLine($"(X: {Math.Round(resultArray[0], 1, MidpointRounding.ToZero)}; "
    + $"Y: {Math.Round(resultArray[1], 1, MidpointRounding.ToZero)})");
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
    double[] result = IntersectionPointXY(k1, b1, k2, b2);
    Console.Write($"При коэффициентах: k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2}"
    + $" -> Координаты точки пересечения прямых - ");
    PrintAnswer(result);
}
else if (b1 != b2) Console.WriteLine("Прямые параллельны. Точек пересечения нет.");
else Console.WriteLine("Прямые совпадают. Бесконечное число точек пересечения.");