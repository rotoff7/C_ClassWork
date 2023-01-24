// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void MassiveFiller(int[] col)
{
    for (int i = 0; i < col.Length; i++)
        col[i] = new Random().Next(0, 2);
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
        Console.Write($"  {col[i]}");
    }
}

int[] array = new int[8];
MassiveFiller(array);
MassiveConclusion(array);
// MassiveRighter(array);