// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

int [] CreateArray()
{ 
    int size = new Random().Next(6,20);
    while(size%2!=0)
    {
    size = new Random().Next(6,20);
    }
    int [] array = new int[size];
    Console.WriteLine();
    Console.Write("[ ");
    for(int i=0; i<array.Length; i++)
        {
        array[i] = new Random().Next(0, 10);
        Console.Write($"{array[i]} ");
        }
    Console.WriteLine("]");
    return array;
}

void ShowСouples(int [] CreateArray)
{
    int [] arreyTwin = Enumerable.Reverse(CreateArray).ToArray();
    Console.Write("Произведение пар чисел -> ");
    for (int i = 0; i < CreateArray.Length/2; i++)
        {
            int a = CreateArray[i]*arreyTwin[i];
            Console.Write($"{a} ");
        }   
}
  
ShowСouples(CreateArray());
