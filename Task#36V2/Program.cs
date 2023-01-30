// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
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

int OddIndexSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

Console.WriteLine("Введите размер и диапазон значений массива.");
Console.Write("Размер массива: ");
int size;
if (int.TryParse(Console.ReadLine(), out size) && size > 0)
{
    Console.Write("Минимальное значение чисел в массиве: ");
    int min;
    if (int.TryParse(Console.ReadLine(), out min))
    {
        Console.Write("Максимальное значение чисел в массиве: ");
        int max;
        if (int.TryParse(Console.ReadLine(), out max) && max >= min)
        {
            int[] array = CreateArray(size, min, max);
            Console.WriteLine();
            Console.WriteLine("Созданный массив:");
            PrintArray(array);

            if (size > 1)
            {
                int sum = OddIndexSum(array);
                Console.WriteLine($" -> Сумма элементов, стоящих на нечётных позициях = {sum}");
            }
            else Console.WriteLine("\r\nВ массиве отсутствуют элементы стоящие на нечетных позициях.");
        }
        else Console.WriteLine("Введено некорректное значение правой границы диапазона массива.");
    }
    else Console.WriteLine("Введено некорректное значение левой границы диапазона массива.");
}
else Console.WriteLine("Введено некорректное значение размера массива.");

// Пытался придумать велосипед, как из того, что знаю, сделать более красивые проверки, но...
// В общем сделал как и раньше проверка через оператор "if" Правда тут достаточно много уровней вышло.
// По крайней мере программа теперь не вылетает с системной ошибкой если ввести не то значение.