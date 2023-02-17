// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = CreateArrayRndInt(5, -100, 100);
PrintArray(array);
Console.WriteLine($" -> {SumNum(array)}");

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
            else Console.Write($"{arr[i]}");
        }
        
    Console.Write("]");
}

int SumNum(int[] arr)
{
    int sum = 0;
    int j = 1;
    while (j < arr.Length)
    {
        sum = sum + arr[j];
        j = j+2;
    }
    return sum;
}