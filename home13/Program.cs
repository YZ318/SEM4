Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

if (number < 100 || number > 999)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    int thirdDigit = (number % 100) % 10;
    Console.WriteLine("Третья цифра введенного числа: " + thirdDigit);
}