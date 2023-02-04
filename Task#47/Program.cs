// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Подумать над проверками ввода данных.
int UserInputInt()
{
    int temp;
    if (int.TryParse(Console.ReadLine(), out temp) && temp > 0) ;
    else
    {
        Console.WriteLine("Введено некорректное значение.");
        Environment.Exit(0);
    }
    return temp;
}

double UserInputDouble()
{
    double temp;
    if (double.TryParse(Console.ReadLine(), out temp)) ;
    else
    {
        Console.WriteLine("Введено некорректное значение.");
        Environment.Exit(0);
    }
    return temp;
}

double[,] MatrixDoubleCreate(int rows, int columns, double min, double max)
{
    double[,] array = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return array;
}

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1) 
            Console.Write($"{Math.Round(array[i, j], 1, MidpointRounding.ToZero),5} |");
            else Console.Write($"{Math.Round(array[i, j], 1, MidpointRounding.ToZero),5}");
        }
        Console.WriteLine("]");
    }
}

Console.Write("Введите кол-во строк: ");
int rowsSize = UserInputInt();
Console.Write("Введите кол-во столбцов: ");
int columnsSize = UserInputInt();
Console.Write("Введите левую границу диапазона чисел: ");
double min = UserInputDouble();
Console.Write("Введите правую границу диапазона чисел: ");
double max = UserInputDouble();

double[,] matrix = MatrixDoubleCreate(rowsSize, columnsSize, min, max);
PrintMatrix(matrix);