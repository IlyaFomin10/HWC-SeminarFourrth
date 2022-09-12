// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SumNumInside(int num)
{
    num = Math.Abs(num);
    int arg1 = 0;
    int result = 0;
    while(num > 0)
    {
        arg1 = num % 10;
        num = num / 10;
        result = result + arg1;
    }
    return result;
}

Console.WriteLine("Введите число : ");
int number = int.Parse(Console.ReadLine());
int result = SumNumInside(number);
Console.WriteLine($"Сумма чисел внутри числа {number} равна {result}");