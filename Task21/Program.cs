// написать программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве

Console.WriteLine("Введите координаты первой точки (x1, y1, z1):");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки (x2, y2, z2):");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

double squareX = Math.Pow(x2 - x1, 2);
double squareY = Math.Pow(y2 - y1, 2);
double squareZ = Math.Pow(z2 - z1, 2);
double lenth = Math.Sqrt(squareX + squareY + squareZ);
lenth = Math.Round(lenth, 2);
Console.WriteLine($"расстояние между точками равно {lenth}");
