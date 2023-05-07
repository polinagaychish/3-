// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел  от 1 до N
Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int count = 1;

Console.Write($"{Math.Pow(count,3)}");
count++;
while (count <=N)
{
    double result = Math.Pow(count, 3);
Console.Write($", {result}");
count++;
}
