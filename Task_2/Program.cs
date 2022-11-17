// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt(string message) // Ввод числа
{
    Console.Write(message);
    double number = Double.Parse(Console.ReadLine());
    return number;
}

double b1 = Prompt("Введите значение уравнения b1: ");
double k1 = Prompt("Введите значение уравнения k1: ");
double b2 = Prompt("Введите значение уравнения b2: ");
double k2 = Prompt("Введите значение уравнения k2: ");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
// double y = k2 * x + b2;

Console.Write($"Точка пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 -> ({x:f2} ; {y:f2})");