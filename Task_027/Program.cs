// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int number;
if (int.TryParse(Console.ReadLine(), out number))
    if (number > 0)
    {
        int sumdigit = SumDigit(number);
        Console.WriteLine(sumdigit);
    }
    else
    {
        Console.WriteLine("Введено некорректное значение. Введите натуральное число");
    }
else Console.WriteLine("Введено некорректное значение. Введите натуральное число");


// Метод
int SumDigit(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}