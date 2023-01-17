// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// int RandomNum = new Random().Next(10, 100);
// Console.WriteLine("Случайное число: " + RandomNum);
// int FirstDigit = RandomNum / 10;
// int SecondDigit = RandomNum % 10;
// if (FirstDigit > SecondDigit)
//     Console.Write("Наибольшая цифра случайного числа -> " + FirstDigit);
// else
//     Console.Write("Наибольшая цифра случайного числа -> " + SecondDigit);

// int result = FirstDigit > SecondDigit ? FirstDigit : SecondDigit;
// Console.Write("Наибольшая цифра случайного числа -> " + result);

int MaxDigit(int num)
{
    int FirstDigit = num / 10;
    int SecondDigit = num % 10;
    int result = FirstDigit > SecondDigit ? FirstDigit : SecondDigit;
    return (result);
}

int RandomNum1 = new Random().Next(10, 100);
Console.WriteLine("Случайное число: " + RandomNum1);
Console.WriteLine("Наибольшая цифра случайного числа -> " + MaxDigit(RandomNum1));

int RandomNum2 = new Random().Next(10, 100);
Console.WriteLine("Случайное число: " + RandomNum2);
Console.WriteLine("Наибольшая цифра случайного числа -> " + MaxDigit(RandomNum2));

int RandomNum3 = new Random().Next(10, 100);
Console.WriteLine("Случайное число: " + RandomNum3);
Console.WriteLine("Наибольшая цифра случайного числа -> " + MaxDigit(RandomNum3));

int RandomNum4 = new Random().Next(10, 100);
Console.WriteLine("Случайное число: " + RandomNum4);
Console.WriteLine("Наибольшая цифра случайного числа -> " + MaxDigit(RandomNum4));