// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber > 0 && dayNumber < 8)
{
    if (dayNumber != 6 && dayNumber != 7)
    {
        Console.WriteLine($"День недели {dayNumber} не является выходным");
    }
    else
    {
        Console.WriteLine($"День недели {dayNumber} является выходным");
    }
}
else
{
    Console.WriteLine($"Дня недели под номером {dayNumber} нет");
}