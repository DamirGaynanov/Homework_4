// Задача 34: 
// Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] arr = CreateArray(5);
PrintArray(arr);
Console.WriteLine($" -> {EvenNumber(arr)}");

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i< array.Length-1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int EvenNumber(int[] array)
{
    int count = array.Length;
    int countnum = 0;
    for (int i = 0; i < count; i++)
    {
        if (array[i] % 2 == 0) countnum = countnum + 1;
    }
    return countnum;
}