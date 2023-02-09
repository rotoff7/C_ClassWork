// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void MatrixSorting(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int m = 0; m < array2D.GetLength(1) - 1; m++) // array2D.GetLength(1) - 1 Убирает лишний прогон
        {
            int max = array2D[i, m];
            int maxColumnsIndex = m;
            for (int j = m + 1; j < array2D.GetLength(1); j++) // m + 1 Исключает сравнение первого элемента с самим собой (поскольку он будет задан как max.)
            {
                if (array2D[i, j] > max)
                {
                    max = array2D[i, j];
                    maxColumnsIndex = j;
                }
            }
            int temp = max;
            array2D[i, maxColumnsIndex] = array2D[i, m];
            array2D[i, m] = max;
        }
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
MatrixSorting(matrix);
Console.WriteLine("Отсортированный массив:");
PrintMatrix(matrix);