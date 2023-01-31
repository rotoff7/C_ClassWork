// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int[] FibonacciArray(int arrSize)
{
    int[] arr = new int[arrSize];
    arr[1] = 1;
    for (int i = 2; i < arrSize; i++)
    {
        arr[i] = arr[i - 2] + arr[i - 1];
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");
    }
}

Console.Write("Введите желаемое кол-во цифр последовательности Фибоначчи: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size > 1)
{
    int[] fibArray = FibonacciArray(size);
    PrintArray(fibArray);
}
else if (size == 1)
    Console.WriteLine("[0]");
else Console.WriteLine("Введено некорректное число");
