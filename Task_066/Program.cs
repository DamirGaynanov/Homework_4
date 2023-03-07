// Задача 66: 
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N. Выполнить с помощью рекурсии.

// Например:
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите нижнюю границу диапазона M=");
int numberM = UserInput();
Console.Write("Введите верхнюю границу диапазона N=");
int numberN = UserInput();
int numexp1 = 0;
int numexp2 = 0;
if (numberM > numberN) 
{
    numexp1 = numberN;
    numexp2 = numberM;
}
else 
{
    numexp1 = numberM;
    numexp2 = numberN;
}

SumNaturalNumber(numexp1, numexp2, 0);

void IncorrectValue()
{
    Console.WriteLine("Введено некорректное значение");
    Environment.Exit(0);
}

int UserInput()
{
    if (!int.TryParse(Console.ReadLine(), out int temp)) IncorrectValue();
    return temp;
}

void SumNaturalNumber(int num1, int num2, int sum)
{
    if (num1 > num2)
    {
        Console.WriteLine($"M={numberM}; N={numberN} -> {sum}");
        return;
    }
    sum = sum + (num1++);
    SumNaturalNumber(num1, num2, sum);
}
