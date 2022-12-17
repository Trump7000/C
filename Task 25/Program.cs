
void Row(int a, int b)
{
    int res = 1;
    for(int i=1; i<=b;i++)
    {
        res = res*a;
    }
Console.WriteLine($"Результат = {res}");
}

Console.WriteLine("Введите число = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень = ");
int b = Convert.ToInt32(Console.ReadLine());
Row(a,b);