Console.WriteLine("Введите день недели (1 - понедельник, 2 - вторник и т.д.):");
int dayOfWeek = int.Parse(Console.ReadLine());

if (dayOfWeek == 6 || dayOfWeek == 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
