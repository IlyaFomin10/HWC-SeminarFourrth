//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Решить задачу с использованием методов.
int PowerNumber(int arg1, int power)
{
    int result = 1;
    for(int i=0; i < power; i++)
    {
        result = result * arg1;
    }
    return result;
}    

Console.WriteLine("Введите число возводимое в степень: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Введите степень числа: ");
int power = int.Parse(Console.ReadLine());

int result = PowerNumber(num, power);
Console.WriteLine($"Число {num} в степени {power} равно {result}");
