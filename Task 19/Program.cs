
void Fun(int x)
{
    if(x/10000 == x%10 && x%10000/1000 == x%100/10)
        Console.WriteLine("Да, является");
    else
        Console.WriteLine("Нет, не является");
} 

Console.WriteLine("Введите пятизначное число ");
int x = Convert.ToInt32(Console.ReadLine());

Fun(x);