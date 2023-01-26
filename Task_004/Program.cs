// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Requrst for input data
Console.WriteLine("Enter the first number");
string num_1 = Console.ReadLine() ?? "";
Console.WriteLine("Enter the second number");
string num_2 = Console.ReadLine() ?? "";
Console.WriteLine("Enter the third number");
string num_3 = Console.ReadLine() ?? "";

// Processing of input data

int a = int.Parse(num_1);
int b = int.Parse(num_2);
int c = int.Parse(num_3);

// Decision
int num_max = a;

if (b > num_max)
{
    num_max = b;
}
if (c > num_max)
{
    num_max = c;
}

Console.WriteLine("max=" + num_max);