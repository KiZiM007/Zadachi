//  Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

//Первый вариант решения задачи:
// int random = new Random().Next(10, 100);
// Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {random}");

// int number1 = random / 10;
// int number2 = random % 10;

// if (number1 == number2) Console.Write($"В случайном числе {random} оба числа равны");
// else if (number1 < number2) Console.Write($"Наибольшая цифра случайного числа {random} -> {number2}");
// else Console.Write($"Наибольшая цифра случайного числа {random} -> {number1}");


//Решение задачи с использованием функции:
int random = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {random}");

int MaxNumber(int ran)
{
    int number1 = ran / 10;
    int number2 = ran % 10;
    if (number1==number2) return -1;
    return number1 > number2 ? number1 : number2;
}
int result = MaxNumber(random);
string res = result == -1 ? "Цифры одинаковые" : result.ToString();
Console.WriteLine($"Наибольшая цифра случайного числа {random} -> {res}");

