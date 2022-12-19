//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

int [] CreateArray()
{
    int [] array = new int[10];
    Console.WriteLine();
    Console.Write("[");
    for(int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($" {array[i]}");
    }
    Console.WriteLine(" ]");
    return array;
}

void ShowEvenNumbers(int [] CreateArray)
{
    int count=0;
    for (int i = 0; i < CreateArray.Length; i++)
    {
        if(CreateArray[i]%2==0)
        count++;
    }
Console.WriteLine($"Количество четных чисел в массиве = {count}");
Console.WriteLine();
}

ShowEvenNumbers(CreateArray());