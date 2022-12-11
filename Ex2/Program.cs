/*
Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double b1 = ReadInt("Введите точку b1: ");
double k1 = ReadInt("Введите точку k1: ");
double b2 = ReadInt("Введите точку b2: ");
double k2 = ReadInt("Введите точку k2: ");

double x = Math.Round((b2 - b1) / (k1 - k2), 2);
double y = Math.Round(k1 * x + b1, 2); 

if (k1 != k2)
{
    Console.WriteLine($"Точка пересечения двух прямых -> ({x}; {y})");
}
else
{
    Console.WriteLine($"Прямые не пересекаются");
}

int ReadInt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}