Console.Write("Введите число от 1 до 7 ");
int a = Convert.ToInt32(Console.ReadLine()); 
Fun(a);

void Fun(int a)
{
if (a>=1 && a<=5)
    {
    Console.Write($"{a} --> Нет");
    }
else if(a>=6 && a<=7)
    {
     Console.WriteLine($"{a} --> Да");
    }  
 else 
    Console.WriteLine("Введите число от 1 до 7!!!");
}
