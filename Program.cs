// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int num = 0;
int sum = 0;
for (int i = num; n > 0; sum += n % 10, n /= 10);
 Console.WriteLine($"сумма цифр {sum}");