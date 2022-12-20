// Задача 10: Напишите программу, которая 
// принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число: {number}");

int showSecondDigit = ShowSecondDigit(number);
Console.WriteLine ($"{number} -> {showSecondDigit}");

int ShowSecondDigit(int num)
{
    int result = (num / 10) % 10;
    return result;
}