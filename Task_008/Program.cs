// Requrst for input data
Console.WriteLine("Enter the number");
string num = Console.ReadLine() ?? "";

// Processing of input data
int a = int.Parse(num);
int b = 1;
// Decision
while (b < a)
{
    if (b < a)
    {
        if (b % 2 == 0) Console.Write(b + " ");
    }

    else Console.Write(b);
    b = b + 1;
}