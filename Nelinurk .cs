using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelinurk
{
    public class Nelinurk
    {
        //Поля
        double korgus;
        double laius;
        string figuravalid;
        //Конструкторы
        public Nelinurk() { }
        public Nelinurk(double korgus, double laius) 
        {
            this.korgus = korgus;
            this.laius = laius;
        }
        //Свойства
        public string Tuup 
        {
            get 
            {
                var answer = "";
                if (korgus == laius)
                {
                    answer = "Ruut";
                }
                return answer;
            }
        }
        //public string Figuravalid 
        //{
        //    get 
        //    {
        //        for (int i = 0; i < length; i++)
        //        {
        //            int summ = 0;

        //        }
        //        if ()
        //    }
        //}
        //Методы
        public Array Massiiv() 
        {
            int[] tuup = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Введите угол {i+1}: ");
                tuup[i] = int.Parse(Console.ReadLine());
            }
            return tuup;
        }
        public double Pindala() 
        {
            double pindala;
            pindala = korgus * laius;
            return pindala;
        }
        public double Ombermotot()
        {
            double ombermotot;
            ombermotot=(korgus+laius)*2;
            return ombermotot;
        }
        public void Vivod() 
        {
            Console.WriteLine($"Pindala: {Pindala()}\nÕmbermotot: {Ombermotot()}");
        }
    }
}
