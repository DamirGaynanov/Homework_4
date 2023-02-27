// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

//____________________________________________________________________

// double[] numbers = new double[5];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// void FillArrayRandomNumbers(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
//     }
// }

// void PrintArray(double[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]}; ");
//         else Console.Write($"{array[i]}");
//     }
//     Console.Write("]");
// }

//___________________________________________________________________
Console.WriteLine("Введите длину массива");
int num = Convert.ToInt32(Console.ReadLine());

double[] array = CreateArrayDouble(num);
PrintArray(array);

double maximum = Maximum(array);
double minimum = Minimum(array);
double SumMaxMin = maximum + minimum;
Console.WriteLine(SumMaxMin);


double[] CreateArrayDouble(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(Convert.ToDouble(rnd.Next(100, 1000)) / 100, 1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
            else Console.Write($"{arr[i]}");
        }
    Console.Write("] -> ");
}

double Maximum(double[] arry)
{
    double max = arry[0];
    for (int j = 1; j < arry.Length; j++)
    {
        if (arry[j] > max) 
        {
            max = arry[j];
        }
    }
    return max;
}

double Minimum(double[] arr)
{
    double min = arr[0];
    for (int k = 1; k < arr.Length; k++)
    {
       
        if (arr[k] < min) 
        {
            min = arr[k];
        }
    }
    return min;
}

