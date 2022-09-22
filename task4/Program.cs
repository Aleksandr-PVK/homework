// сравнить три введённых числа
Console.WriteLine("Введите три любые целые числа");
int user_nam_A = int.Parse(Console.ReadLine());
int user_nam_B = int.Parse(Console.ReadLine());
int user_nam_C = int.Parse(Console.ReadLine());
int max = user_nam_A;

if (user_nam_B > max)
{
    max = user_nam_B;
}
if (user_nam_C > max)
{
    max = user_nam_C;
}
Console.WriteLine("максимальное число " + max);