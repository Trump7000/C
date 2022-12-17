//Math.Round(res, 2)


//

Console.WriteLine("Введите число = ");
int a = Convert.ToInt32(Console.ReadLine());
Sum(a);

void Sum(int a)
{
    int sum=0;
    int figure =0;  
    while(a!=0)
        {
        figure = a%10;
        sum=sum+figure;
        a=a/10;
        }
    Console.WriteLine($"Сумма цифр = {sum}");
}
