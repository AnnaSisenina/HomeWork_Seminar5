// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

int ReadInt (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int k1 = ReadInt("Введите значение k1 для первой прямой: ");
int b1 = ReadInt("Введите значение b1 для первой прямой: ");
int k2 = ReadInt("Введите значение k2 для первой прямой: ");
int b2 = ReadInt("Введите значение b2 для первой прямой: ");

double x = (double)(b2-b1)/(k1-k2);
double y1=k1*x+b1;
double y2=k2*x+b2;

Console.WriteLine($"Координаты точки пересечения двух прямых, заданных уравнениями (y={k1}*x+{b1}) и (y={k2}*x+{b2}), - ({x}, {y1})");
