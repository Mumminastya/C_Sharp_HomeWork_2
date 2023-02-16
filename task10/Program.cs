// See https://aka.ms/new-console-template for more information
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1


Console.WriteLine($"Введи трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int digit = number/10 % 10;

if(number < 100 || number >= 1000)
{
    Console.Write($"Это не трехзначное число!");
}
else
{
Console.Write($"Второе число: {digit}");
}