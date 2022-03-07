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
        double pikkus;
        double korgus;
        double laius;
        double pindala;
        bool abi;
        string figuratype;
        int[] tuup = new int[4];
        //Конструкторы
        public Nelinurk() { }
        public Nelinurk(double pikkus, double laius, double korgus) 
        {
            this.pikkus = pikkus;
            this.laius = laius;
            this.korgus = korgus;
        }
        public Nelinurk(double pikkus, double laius)
        {
            this.pikkus = pikkus;
            this.laius = laius;
        }
        //Свойства
        public string Tuup
        {
            get 
            {
                int abi2 = 0;
                for (int i = 0; i < tuup.Length; i++)
                {
                    if (tuup[i] == 90)
                    {
                        abi2++;
                    }
                }
                if (pikkus==laius && korgus==0)
                {
                    figuratype = "Квадрат";
                }
                else if (pikkus!=laius && abi2==4)
                {
                    figuratype = "Прямоугольник";
                }
                else if (tuup[0] + tuup[1] == 180 || tuup[0] + tuup[2] == 180 && abi2 != 4)
                {
                    figuratype = "Параллелограмм";
                }
                return figuratype;
            }
                
        }
        public bool Figuravalid
        {
            get
            {
                int summ = 0;
                for (int i = 0; i < tuup.Length; i++)
                {
                    summ+=tuup[i];

                }
                if (summ!=360)
                {
                    abi = true;
                }
                else
                {
                    abi=false;
                }
                return abi;
            }
            
        }
        //Методы
        public Array Massiiv() 
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Введите угол {i+1}: ");
                tuup[i] = int.Parse(Console.ReadLine());
            }
            return tuup;
        }
        public double Pindala() 
        {
            if (figuratype=="Квадрат" || figuratype=="Прямоугольник")
            {
                pindala = pikkus * laius;
            }
            else if (figuratype== "Параллелограмм")
            {
                pindala = korgus * pikkus;
            }
            return pindala;
        }
        public double Ombermotot()
        {
            double ombermotot;
            ombermotot=(pikkus+laius)*2;
            return ombermotot;
        }
        public void Vivod() 
        {
            if (abi==false)
            {

                Console.WriteLine("Фигура существует");
                Console.WriteLine($"Тип четырехугольника-> {figuratype}");
                Console.WriteLine($"Pindala: {Pindala()}\nÕmbermotot: {Ombermotot()}");
            }
            else
            {
                Console.WriteLine("Фигуры не существует");
            }
        }
    }
}
