// Пересечение двух прямых


System.Console.WriteLine("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b1-b2)/(k2-k1);
double y = (k1*(b2-b1))/(k1-k2)+b1;

System.Console.WriteLine($"{x};{y}");