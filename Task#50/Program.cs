// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

// В условии не сказано создает ли двумерный массив сам пользователь.
// При решении сделал так, что параметры двумерного массива вводятся пользователем.

int UserInput()
{
    int temp;
    if (int.TryParse(Console.ReadLine(), out temp)) ;
    else
    {
        Console.WriteLine("Введено некорректное значение.");
        Environment.Exit(0);
    }
    return temp;
}

void IncorrectValue()
// Сделал отдельный метод для обработки ситуации где введено некорректное значение для кол-ва строк или столбцов.
{
    Console.WriteLine("Введено некорректное значение.");
    Environment.Exit(0);
}

int[,] MatrixCreate(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
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

bool MatrixElementCheck(int[,] array, int rowsPos, int columnsPos)
// Сделал такое сложное условие, поскольку хотел видеть вывод ответа в консоль в случае,
// если пользователь введет отрицательные значения позиции элемента (-1, -5 -> такого элемента нет.)
{
    return rowsPos < array.GetLength(0) && rowsPos >= 0
         && columnsPos < array.GetLength(1) && columnsPos >= 0;
}

// Сперва сделал вывод искомого элемент через метод, но в данной задаче проще будет вывести его напрямую
// Но сам метод тоже решил оставить, как первоначальную версию вывода ответа.
//  int MatrixElemSelect(int[,] array, int rowsPos, int columnsPos)
//  {
//     return array[rowsPos,columnsPos];
//  }

Console.Write("Введите кол-во строк в массиве: ");
int rowsSize = UserInput();
if (rowsSize <= 0) IncorrectValue();
Console.Write("Введите кол-во столбцов в массиве: ");
int columnsSize = UserInput();
if (columnsSize <= 0) IncorrectValue();
Console.Write("Введите левую границу диапазона чисел: ");
int minValue = UserInput();
Console.Write("Введите правую границу диапазона чисел:");
int maxValue = UserInput();

int[,] matrix = MatrixCreate(rowsSize, columnsSize, minValue, maxValue);
Console.WriteLine("Заданный массив:");
PrintMatrix(matrix);

Console.Write("Введите строку искомого элемента: ");
int rowsElemPos = UserInput();
Console.Write("Введите столбец искомого элемента: ");
int columnsElemPos = UserInput();

bool elemExist = MatrixElementCheck(matrix, rowsElemPos - 1, columnsElemPos - 1);
// -1 Добавил, чтоб было более привычно задавать номера строки и столбцов (с 1, а не с 0)
Console.WriteLine(elemExist ? $"\r\nИскомый элемент: {matrix[rowsElemPos - 1, columnsElemPos - 1]}"
                            : $"\r\n{rowsElemPos}, {columnsElemPos} -> такого элемента в массиве нет");