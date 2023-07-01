// Назовём число «интересным» если его произведение цифр делится на их сумму БЕЗ остатка. Напишите программу, которая заполняет массив на 10 «интересных» случайных
//целых чисел от 10 до 1000(999 - последнее). (каждый эл-т массива – сгенерирован случайно)
// Пример для 1 элемента массива: 591, сумма: 5+9+1 = 15; произведение: 5*9*1 = 45; 45 / 15 - делится НАЦЕЛО, число "интересное"
// [591, 532, 189, 523, 333, 546, 527, 275, 456, 264]

int[] array = new int[10];
int index = 0;
while (index < 10)
{
    while (true)
    {
        int newNumber = new Random().Next(10, 1000);
        
        int firstDigit = 0;
        int secondDigit = 0;
        int thirdDigit = 0;


        if (newNumber > 99)
        {
            firstDigit = newNumber / 100;
            secondDigit = (newNumber / 10) % 10;
            thirdDigit = newNumber % 10;
        }
        else
        {
            firstDigit = newNumber / 10;
            secondDigit = newNumber % 10;
        }

        int product = firstDigit * secondDigit * thirdDigit;
        int sum = firstDigit + secondDigit + thirdDigit;
        if (product == 0)
        {
            continue;
        }

        if (product % sum == 0)
        {
            array[index] = newNumber;
            break;
        }
    }
    index++;
}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(array[i]);
}