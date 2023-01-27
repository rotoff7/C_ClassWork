// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool NumExist(int[] massive, int number)
{
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] == number) return true;
    }
    return false;
}

int[] arr = CreateArrayRndInt(15, -10, 10);
Console.Write("Введите искомое число: ");
int num = Convert.ToInt32(Console.ReadLine());
PrintArray(arr);
Console.WriteLine();
bool result = NumExist(arr, num);
Console.WriteLine(result ? "Да" : "Нет");
