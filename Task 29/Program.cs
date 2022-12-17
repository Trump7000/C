
int[] Gen()
{
    int n = new Random().Next(0,100);
    int [] arr = new int [n];
    for(int i = 0; i < arr.Length; i++)
        {
        arr[i]= new Random().Next(0,10);
        }
    return arr;
}

void Show(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
        {
        Console.Write($" {arr[i]}");
        }
    Console.Write(" ]");
}

Show(Gen());
