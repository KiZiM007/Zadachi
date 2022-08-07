// Напишите программу, которая:
//1 на вход принимает число
//2 выдаёт его квадрат 
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите целое число:");
int num = int.Parse(Console.ReadLine());
int square = num * num;
Console.Write($"Квадрат числа {num} = {square}");

