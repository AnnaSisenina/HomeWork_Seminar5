// Написать программу копирования массива
void FillArray(int[] array, int from, int to)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(from, to);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}\t");
    Console.WriteLine();
}
int GetInt (string message)
{
    Console.WriteLine (message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int [] CopyArray (int [] originalArray)
{
    int [] copyArray = new int [originalArray.Length];
    for (int i = 0; i < originalArray.Length; i++)
    {
        copyArray[i]=originalArray[i];
    }
    return copyArray;
}

int length = GetInt("Введите размер массива: ");
int [] numbers = new int [length];
FillArray(numbers, 0, 10);
PrintArray(numbers);
int [] copyNumbers = CopyArray(numbers);
PrintArray(copyNumbers);