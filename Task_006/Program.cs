﻿// Requrst for input data
Console.WriteLine("Enter the number");
string num = Console.ReadLine() ?? "";

// Processing of input data
int a = int.Parse(num);

// Decision
if (a % 2 == 0) Console.WriteLine("Введённое число чётное");
else Console.WriteLine("Введённое не является чётным");

// Console.WriteLine(a % 2 == 0 ? "Чётное" : "Не чётное"); - Вариант решения из инетренета