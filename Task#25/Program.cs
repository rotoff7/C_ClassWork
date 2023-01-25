// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double NumberDegree(double num1, int num2)
{
    double result = Math.Pow(num1, num2);
    return result;
}

// Тут меня немного смущает, что все операции находятся внутри операторов if.
Console.Write("Введите число A: ");
double number1;
if (double.TryParse(Console.ReadLine(), out number1))
{
    Console.Write("Введите натуральное число B: ");
    int number2;
    if (int.TryParse(Console.ReadLine(), out number2) && number2 > 0) //Проверка на ввод не числовых значений и натуральность чисел.
    {
        double answer = Math.Round(NumberDegree(number1, number2), 3, MidpointRounding.AwayFromZero);
        Console.WriteLine($"Число {number1} в степени {number2} -> {answer}");
    }
    else Console.WriteLine("Введено некорректное значение числа B. Введите натуральное число.");
}
else Console.WriteLine("Введено некорректное значение числа A. Введите число.");