// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

int num, count, numDigit;
Boolean begin = true;
Console.Write("Введите любое число: ");
num = Convert.ToInt32(Console.ReadLine());
numDigit = NumberDigit(num);
if (numDigit <= 2)
{
    Console.WriteLine($"Третьей цифры в числе {num} нет  ");
}
else
{
    if (numDigit > 3)
    {
        num = num / Convert.ToInt32(Math.Pow(10, numDigit - 3));
    }
    num = num % 10;
    Console.WriteLine($"Третья цифра введённого числа: {num}");
}
int NumberDigit(int number)
{
    count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}
Console.WriteLine();

