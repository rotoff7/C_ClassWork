// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Без использования Split String, с "поддержкой" вещественных чисел и проверками введенных данных.

double[] UserNumCreateArray(int size) // Создание массива на основе введенных чисел
{
    double[] numbersArray = new double[size];
    double temp; //Для проверки введенного числа.
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1}-е число: "); //Надеюсь тут допускается вывод информации в консоль.
        if (double.TryParse(Console.ReadLine(), out temp))
            numbersArray[i] = temp;
        else
        {
            Console.WriteLine("Введено некорректное значение");
            Environment.Exit(0);
            //Искал способ остановить работу программы, если ввести некорректное значение
            //Break не подходил, поэтому нашел в интернете такой способ.
        }
    }
    return numbersArray;
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
        if (numarr[i] > 0) count +=1;
    }
    return count;
}

Console.WriteLine("Сколько чисел хотите ввести?");
int quantity;
if (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
{
    double[] array = UserNumCreateArray(quantity);
    Console.WriteLine("\r\nВведенные числа:");
    PrintArray(array);
    int result = PositiveNumCount(array);
    Console.WriteLine($" --> кол-во чисел больше нуля: {result}.");
}
else Console.WriteLine("Введено некорректное значение.");