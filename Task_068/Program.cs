// Задача 68: 
// Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
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


Console.Write("Введите нижнюю границу диапазона M=");
int numberM = UserInput();
Console.Write("Введите верхнюю границу диапазона N=");
int numberN = UserInput();
Console.WriteLine($"m = {numberM}, n = {numberN} -> A({numberM},{numberN}) = {FuncAkerman(numberM, numberN)}");

int FuncAkerman(int numM, int numN)
{
    if (numM == 0) return (numN + 1);
    if (numM != 0 && numN == 0) return FuncAkerman(numM - 1, 1);
    if (numM > 0 && numN > 0) return FuncAkerman(numM - 1, FuncAkerman(numM, numN - 1));

return FuncAkerman(numM, numN);
}