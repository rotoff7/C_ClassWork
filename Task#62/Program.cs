// *Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

int[,] MatrixCreate(int rows, int columns)
{
    int[,] array2D = new int[rows, columns];
    return array2D;
}

void MatrixFilling(int[,] array2D)
{
    int count = 1;
    int i = 0;
    int j = 0;
    for (j = 0; j < array2D.GetLength(1); j++)
    {
        array2D[i, j] = count;
        count++;
    }
    for (i = 1; i < array2D.GetLength(0); i++)
    {
        array2D[i, j - 1] = count;
        count++;
    }
    for (j = 2; j >= 0; j--)
    {
        array2D[i - 1, j] = count;
        count++;
    }
    for (i = 2; i >= 1; i--)
    {
        array2D[i, j + 1] = count;
        count++;
    }
    for (j = 1; j < array2D.GetLength(1) - 1; j++)
    {
        array2D[i + 1, j] = count;
        count++;
    }
    for (i = 2; i < 3; i++)
    {
        array2D[i, j - 1] = count;
        count++;
    }
    for (j = 1; j >= 1; j--)
    {
        array2D[i-1, j] = count;
        count++;
    }
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

Console.Write("Введите кол-во строк в массиве: ");
int rowsSize = UserInput();
if (rowsSize <= 0) IncorrectValue();
Console.Write("Введите кол-во столбцов в массиве: ");
int columnsSize = UserInput();
if (columnsSize <= 0) IncorrectValue();

int[,] array2D = MatrixCreate(rowsSize, columnsSize);
MatrixFilling(array2D);
Console.WriteLine("Заданный массив:");
PrintMatrix(array2D);
