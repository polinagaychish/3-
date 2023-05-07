// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();

Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
int a = 0;
int sum = 0;

if (num > 9999 && num < 100000)
{
    for (a = num; num != 0; num = num / 10)
    {
        int b = num % 10;
        sum = sum * 10 + b;
    }
    if (a == sum)
{
    Console.WriteLine($"{a} является палиндромом");
}
    else
    {
        Console.WriteLine($"{a} не является палиндромом");
    }
}
else
{
    Console.WriteLine("Введено не пятизначное число");
}
