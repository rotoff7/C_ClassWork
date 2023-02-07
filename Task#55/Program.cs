// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

// 1 3 5 4      | 1 2
// 2 5 1 3      | 3 5 
// 7 5 2 4      | 5 1
// 6 1 4 2      | 4 3

void IncorrectValue()
{
    Console.WriteLine("Введено некорректное значение.");
    Environment.Exit(0);
}

int UserInput()
{
    if (!int.TryParse(Console.ReadLine(), out int temp)) IncorrectValue();
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

bool MatrixRowsColumnsCheck(int[,] array)
{
    return array.GetLength(0) == array.GetLength(1);
}

int[,] InvertedMatrix(int[,] array2D)
{
    int rowsCount = array2D.GetLength(0);
    int columnsCount = array2D.GetLength(1);
    int[,] invertedMatrix = new int[rowsCount, columnsCount];
    for (int i = 0; i < rowsCount; i++)
    {
        for (int j = 0; j < columnsCount; j++)
        {
            invertedMatrix[i,j] = array2D[j,i];
        }
    }
    return invertedMatrix;
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
if (MatrixRowsColumnsCheck(matrix) == true)
{
int[,] afterInvert = InvertedMatrix(matrix);
Console.WriteLine("Новый массив:");
PrintMatrix(afterInvert);
}
else Console.WriteLine("Невозможно заменить строки на столбцы.");