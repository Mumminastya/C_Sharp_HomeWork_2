//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот
//день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine($"Введи день недели цифрой");
int day = Convert.ToInt32(Console.ReadLine());

if(day == 6 || day == 7)
{
    Console.Write($"Это выходной!");
}
else if(day <= 5)
{
    Console.Write($"Иди на работу!))");
}
else
{
    Console.Write($"В неделе семь дней!");
}