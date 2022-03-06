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
            Console.Write("Введите 1 сторону: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите 2 сторону: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту: ");
            c = Convert.ToDouble(Console.ReadLine());
            Nelinurk figura = new Nelinurk(a,b,c);
            figura.Massiiv();
            if (figura.Figuravalid==false)
            {
                figura.Tuup;
                Console.WriteLine("Фигура существует");
                figura.Vivod();
            }
            else
            {
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
