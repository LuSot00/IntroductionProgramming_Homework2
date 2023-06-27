// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. До 10 символов
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите число (до 10 символов): ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1000000000 && number > -100000000)
{
    if (number >= -99 && number <= 99)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        if (number > 99)
        {
            int temp = number;
            int divider = 1;
            while (temp > 99)
            {
                divider = divider * 10;
                temp = temp / 10;
            }
            int thirdDigit = (number / (divider / 10)) % 10;
            Console.WriteLine($"Третья цифра числа {number} --> {thirdDigit}");
        }
        if (number < -99)
        {
            number = number * -1;
            int temp = number;
            int divider = 1;
            while (temp > 99)
            {
                divider = divider * 10;
                temp = temp / 10;
            }
            int thirdDigit = (number / (divider / 10)) % 10;
            Console.WriteLine($"Третья цифра числа -{number} --> {thirdDigit}");
        }
    }
}
else
{
    Console.WriteLine("В числе более 10 символов");
}

