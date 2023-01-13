// Блок запроса входных данных
Console.WriteLine("Enter the first number_");
string number1 = Console.ReadLine() ?? "";
Console.WriteLine("Enter the second number_");
string number2 = Console.ReadLine() ?? "";

// Блок подготовительный (перевод строки в число)
int a = int.Parse(number1);
int b = int.Parse(number2);

// Блок операции (условие-сравнение двух чисел)
if (a > b)
{
    Console.WriteLine("max=" + a);
}
else
{
    Console.WriteLine("max=" + b);
}