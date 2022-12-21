// Задача 15: Напишите программу, которая 
// принимает на вход цифру, 
// обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 7 || number < 1)
Console.WriteLine($"{number} не соответствует дню недели");
else
{
    Console.WriteLine(DayOffNumber(number) ? $"{number} -> Да" : $"{number} -> Нет");

    bool DayOffNumber(int dayOffNum)
    {
        return dayOffNum == 6 || dayOffNum == 7;
    }
}
