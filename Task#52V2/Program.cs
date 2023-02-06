// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void IncorrectValue()
{
    Console.WriteLine("Введено некорректное значение.");
    Environment.Exit(0);
}

int UserInput()
{
    int temp;
    if (int.TryParse(Console.ReadLine(), out temp)) ;
    else IncorrectValue();
    return temp;
}

int[,] MatrixCreate(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1)
                Console.Write($"{array[i, j],4} |");
            else Console.WriteLine($"{array[i, j],4}]");
        }
    }
}

double ColumnAverage(int[,] array, int columnNumber)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, columnNumber - 1];
    }
    double averageValue = sum / array.GetLength(0);
    return averageValue;
}

void ColumnAveragePrint(double average)
{
    Console.WriteLine(Math.Round(average, 1, MidpointRounding.ToZero));
}

void AllAveragePrint(int[,] array)
// К индексу прибавляется единица, поскольку внутри метода расчета ColumnAverage из индекса вычитается единица.
// Сделано на случай если пользователь введет цифру 2, желая отдельно вывести среднее арифметическое для 2-ого столбца, а не третьего.
// Если воспользуется методом ColumnAverage отдельно.
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        if (i < array.GetLength(1) - 1)
            Console.Write($"{Math.Round(ColumnAverage(array, i + 1), 1, MidpointRounding.ToZero)}; ");
        else Console.WriteLine($"{Math.Round(ColumnAverage(array, i + 1), 1, MidpointRounding.ToZero)}.");
    }
}

Console.Write("Введите кол-во строк в массиве: ");
int rowsSize = UserInput();
if (rowsSize <= 0) IncorrectValue();
Console.Write("Введите кол-во столбцов в массиве: ");
int columnsSize = UserInput();
if (columnsSize <= 0) IncorrectValue();
Console.Write("Введите левую границу диапазона чисел: ");
int minValue = UserInput();
Console.Write("Введите правую границу диапазона чисел: ");
int maxValue = UserInput();

int[,] matrix = MatrixCreate(rowsSize, columnsSize, minValue, maxValue);
Console.WriteLine("Заданный массив:");
PrintMatrix(matrix);

Console.WriteLine();
AllAveragePrint(matrix);

// Для проверки, что отдельные столбцы выводит корректно (для массива где 4 или больше столбцов.)
Console.Write("Среднее арифметического второго столбца: ");
ColumnAveragePrint(ColumnAverage(matrix, 2));
Console.Write("Среднее арифметического четвертого столбца: ");
ColumnAveragePrint(ColumnAverage(matrix, 4));