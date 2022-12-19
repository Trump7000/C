// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int [] CreateArray()
{
    int [] array = new int[10];
    Console.WriteLine();
    Console.Write("[");
    for(int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
        Console.Write($" {array[i]}");
    }
    Console.WriteLine(" ]");
    return array;
}

void ShowSumOddElements(int [] CreateArray)
{
    int sum=0;
    for (int i = 1; i < CreateArray.Length; i=i+2)
    {
        sum=sum+CreateArray[i];
    }
    Console.WriteLine($"Cумму элементов, стоящих на нечётных позициях -> {sum}");
    Console.WriteLine();
}

ShowSumOddElements(CreateArray());