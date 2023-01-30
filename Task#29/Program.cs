// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Условие на сайте и условие в семинаре к данной задаче отличаются. Тут я делал без псевдослучайного рандома.
// Также решение не для строго ограничения в 8 элементов, тут размер задает пользователь.
int[] MassiveCreate(int massivesize)
{
    Random rnd = new Random();
    int[] array = new int[massivesize];
    for (int i = 0; i < massivesize; i++)
        array[i] = rnd.Next(1, 101);
    return array;
}

// void ArrayPrint(int[] col)
// // Это первый вариант вывода массива как можно ближе к тому, что в условии, но чтоб еще и код выглядел адекватно.
// // Но мне не очень нравится такая костыльная склейка между массивами без скобок и со скобками.
// {
//     for (int i = 0; i < col.Length; i++)
//     {
//         Console.Write($"{col[i]} ");
//     }
//     Console.Write("-> [");
//     for (int i = 0; i < col.Length; i++)
//     {
//         Console.Write($"{col[i]} ");
//     }
//     Console.Write("]");
// }

void ArrayPrint2(int[] col) // Вывод ответа 1 в 1 как в примере
// Второй способ вывода массива. Сделал так, чтоб выглядел 1 в 1.
// Однако сам код меня смущает. Пришлось помудрить чтоб не смотря на цикл "концы" массива выводились правильно.
{
    for (int i = 0; i < col.Length; i++)
    {
        if (i < col.Length - 1)
            Console.Write($"{col[i]}, ");
        else
            Console.Write(col[i]);
    }
}

Console.Write("Введите размер массива: ");
int size;
if (int.TryParse(Console.ReadLine(), out size) && size > 0)
{
    int[] array = MassiveCreate(size);
    ArrayPrint2(array);
    Console.Write(" -> [");
    ArrayPrint2(array);
    Console.Write("]");
}
else Console.WriteLine("Введено некорректное значение. Введите размер массива.");