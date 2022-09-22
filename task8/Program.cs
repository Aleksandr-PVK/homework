//программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Введите любое целое число:");
int user_nam = int.Parse(Console.ReadLine());
int x = 1;
    while (x < user_nam)
{
    if (x % 2 == 0)
    {
        Console.WriteLine(x);
    }
    int x = x + 1;
}
