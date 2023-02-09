// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixCreate(int[] array)
{
    int[,] array2D = new int[array[0], array[1]];
    Random rnd = new Random();
    for (int i = 0; i < array[0]; i++)
    {
        for (int j = 0; j < array[1]; j++)
        {
            array2D[i, j] = rnd.Next(array[2], array[3] + 1);
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

// Хотел сделать метод для ввода параметров, чтоб сократить кол-во повторений,
// но не знаю как адекватно сделать метод с выводом массива всех параметров 
// и чтоб не выводило никакие информационные сообщения в консоль (в процессе выполнения метода).
int[] MatrixParameters()
{
    int[] array = new int[4];
    Console.Write("Введите кол-во строк в массиве: ");
    array[0] = UserInput();
    if (array[0] <= 0) IncorrectValue();
    Console.Write("Введите кол-во столбцов в массиве: ");
    array[1] = UserInput();
    if (array[1] <= 0) IncorrectValue();
    Console.Write("Введите левую границу диапазона чисел: ");
    array[2] = UserInput();
    Console.Write("Введите правую границу диапазона чисел: ");
    array[3] = UserInput();
    return array;
}

bool MultiplicationMatrixCheck(int[,] firstMatrix, int[,] secondMatrix)
{
    return firstMatrix.GetLength(1) == secondMatrix.GetLength(0);
}

int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] multiplicationRes = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int n = 0; n < secondMatrix.GetLength(1); n++)
            {
                int result = firstMatrix[i, n] * secondMatrix[n, j];
                sum += result;
            }
            multiplicationRes[i,j] = sum;
        }
    }
    return multiplicationRes;
}


Console.WriteLine("Задайте первую матрицу.");
int[,] matrix1 = MatrixCreate(MatrixParameters());
Console.WriteLine();
Console.WriteLine("Задайте вторую матрицу.");
int[,] matrix2 = MatrixCreate(MatrixParameters());
Console.WriteLine();
Console.WriteLine("Первая матрица:");
PrintMatrix(matrix1);
Console.WriteLine("Вторая матрица:");
PrintMatrix(matrix2);

Console.WriteLine();
if (MultiplicationMatrixCheck(matrix1, matrix2) == true)
{
int[,] resultMatrix = (MatrixMultiplication(matrix1, matrix2));
Console.WriteLine("Итоговая матрица:");
PrintMatrix(resultMatrix);
}
else Console.WriteLine("Матрицы с такими параметрами умножить нельзя.");