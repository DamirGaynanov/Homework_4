// Requrst for input data
Console.WriteLine("Enter the number");
string number = Console.ReadLine() ?? "";

// Processing of input data
int a = int.Parse(number);

// Decision
if (a % 2 == 0) Console.WriteLine("Введённое число чётное");
else Console.WriteLine("Введённое число нечётное");

// Console.WriteLine(a % 2 == 0 ? "Чётное" : "Не чётное"); - Вариант решения из инетренета