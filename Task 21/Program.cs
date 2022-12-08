
double Fun(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double length = Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2) + (z1-z2)*(z1-z2));
    return length;
}


Console.WriteLine("Введите координаты первой точки ");
int x1 = Convert.ToInt32(Console.ReadLine()); 
int y1 = Convert.ToInt32(Console.ReadLine()); 
int z1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координаты второй точки ");
int x2 = Convert.ToInt32(Console.ReadLine()); 
int y2 = Convert.ToInt32(Console.ReadLine()); 
int z2 = Convert.ToInt32(Console.ReadLine()); 


double res = Fun(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Длина отрезка = {Math.Round(res, 2)}");