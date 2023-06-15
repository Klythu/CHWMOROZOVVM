// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("введите число ");
int num= Convert.ToInt32(Console.ReadLine());
int secondDig=(num%100)/10;
Console.WriteLine($"{secondDig} второй разряд");