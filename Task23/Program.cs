// // написать программу, котроая принимает на вход число N
// // и выдает таблицу кубов от 1 до N

// Console.WriteLine("введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"квадраты числа от 1 до  {number}");
// for (int i = 1; i <=number ; i++)

// {
//      Console.Write($" {i * i * i} ");
// }
// Console.WriteLine();

// эта же задача через массив

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"квадраты числа от 1 до  {number}");
string text = "";
int[] numbers = new int[number];
for (int i = 0; i < numbers.Length ; i++)
{
    numbers[i] = ( i + 1 ) * ( 1 + i ) * ( 1 + i);
    Console.WriteLine(numbers[i]);
}