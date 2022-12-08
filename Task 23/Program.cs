
void Cube(int N)
{
    for(int i=1; i <= N; i++)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
}

Console.Write("Введите N = ");
int N = Convert.ToInt32(Console.ReadLine());

Cube(N);