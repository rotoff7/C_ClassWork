// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void IncorrectValue()
{
    Console.WriteLine("Введено некорректное значение");
    Environment.Exit(0);
}

int UserInput()
{
    if (!int.TryParse(Console.ReadLine(), out int temp)) IncorrectValue();
    return temp;
}

int[,] MatrixCreate(int rows, int columns, int min, int max)
{
    int[,] array2D = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array2D[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array2D;
}

void PrintMatrix(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (j < array2D.GetLength(1) - 1)
                Console.Write($"{array2D[i, j],3} |");
            else Console.WriteLine($"{array2D[i, j],3}]");
        }
    }
}

int[] MatrixRowsSum(int[,] array2D)
{
    int[] result = new int[array2D.GetLength(0)];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            sum += array2D[i, j];
        }
        result[i] = sum;
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else Console.WriteLine(array[i]);
    }
}

int RowsMinSumIndex(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minIndex = i;
        }
    }
    return minIndex;
}

void PrintResult(int rowIndex)
{
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {rowIndex + 1}-я строка.");
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

int[] matrixAllRowsSum = MatrixRowsSum(matrix);

// Эти две строки использовал для наглядности (не требуется по условию задачи).
Console.Write("Суммы всех строк двумерного массива: ");
PrintArray(matrixAllRowsSum);

PrintResult(RowsMinSumIndex(matrixAllRowsSum));