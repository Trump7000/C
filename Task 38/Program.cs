// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
int [] CreateArray()
{
    int [] array = new int[10];
    Console.WriteLine();
    Console.Write("[");
    for(int i=0; i<array.Length; i++)
        {
        array[i] = new Random().Next(0, 100);
        Console.Write($" {array[i]}");
        }
    Console.WriteLine(" ]");
    return array;
}

void ShowDifferenceMaxMin(int [] CreateArray)
{
    int max = CreateArray[0];
    int min = CreateArray[0];
    for (int i = 1; i < CreateArray.Length; i++)
        {
        if(CreateArray[i]>max)
            max = CreateArray[i];  
        else if(CreateArray[i]<min)
            min = CreateArray[i];
        }
    Console.WriteLine($"Разница между максимальным и минимальным значением элементов -> {max-min}");
    Console.WriteLine();
}

ShowDifferenceMaxMin(CreateArray());
