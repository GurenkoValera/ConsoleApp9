using System;

class Program
{
    static void Main()
    {
        // Ввод коэффициентов системы уравнений
        Console.Write("Введите коэффициент a1: ");
        double a1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите коэффициент b1: ");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите коэффициент c1: ");
        double c1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите коэффициент d1: ");
        double d1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент a2: ");
        double a2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите коэффициент b2: ");
        double b2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите коэффициент c2: ");
        double c2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите коэффициент d2: ");
        double d2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент a3: ");
        double a3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите коэффициент b3: ");
        double b3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите коэффициент c3: ");
        double c3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите коэффициент d3: ");
        double d3 = Convert.ToDouble(Console.ReadLine());

        // Вычисление определителя системы уравнений
        double det = a1 * (b2 * c3 - b3 * c2) - b1 * (a2 * c3 - a3 * c2) + c1 * (a2 * b3 - a3 * b2);

        if (det == 0)
        {
            Console.WriteLine("Определитель системы уравнений равен 0. Решение не существует.");
            return;
        }

        // Вычисление неизвестных x, y, z
        double x = (d1 * (b2 * c3 - b3 * c2) - b1 * (d2 * c3 - d3 * c2) + c1 * (d2 * b3 - d3 * b2)) / det;
        double y = (a1 * (d2 * c3 - d3 * c2) - d1 * (a2 * c3 - a3 * c2) + c1 * (a2 * d3 - a3 * d2)) / det;
        double z = (a1 * (b2 * d3 - b3 * d2) - b1 * (a2 * d3 - a3 * d2) + d1 * (a2 * b3 - a3 * b2)) / det;

        // Вывод результата
        Console.WriteLine("Решение системы уравнений:");
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);
        Console.WriteLine("z = " + z);
    }
}
