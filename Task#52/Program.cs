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

// В этот раз решил сделать остановку программы, с ошибкой о неверно введенном значении, через метод внутри метода.
// Или так делать лучше не стоит, поскольку метод ссылается на другой метод?
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

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{Math.Round(array[i], 1, MidpointRounding.ToZero)}; ");
        else Console.WriteLine($"{Math.Round(array[i], 1, MidpointRounding.ToZero)}.");
    }
}

// Исходя из того, что было вначале прошлого семинара, я понял, что достаточно иметь одну из переменных по типу double, при вычислении
// среднего арифметического тоже с типом double, чтоб в результатах также пошли значения с цифрами после запятой.
// Тут такая переменная - sum.
double[] AllColumnsAverage(int[,] array)
{
    double[] averageValues = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        averageValues[j] = sum / array.GetLength(0);
    }
    return averageValues;
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

double[] columnsAverageValues = AllColumnsAverage(matrix);
Console.WriteLine();
Console.Write($"Среднее арифметическое каждого столбца: ");
PrintArray(columnsAverageValues);