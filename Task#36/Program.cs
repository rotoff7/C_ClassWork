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
        if (i<array.Length - 1)
        Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");
    }
}

int OddIndexSum(int[] array)
{
int sum = 0;
for (int i = 1; i < array.Length; i+=2)
{
    sum += array[i];
}
return sum;
}

// Поскольку из условий нету ограничений на размер и диапазон чисел, то все это задает пользователь.
Console.WriteLine("Введите размер и диапазон значений массива.");
Console.Write("Размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Минимальное значение чисел в массиве: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Максимальное значение чисел в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());

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

// Тут просто выполнял поставленное задание (основной файл), без введения различных проверок.
// Исходя из того как я делал их раньше, тут бы вышло много текста + не уверен в их корректности.
// В папке Task#36V2. Решил поэкспериментировать и добавить различные проверки на ввод данных.