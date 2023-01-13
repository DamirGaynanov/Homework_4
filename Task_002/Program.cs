// Блок запроса входных данных
Console.WriteLine("Enter the first number_");
string num1 = Console.ReadLine() ?? "";
Console.WriteLine("Enter the second number_");
string num2 = Console.ReadLine() ?? "";

// Блок подготовительный (перевод строки в число)
int a = int.Parse(num1);
int b = int.Parse(num2);

// Блок операции (условие-сравнение двух чисел)
if (a > b)
{
    Console.WriteLine("max=" + a);
}
else
{
    Console.WriteLine("max=" + b);
}