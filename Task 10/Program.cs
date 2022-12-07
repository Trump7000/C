

Console.Write("Введите трехзначное число ");
int a = Convert.ToInt32(Console.ReadLine()); 
Fun(a);

void Fun(int a)
{
        if (a>=100 && a<1000 )
        {
            Console.WriteLine($"Ваше число {a}");
            int result = a%100/10;
            Console.WriteLine($"Вторая цифра {result}");
        }
        else if (a<=-100 && a>-1000)
        {
            Console.WriteLine($"Ваше число {a}");
            int result = (a%100/10)*-1;
            Console.WriteLine($"Вторая цифра {result}");
        }
        else 
            Console.WriteLine($"Число {a} не трехзначное");
}
