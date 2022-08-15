// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).




Console.Clear();
Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string Quar(int q)
{
    if (q == 1) return "X>0, Y>0";
    if (q == 2) return "X<0, Y>0";
    if (q == 3) return "X<0, Y<0";
    if (q == 4) return "X>0, Y<0";
    return "Такой четверти не существует";
}
if (quarter > 0 && quarter <= 4) Console.Write($"Диапазон чисел для четверти {quarter} -> {Quar(quarter)}");
else Console.Write($"Четверти {quarter} не существует");