// программа, котрая определит чётное или нет введённое число
Console.WriteLine("Введите любое целое число:");
int user_nam = int.Parse(Console.ReadLine());

if (user_nam % 2 == 0)
{
    Console.WriteLine("Это число чётное!");
}
else
{
    Console.WriteLine("Это число не чётное!");
}