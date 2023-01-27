// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
        if (i < massive.Length - 1) Console.Write($"{massive[i]} ");
        else Console.Write($"{massive[i]}");
    }
    Console.Write("]");
}

int[] TwoNumbersMultiply(int[] massive)
{
    int size = massive.Length / 2;
    if (massive.Length % 2 == 1) size += 1;
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = massive[i] * massive[massive.Length - 1 - i];
    }

    if (massive.Length % 2 == 1) newArray[size - 1] = massive[massive.Length / 2];

    return newArray;
}

int[] arr = CreateArrayRndInt(7, 1, 15);
PrintArray(arr);
int[] newArr = TwoNumbersMultiply(arr);
Console.WriteLine("\r\nНовый массив:");
PrintArray(newArr);