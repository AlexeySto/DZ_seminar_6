//  Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int GetNum(string messaeg)                       // Принимает число от пользователя
{
    Console.Write(messaeg);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

double[] GetIntersectionPoint(int k1, int b1, int k2, int b2)   // Находим точку пресечения прямых
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    double[] res = new double[2];
    res[0] = x;
    res[1] = y;
    return res;
}

int k1 = GetNum("k1 = ");
int b1 = GetNum("b1 = ");
int k2 = GetNum("k2 = ");
int b2 = GetNum("b2 = ");

if (k1 == k2 && b1 == b2) Console.WriteLine("Линии совпадают.");
else if (k1 == k2) Console.WriteLine("Линии паралельны.");
else 
{
    double[] intersectionPoint = GetIntersectionPoint(k1, b1, k2, b2);
Console.WriteLine($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} -> ({intersectionPoint[0]};{intersectionPoint[1]})");
}