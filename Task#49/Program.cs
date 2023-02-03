// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int UserInput()
{
    int temp;
    if (int.TryParse(Console.ReadLine(), out temp)) ;
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
                Console.Write($"{arr[i, j],4} |");
            else Console.Write($"{arr[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

void MatrixElementsSwap(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i +=2)
{
    for (int j = 0; j < arr.GetLength(1); j +=2)
    {
            arr[i,j] *= arr[i,j]; 
            // arr[i,j] = (int)Math.Pow(arr[i,j], 2);
    }
}
}

Console.Write("Введите кол-во строк: ");
int rowsSize = UserInput();
Console.Write("Введите кол-во столбцов: ");
int columnsSize = UserInput();
Console.Write("Введите левую границу диапазона чисел: ");
int min = UserInput();
Console.Write("Введите правую границу диапазона чисел:");
int max = UserInput();

int[,] matrix = CreateMatrixArray(rowsSize, columnsSize, min, max);
PrintMatrixArray(matrix);
MatrixElementsSwap(matrix);
Console.WriteLine("\r\nКвадраты элементов с четными индексами");
PrintMatrixArray(matrix);
