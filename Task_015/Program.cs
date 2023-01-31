// //Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Ввеlите цифру");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 7 || number < 1) Console.WriteLine("Некорректный ввод. Введите число от 1 до 7");
else 
{
    bool dayOff = DayOff(number);
    Console.WriteLine(dayOff ? "Да" : "Нет");
}

bool DayOff(int num)
{
    return (num == 6 || num == 7);
}



// bool DayOff(int num)
// {
//     return(num == 6 || num == 7);
// }

// bool dayOff = DayOff(number);
// Console.WriteLine(number > 7 || number < 1 ? Console.WriteLine(dayOff ? "Да": "Нет") : "Некорректный ввод. Введите число от 1 до 7");

// bool DayOff(int num)
// {
//     return(num == 6 || num == 7);
// }
