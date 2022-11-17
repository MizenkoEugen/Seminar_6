// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message) // Ввод числа
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] CreateArray(int length) // Создание массива
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt("Введите целое число: ");
    }
    return array;
}

int Count(int[] array) // Количество чисел массива > 0
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] intArr) // Вывод массива
{
    Console.Write($"{intArr[0]}");
    for (int i = 1; i < intArr.Length; i++)
    {
        Console.Write($", {intArr[i]}");
    }
}

int len = Prompt("Введите длину массива: ");
int[] array = CreateArray(len);
PrintArray(array);
Console.WriteLine();
Console.Write($"Вы ввели {Count(array)} раз число больше нуля");
