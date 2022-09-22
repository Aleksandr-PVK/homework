//сравнение двух введённых чисел
Console.WriteLine("Введите два любые целые числа:");
int user_nam_A = int.Parse(Console.ReadLine());
int user_nam_B = int.Parse(Console.ReadLine());

if (user_nam_A > user_nam_B)
{
    Console.WriteLine("max = " + user_nam_A);
    Console.WriteLine("min = " + user_nam_B);
}
else if(user_nam_A < user_nam_B)
{
    Console.WriteLine("max = " + user_nam_B);
    Console.WriteLine("min = " + user_nam_A);
}
else 
{
    Console.WriteLine("Числа равны.");
}