// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// С использованием Split String, с "поддержкой" вещественных чисел.
// Программа, конечно, работает. Но делает она это только при полностью позитивном взаимодействии.

string[] CreateStringArray(string str) // Создание массива на основе введенной строки.
{
    string[] numbersStringArray = str.Split(", ");
    return numbersStringArray;
}

double[] ArrayStringToDouble(string[] arr)
{
    double[] doubleTypeArray = new double[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        doubleTypeArray[i] = Convert.ToDouble(arr[i]);
    }
    return doubleTypeArray;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write(arr[i]);
    }
}

int PositiveNumCount(double[] numarr)
{
    int count = 0;
    for (int i = 0; i < numarr.Length; i++)
    {
        if (numarr[i] > 0) count += 1;
    }
    return count;
}

Console.WriteLine("Введите ряд чисел в формате: 1, 2, 4, 7, ....n");
string newstr = Console.ReadLine();
string[] strarr = CreateStringArray(newstr);

double[] newDoubleTypeArray = ArrayStringToDouble(strarr);
Console.WriteLine("\r\nВведенные числа:");
PrintArray(newDoubleTypeArray);
int result = PositiveNumCount(newDoubleTypeArray);
Console.WriteLine($" --> кол-во чисел больше нуля: {result}.");
