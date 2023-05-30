// // // написать прогу, которая принимает на вход два числа X и Y (не равных нулю) и определяет
// // // в какой четверти находится плоскости координат находится точка. 
// // // 1. принять на вход дыа числа X и Y
// // // 2. проверить два числа не равных нулю 
// // // 3. проверить четверть наших координат
// // // 4. вывод

// // int[] points = new int[2];
// // Console.WriteLine("введите координаты");
// // for (int i = 0; i < points.Length; i++)
// // {
    
// //     points[i] = Convert.ToInt32(Console.ReadLine()); // считывать с клавиатуры и конвертировать сразу
// //     //points[i] = new.Random().Next(-10 , 10); // выводятся рандомно из данного диапазона
// //     /*if (points[i] == 0)
// //     {
// //         Console.WriteLine("координата равна вулю");
// //         break;
        
// //     }*/

// // }

// // if (points[0] > 0 && points[1] > 0)
// // {
// //     Console.WriteLine("координаты находятся в 1й четверти");

// // }
// // else if (points[0] < 0 && points[1] > 0)
// // {
// //     Console.WriteLine("координаты находятся во 2й четверти");
    
// // }
// // else if (points[0] < 0 && points[1] < 0)
// // {
// //     Console.WriteLine("координаты находятся в 3й четверти");
    
// // }

// // else if (points[0] > 0 && points[1] < 0)
// // {
// //     Console.WriteLine("координаты находятся в 4й четверти");
    
// // }

// // else 
// // {
// //     Console.WriteLine("одна из координат равна нулю");
// // }


// //написать прогу, которая по заданному номеру четверти показывает 
// //диапазон возможных координат в этой четверти


// Console.WriteLine("введите четверть координат");
// int quater = Convert.ToInt32(Console.ReadLine());
// if (quater == 1)
// {
//     Console.WriteLine("X > 0, Y > 0");

// }
// else if (quater == 2)
// {
//     Console.WriteLine("X < 0, Y > 0");
// }
// else if (quater == 3)
// {
//     Console.WriteLine("X < 0, Y < 0");
// }
// else if (quater == 4)
// {
//     Console.WriteLine("X > 0, Y < 0");
// }

// else
// {
//     Console.WriteLine("такой четверти нет");
// }


// // написать прогу,которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N

// Console.WriteLine("введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"квадраты числа от 1 до  {number}");
// for (int i = 1; i <=number ; i++)

// {
//     Console.Write($" {i * i} ");
// }
// Console.WriteLine();


// эта же задача через массив

// Console.WriteLine("введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"квадраты числа от 1 до  {number}");
// string text = "";
// int[] numbers = new int[number];
// for (int i = 0; i < numbers.Length ; i++)
// {
//     numbers[i] = ( i + 1 ) *( 1 + i );
//     Console.WriteLine(numbers[i]);
// }


// написать прогу,которая принимает на вход координаты двух точек 
// и расчитывает расстояние между ними в 2 D

Console.WriteLine("Введите координаты первой точки (x1, y1):");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки (x2, y2):");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());

double squareX = Math.Pow(x2 - x1, 2);
double squareY = Math.Pow(y2 - y1, 2);
double lenth = Math.Sqrt(squareX + squareY);
lenth = Math.Round(lenth, 2);
Console.WriteLine($"расстояние между точками равно {lenth}");








