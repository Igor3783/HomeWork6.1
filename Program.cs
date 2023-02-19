// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int InputInt(string message)
{
    Console.Write($"{message}");
    return int.Parse(Console.ReadLine());
}
int[] GenereteArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число{i + 1}:");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}
int PositiveNum(int[] number)
{
    int Positive = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i] > 0)
        {
            Positive++;
        }
    }
    return Positive;
}
void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item}\t");
    }
    Console.WriteLine();
}

int num = InputInt("Какое количество чисел хотите ввести: ");
int[] array = GenereteArray(num);
PrintArray(array);
int positiveCnt = PositiveNum(array);
Console.WriteLine($"Количество чисел больше 0: {positiveCnt}");