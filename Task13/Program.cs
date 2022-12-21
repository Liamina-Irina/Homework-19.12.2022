// Задача 13: Напишите программу, которая 
// выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int number = new Random().Next();
int count = number;
if (number < 100)
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}
else 
{
    while (count > 999)
    {
        count = count / 10;
    }
}
int showThirdDigit = ShowThirdDigit(count);
Console.WriteLine($"{number} -> {showThirdDigit}");
int ShowThirdDigit(int num)
    {
        int result = num % 10;
        return result;
    }