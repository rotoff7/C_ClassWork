// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36

int SumNumbers(int num)
{
    int sum = 0; // Можно добавить проверку на отрицательное число
    for (int i = 0; i <= num; i++)
    {
        sum += i;
    }
    return (sum);
}

Console.WriteLine("Введите натуральное число: ");
int number;
if (int.TryParse(Console.ReadLine(), out number))
Console.WriteLine ($"Сумма всех цифр от 1 до {number} = {SumNumbers(number)}"); // Или сперва ответ из метода поместить в отдельную переменную.
else
Console.WriteLine("Введенное значение не является натуральным. Введите натуральное число.");