// написать программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
string numberString = number.ToString();
if (number > 9999 && number <= 99999)
    {
    if (numberString[0] == numberString[numberString.Length - 1] && numberString[1] == numberString[numberString.Length - 2])
        {
            Console.WriteLine("данное число является палиндромом.");
        }
    else
        {
            Console.WriteLine("данное число не является палиндромом.");
        }
    }
else
    
    Console.WriteLine("Введенное число не является пятизначным.");
