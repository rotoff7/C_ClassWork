// *Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

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

int[,,] Matrix3DCreate(int rows, int columns, int depth, int min, int max)
{
    int[,,] array3D = new int[rows, columns, depth];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                array3D[i, j, k] = rnd.Next(min, max + 1);
            }
        }
    }
    return array3D;
}

void Print3DMatrix(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                if (j == array3D.GetLength(1) - 1 && k == array3D.GetLength(2) - 1)
                    Console.Write($"{array3D[i, j, k],3}({i},{j},{k})");
                else Console.Write($"{array3D[i, j, k],3}({i},{j},{k}) |");
            }
        }
        Console.WriteLine("]");
    }
}

Console.Write("Введите кол-во строк в массиве: ");
int rowsSize = UserInput();
if (rowsSize <= 0) IncorrectValue();
Console.Write("Введите кол-во столбцов в массиве: ");
int columnsSize = UserInput();
if (columnsSize <= 0) IncorrectValue();
Console.Write("Введите глубину массива: ");
int depthSize = UserInput();
if (depthSize <= 0) IncorrectValue();
int minValue = 10;
int maxValue = 99;

int[,,] matrix = Matrix3DCreate(rowsSize, columnsSize, depthSize, minValue, maxValue);
Console.WriteLine("Заданный массив:");
Print3DMatrix(matrix);
