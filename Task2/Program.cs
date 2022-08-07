// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
Console.Write("Введите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine());
if (num == 1)
{
    Console.Write("Сегодня понедельник!");
}
else if (num == 2)
{
    Console.Write("Сегодня вторник!");
}
else if (num == 3)
{
    Console.Write("Сегодня среда!");
}
else if (num == 4)
{
    Console.Write("Сегодня четверг!");
}
else if (num == 5)
{
    Console.Write("Сегодня пятница!");
}
else if (num == 6)
{
    Console.Write("Сегодня суббота!");
}
else if (num == 7)
{
    Console.Write("Сегодня воскресенье!");
}
else
{
    Console.Write("Ошибка: ввели неверное значение, пожалуйста, введите число от 1 до 7: ");
}