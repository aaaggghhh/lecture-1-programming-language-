// See https://aka.ms/new-console-template for more information
int[] CreateArray(int size, int minValue, int MaxValue)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, MaxValue);
    }
    return array;
}

int[] chengznak(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
         array[i] = - array[i];
        
        return array;
    }
}

int[] vivodMassiv(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
         Console.WriteLine(array[i]);
        
        return array;
    }
}
Console.WriteLine("введите колличество элементов в массиве");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("введите начальное значение");
int minValue = int.Parse(Console.ReadLine());
Console.WriteLine("введите конечное значение");
int MaxValue = int.Parse(Console.ReadLine());
vivodMassiv(CreateArray(size, minValue, MaxValue));


