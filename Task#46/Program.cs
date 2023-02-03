// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int UserInput()
{
    int temp;
    if (int.TryParse(Console.ReadLine(), out temp) && temp > 0) ;
    else
    {
        Console.WriteLine("Введено некорректное значение");
        Environment.Exit(0);
    }
    return temp;
}

int[,] CreateMatrixArray(int rows, int columns, int min, int max)
{
    int[,] arr = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void PrintMatrixArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j < arr.GetLength(1) - 1)
                Console.Write($"{arr[i, j], 4} |");
            else Console.Write($"{arr[i, j], 4}");
        }
        Console.WriteLine("]");
    }
}

Console.Write("Введите кол-во строк: ");
int rowsSize = UserInput();
Console.Write("Введите кол-во столбцов: ");
int columnsSize = UserInput();
int[,] matrix = CreateMatrixArray(rowsSize, columnsSize, -100, 100);
PrintMatrixArray(matrix);