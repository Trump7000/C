Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine()); 
Fun(a);

void Fun(int a)
{
if (a>=100)
    {
    Console.WriteLine($"Ваше число {a}");
    int result = a%1000/100;
    Console.WriteLine($"Третья цифра {result}");
    }
else if(a<=-100)
    {
    Console.WriteLine($"Ваше число {a}");
    int result = (a%1000/100)*-1;
    Console.WriteLine($"Третья цифра {result}");
    }  
else 
    Console.WriteLine($"Третьей цифры нет");
}
