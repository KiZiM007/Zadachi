// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int size = 1;
// while (num >= size)
// {
//     Console.WriteLine($"{size}->{size * size}");
//     size ++;
// }


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int size = 1;
void Tabl(int number)
{
    while (num >= size)
    {
        Console.Write(size * size);
        size = size + 1;
    }
}
Console.WriteLine(Tabl(num));