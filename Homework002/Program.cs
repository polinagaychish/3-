// Напишите программу, которая принимает но вход координаты двух точек и находит расстояние мужду ними в 
// 3D простраснстве.
Console.Clear();

Console.Write("Введите координату x: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату z: ");
int z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату x: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату z: ");
int z2 = int.Parse(Console.ReadLine()!);




double result = Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)+Math.Pow((z1-z2),2));
result = Math.Round(result,2);
Console.WriteLine($"Расстояние между точками {result}");
