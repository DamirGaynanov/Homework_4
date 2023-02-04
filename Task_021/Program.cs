// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату точки А по оси Х: ");
double ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки А по оси Y: ");
double ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки А по оси Z: ");
double az = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки B по оси Х: ");
double bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B по оси Y: ");
double by = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B по оси Z: ");
double bz = Convert.ToInt32(Console.ReadLine());


double distance = Distance (ax, ay, az, bx, by, bz);
Console.WriteLine($"A ({ax}, {ay}, {az}); B ({bx}, {by}, {bz}) -> {Math.Round(distance, 2, MidpointRounding.ToZero)}");

// Метод
double Distance(double x1 , double y1, double z1, double x2 , double y2, double z2)
{
    double dist = Math.Sqrt((Math.Pow(x2-x1,2))+(Math.Pow(y2-y1,2))+(Math.Pow(z2-z1,2)));
    return dist;
}