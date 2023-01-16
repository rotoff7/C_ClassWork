// Напишите программу, которая принимает на 
// вход трехзначное число и на выходе 
// показывает последнюю цифру этого числа.


Console.Write("Введите любое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>=100 & number <=999 || number>=-999 & number <=-100)
{
Console.Write("Последняя цифра данного числа - ");
Console.WriteLine(number % 10);
}
else
Console.Write("Введено некорректное число");
