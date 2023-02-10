// *Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


// Скорее всего данное решение страдает в плане оптимизации.
// Но задача по созданию случайных неповторяющихся чисел поставил в сильное затруднение.
// И без использования гугла дошел вот до такого решения.

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

int[,,] Matrix3DCreate(int rows, int columns, int depth) // создаем пустой 3-x массив
{
    int[,,] array3D = new int[rows, columns, depth];
    return array3D;
}

int RandomValue(int min, int max)
{
    Random rnd = new Random();
    int value = rnd.Next(min, max + 1);
    return value;
}

bool UniqueValueCheck(int[,,] array3D, int value) // Проходим по всему массиву и проверяем совпадения
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                if (array3D[i, j, k] == value) return true;
            }
        }
    }
    return false;
}

void Matrix3DFiller(int[,,] array3D, int min, int max) // Заполняем 3-x массив уникальными двузначными числами
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                int value = RandomValue(min, max);
                while (UniqueValueCheck(array3D, value) == true)
                {
                    value = RandomValue(min, max);
                }
                array3D[i, j, k] = value;
            }
        }
    }
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

int[,,] matrix = Matrix3DCreate(rowsSize, columnsSize, depthSize);
if (matrix.Length <= 90)
{
    Matrix3DFiller(matrix, minValue, maxValue);
    Console.WriteLine("Заданный массив:");
    Print3DMatrix(matrix);
}
else Console.WriteLine("Кол-во элементов в массиве с такими параметрами превышает 90. "
+ "Невозможно заполнить данный массив неповторяющимися двузначными числами.");