// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray(int size) // Диапазон значений пользователь не выбирает исходя из условия.
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}]");
    }
}

int EvenCounter(int[] arr)
{
    int evencount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) evencount += 1;
    }
    return evencount;
}

Console.Write("Введите размер массива: ");
int length;
if (int.TryParse(Console.ReadLine(), out length) && length > 0) 
// Можно ли как-то сделать проверку на корректность введенных данных без помещения всего дальнейшего кода внутрь оператора "if"?
{
    int[] array = CreateArray(length);
    PrintArray(array);
    // int evenNumCount = EvenCounter(array); можно вынести результат метода в переменную.
    Console.Write($" -> {EvenCounter(array)} - кол-во четных чисел в массиве.");
}
else Console.WriteLine("Введено некорректное значение. Введите размер массива.");