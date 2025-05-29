using RectangleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите длину первой стороны: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите длину второй стороны: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"Площадь прямоугольника: {rectangle.Area}");
            Console.WriteLine($"Площадь прямоугольника: {rectangle.Perimeter}");
            Console.ReadKey();
        }
    }
}
