﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int thirsDigit = ThirdDigit(number);
Console.WriteLine(number > 100 ? $"{number} -> {thirsDigit}" : $"{number} -> третьей цифры нет");

// Method
int ThirdDigit(int num)
{
    int result = -1;
    while (num > 999)
    {
        num = num / 10;
    }
    result = num % 10;
    return (result);
}

