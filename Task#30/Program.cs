// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void MassiveFiller(int[] col)
{
    Random rnd = new Random();
    for (int i = 0; i < col.Length; i++)

        col[i] = rnd.Next(0, 2);
}

// void MassiveRighter(int[] col) // Вывод через переменную var.
// {
//     var newcole = string.Join(" ", col);
//     Console.WriteLine("Получившийся  массив: ");
//     Console.WriteLine(newcole);
// }

void MassiveConclusion(int[] col) // Вывод через цикл + консоль.
{
    Console.Write("Получившийся  массив: ");
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($"|{col[i]}");
    }
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
MassiveFiller(array);
MassiveConclusion(array);
// MassiveRighter(array);


// V2.
// int[] arr = CreateArray(8);
// PrintArray(arr);


// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(0, 2);
//     }
//     return array;
// }


// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }