// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98




// int random = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {random}");
// int Metod(int ran)
// {
// int number1 = ran / 100;
// int number3 = ran % 10;
// return number1*10+number3;
// }
// Console.Write($"Число {random} без средней цифры -> {Metod(random)}");




int random = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {random}");
int Metod(int ran)
{
int number1 = ran / 100;
int number3 = ran % 10;
return number1*10+number3;
}
Console.Write($"Число {random} без средней цифры -> {Metod(random)}");

