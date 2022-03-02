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
            Nelinurk figura = new Nelinurk(4,3);
            figura.Massiiv();
            figura.Vivod();
            Console.ReadKey();
        }
    }
}
