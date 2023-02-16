//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine($"Введи число");
string number = Console.ReadLine();

if(number.Length < 3)
{
    Console.Write($"Третьей цифры нет!");
}
else
{
    Console.WriteLine(number[2]);
}