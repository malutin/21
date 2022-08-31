// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
string getDistance()
{
    Console.Write("Введите координату X точки 1 ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Y точки 1 ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Z точки 1 ");
    int z1 = Convert.ToInt32(Console.ReadLine());    

    Console.Write("Введите координату X точки 2 ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Y точки 2 ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Z точки 2 ");    
    int z2 = Convert.ToInt32(Console.ReadLine());    
    double distanse = Math.Round(Math.Sqrt(Math.Pow(x1-x2, 2) +Math.Pow(y1-y2, 2)) +Math.Pow(z1-z2, 2), 2);
    return $"Расстояние между точками 1 и 2 в 3д пространстве {distanse}";
}
try
{
    Console.WriteLine(getDistance());
}
catch
{
    Console.WriteLine("Необходимо вводить координаты целыми числами");
}