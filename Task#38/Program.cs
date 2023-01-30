// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, double min, double max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
        // не до конца понимаю как работает эта конструкция генерации чисел
        // Если в () находится значение от -1 до 1, то получается, что в случае, когда там будет -1:
        // -1 * (10 - (-10)) + (-10) = -1 * 20 + (-10) = -20 + (-10) = -30, когда диапазон [-10, 10].
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{Math.Round(array[i], 1, MidpointRounding.ToZero)} | ");
        // Сделал разделитель не как в примере, не хотел иметь в выводе по две запятые для одного элемента.
        else Console.Write($"{Math.Round(array[i], 1, MidpointRounding.ToZero)}]");
    }
}

double ArrayMaxNum(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
    }
    return max;
}

double ArrayMinNum(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i];
    }
    return min;
}

double MaxMinDifference(double max, double min)
{
    double result = max - min;
    return result;
}

Console.WriteLine("Введите размер и диапазон значений массива.");
Console.Write("Размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Минимальное значение чисел в массиве: ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Максимальное значение чисел в массиве: ");
double max = Convert.ToDouble(Console.ReadLine());
// Тут также можно сделать проверки как и в Task#36V2

double[] arr = CreateArrayRndDouble(size, min, max);
Console.WriteLine();
Console.WriteLine("Созданный массив:");
PrintArray(arr);

double arrMax = ArrayMaxNum(arr);
double arrMin = ArrayMinNum(arr);
double result = MaxMinDifference(arrMax, arrMin);
Console.WriteLine($" -> разница между макс. и мин. элементами массива = {Math.Round(result, 1, MidpointRounding.ToZero)}");