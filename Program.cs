using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelinurk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double a,b,c;
            Console.Write("Введите длину: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину, если ширина неизвестна введите 0 ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту, если высота неизвестна введите 0: ");
            c = Convert.ToDouble(Console.ReadLine());
            if (a != 0 && b != 0 && c == 0)
            {
                Nelinurk figura = new Nelinurk(a, b);
                figura.Massiiv();
                string tuup = figura.Tuup;
                figura.Vivod();
            }
            else if (a != 0 && b != 0 && c != 0)
            {
                Nelinurk figura = new Nelinurk(a, b, c);
                figura.Massiiv();
                string tuup = figura.Tuup;
                figura.Vivod();
            }
            else
            {
                Console.WriteLine("Фигуры не существует");
            }
            Console.ReadKey();
        }
    }
}
