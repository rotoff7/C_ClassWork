// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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

int MainDiagonalElementsSum(int[,] arr)
{
    int result = 0;
    // int limitation;
    // if (arr.GetLength(0) > arr.GetLength(1)) limitation = arr.GetLength(1);
    // else limitation = arr.GetLength(0);
    for (int i = 0; i < arr.GetLength(0) && i < arr.GetLength(1); i++)
    {
       result += arr[i,i];
    }
    return result;
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
int answer = MainDiagonalElementsSum(matrix);
Console.WriteLine($"Сумма чисел главной диагонали = {answer}");
