// Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет


Console.Write("Введите первое число:");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
int num2 = int.Parse(Console.ReadLine());

if (num2 == num1 * num1)
{
    Console.Write($"{num1} в квадрате ровняется {num2}");
}
else
{
    Console.Write($"{num1} в квадрате не ровняется {num2}");
}