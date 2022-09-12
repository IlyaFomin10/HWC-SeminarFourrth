// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы массива вводятся пользователем.
int[] GetArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void PrintArrayToConsole(int[] array)
{
    Console.Write("int[] array = {");
    Console.Write($"{array[0]},");
    for (int i = 1; i < array.Length - 1; i++)
    {
        Console.Write($" {array[i]},");
    }
    Console.Write($" {array[7]}");
    Console.Write("}");
}

Console.WriteLine("Введите подряд восемь чисел, чтобы заполнить массив:");
int[] array = GetArray();
PrintArrayToConsole(array);