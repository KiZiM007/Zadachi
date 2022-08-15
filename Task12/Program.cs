// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21



Console.Clear();
Console.WriteLine("Введите координаты первой точки");
Console.Write("Координата по оси X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата по оси Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("Координата по оси X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата по оси Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

int Pifagor(int xx1, int yy1, int xx2, int yy2)
{
    int cat1 = xx1 - xx2;
    int cat2 = yy1 - yy2;
    return cat1 * cat1 + cat2 * cat2;
}
double result = Math.Sqrt(Pifagor(x1, y1, x2, y2)); //Math.Sqrt-высчитывает корень из числа
Console.Write(Math.Round(result, 2, MidpointRounding.ToZero)); //Math.Round - округляет число. MidpointRounding.ToZero - чтобы отображался 0

