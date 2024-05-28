// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }


// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
// Console.WriteLine("Введите координату X");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x > 0 && y > 0)
// {
//     Console.WriteLine("1");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("4");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("3");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("2");
// }
// else
// {
//     Console.WriteLine("Координаты не подходят");
// }

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Console.WriteLine("Введите двухзначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 10 && number <= 99)
// {
//     int firstDigit = number / 10;
//     int secondDigit = number % 10;
//     if (firstDigit > secondDigit)
//     {
//         Console.WriteLine(firstDigit);
//     }
//     else
//     {
//         Console.WriteLine(secondDigit);
//     }
// }
// else
// {
//     Console.WriteLine("Число не подходит");
// }

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
using System.ComponentModel;

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int divider = 1;
while (number / divider >= 10)
{
    divider *= 10;
}
int digit = number / divider;
while (divider > 1)
{
    digit = number / divider;
    Console.Write($"{digit}, ");
    number %= divider;
    divider /= 10;
}
digit = number / divider;
Console.Write(digit);