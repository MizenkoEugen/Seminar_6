// Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов.
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов.
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

void FillArray(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            image[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            Console.Write($"{image[i, j]} ");
        }
        Console.WriteLine();
    }
}

int MaxArray(int[,] image) // Сумма максимумов.
{
    int tempMax1 = image[0, 0];
    int tempMax2 = image[1, 0];
    for (int i = 0; i <= image.GetLength(0); i++)
    {
        if (tempMax2 < image[1, i])
        {
            tempMax2 = image[1, i];
        }
        if (tempMax1 < image[0, i])
        {
            tempMax1 = image[0, i];
        }
    }
    return tempMax1 + tempMax2;
}

int MinArray(int[,] image) // Сумма минимумов.
{
    int tempMin1 = image[0, 0];
    int tempMin2 = image[1, 0];
    for (int i = 0; i <= image.GetLength(0); i++)
    {
        if (tempMin2 > image[1, i])
        {
            tempMin2 = image[1, i];
        }
        if (tempMin1 > image[0, i])
        {
            tempMin1 = image[0, i];
        }
    }
    return tempMin1 + tempMin2;
}

int[,] matrix = new int[2, 3];
FillArray(matrix);
PrintArray(matrix);
Console.Write($"Сумма максимумов: ");
Console.WriteLine(MaxArray(matrix));
Console.Write($"Сумма минимумов: ");
Console.WriteLine(MinArray(matrix));
Console.Write($"Разница сумм: ");
Console.WriteLine(MaxArray(matrix) - MinArray(matrix));