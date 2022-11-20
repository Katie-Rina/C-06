// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void CrossPoint(double k1, double b1, double k2, double b2)
{
    if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают, точек пересечения бесконечно много");
    else
    {
        if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые параллельны, точек пересечения нет");
        else
        {
            double x0 = (b2 - b1) / (k1 - k2);
            double y0 = k1 * x0 + b1;
            Console.WriteLine($"Прямые пересекаются в точке ({x0};{y0})");
        }
    }
}

Console.Clear();
Console.Write("Введите k1, b1, k2 и b2 через пробел: ");
string arr = Console.ReadLine();
string[] nums = arr.Split(" ", StringSplitOptions.RemoveEmptyEntries);
double k1 = Convert.ToDouble(nums[0]);
double b1 = Convert.ToDouble(nums[1]);
double k2 = Convert.ToDouble(nums[2]);
double b2 = Convert.ToDouble(nums[3]);
CrossPoint(k1, b1, k2, b2);





