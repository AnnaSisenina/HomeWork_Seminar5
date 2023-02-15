// Написать программу масштабирования фигуры
void PrintArray (int [] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2==0)
        Console.Write ($"x = {array[i]}\t");
        else 
        Console.WriteLine ($"y = {array[i]}\t");
    }
    Console.WriteLine();
}
int ReadInt(string message)
{
    Console.WriteLine (message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int apex=ReadInt("Введите колличество вершин фигуры");

int [] coordinates=new int [apex*2];
Console.WriteLine ("Задайте координаты вершин фигуры:");
for (int i = 0; i < coordinates.Length; i++)
coordinates[i]=int.Parse(Console.ReadLine()!);

int k=ReadInt("Задайте коэффициент масштабирования: ");

for (int i = 0; i < coordinates.Length; i++)
coordinates[i]=coordinates[i]*k;
Console.WriteLine("Координаты фигуры с учетом масштабирования: ");
PrintArray(coordinates);