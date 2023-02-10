// Задача 25
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// Например
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A");
double number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
double number2 = Convert.ToInt32(Console.ReadLine());
double degree = Degree(number1, number2);
Console.WriteLine($"3^5 = {degree}");

// Метод
double Degree(double num1, double num2)
 {
    double result = Math.Pow(num1, num2);
    return result;
 }