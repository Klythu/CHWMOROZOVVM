// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int evnev = number%2;
if (evnev ==0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
