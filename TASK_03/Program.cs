// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели:  ");
int num = int.Parse(Console.ReadLine());
if (num >= 1 && num <= 5)
{
    Console.WriteLine("Это рабочий день");
}
else if (num >= 6 && num <= 7)
{
    Console.WriteLine("Это выходной день");
}
else Console.WriteLine("Не существует такого дня недели");
Console.WriteLine();