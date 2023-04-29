// Расстояние между точками в 3D пространстве

double dist2D(double x1, double x2, double x3, double y1, double y2, double y3, double z1, double z2, double z3)
{
    return Math.Round(Math.Sqrt(Math.Pow(x1 - x2 - x3, 2) + Math.Pow(y1 - y2 - z2, 2) + Math.Pow(z1 - z2 - z3, 2)), 2);
}

System.Console.WriteLine("Введите координаты точки А по оси X: ");
double x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки А по оси Y: ");
double y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки А по оси Z: ");
double z1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки B по оси X: ");
double x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки B по оси Y: ");
double y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки B по оси Z: ");
double z2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки С по оси X: ");
double x3 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки С по оси Y: ");
double y3 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки С по оси Z: ");
double z3 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(dist2D(x1, y1, z1, x2, y2, z2, x3, y3, z3));

