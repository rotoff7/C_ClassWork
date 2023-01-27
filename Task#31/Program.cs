// Задача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] massive)
{
    Console.Write("[");
    for (int i = 0; i < massive.Length; i++)
    {
        if (i < massive.Length - 1) Console.Write($"{massive[i]}, ");
        else Console.Write($"{massive[i]}");
    }
    Console.Write("]");

}

int[] GetSumNegativePositiveElem(int[] massive)
{
    int sumNeagative = 0;
    int sumPosititve = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] < 0) sumNeagative += massive[i];
        else sumPosititve += massive[i];
    }
    return new int[] { sumNeagative, sumPosititve };
}

int SumPositive(int[] massive)
{
    int sumPos = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] > 0)
        sumPos += massive[i];
    }
    return sumPos;
}

int SumNegative(int[] massive)
{
    int sumNeg = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] < 0)
        sumNeg += massive[i];
    }
    return sumNeg;
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int[] sumNegativePositiveElems = GetSumNegativePositiveElem(arr);
Console.WriteLine("");
Console.WriteLine($"Сумма отрицательных элементов = {sumNegativePositiveElems[0]}");
Console.WriteLine($"Сумма положительных элементов = {sumNegativePositiveElems[1]}");

int positsum = SumNegative(arr);
int negatsum = SumPositive(arr);
Console.WriteLine("");
Console.WriteLine($"Сумма положительных элементов = {SumNegative(arr)}");
Console.WriteLine($"Сумма положительных элементов = {SumPositive(arr)}");