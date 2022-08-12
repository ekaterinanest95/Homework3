Console.Write("Введите координату Х точки А: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки A: ");
int Az = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Х точки B: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int By = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки B: ");
int Bz = Convert.ToInt32(Console.ReadLine());


double result = Math.Sqrt(Math.Pow(Ax-Bx,2) + (Math.Pow(Ay-By,2)) + (Math.Pow(Az-Bz,2)));
Console.WriteLine($"Расстояние: {Math.Round(result,2)}");