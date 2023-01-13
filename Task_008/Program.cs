// Requrst for input data
Console.WriteLine("Enter the number");
string number = Console.ReadLine() ?? "";

// Processing of input data
int a = int.Parse(number);
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