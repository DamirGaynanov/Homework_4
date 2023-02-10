// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Ввкдите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 100000 | number < 10000)
{
    Console.WriteLine("Введено некорректное число. Введите пятизначное число");
}
else
{
    bool polindrome = Polindrome(number);
    Console.WriteLine(polindrome ? $"{number} -> Да" : $"{number} -> Нет");
}


bool Polindrome(int num)
{
    int digit1 = num / 10000;
    int digit2 = num / 1000 - (num / 10000) * 10;
    int digit4 = (num % 100 - (num % 10)) / 10;
    int digit5 = num % 10;
    return ((digit1 == digit5) && (digit2 == digit4));
}

// Альтернативное решение

// int number = int.Parse(Console.ReadLine());
// int pal = 0;
// int num = number;
// while (number > 0)
// {
// pal = pal * 10 + number % 10;
// number /= 10;
// }
// Console.WriteLine(num == pal ? "палиндром" : "не палиндром");