using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Square
    {
        /*
         * Класс «Прямоугольник» имеющий поля с координатами левого верхнего и правого нижнего угла, и методы, вычисляющие периметр и площадь прямоугольника.
         */
        public double X1 {  get; set; } //Левый нижний
        public double X2 { get; set; } //Правый нижний
        public double Y { get; set; } // Высота
       

        public Square(double x1, double x2, double y)
        {
            X1 = x1;
            X2 = x2;
            Y = y;

        }



        //2*(a + sqrt(d^2 – a^2)) 
        public string Perimeter() => $"Периметр прямоугольника = {2 * ((X2 - X1) + Math.Pow(Math.Pow(Math.Pow(Math.Pow(X2 - X1, 2) + Math.Pow(Y, 2), 0.5), 2) - Math.Pow(X2 - X1, 2), 0.5))}";
        //S = (p^2 - 4d^2)/8
        public string Area() => $"Площадь: {(Math.Pow(2 * ((X2 - X1) + Math.Pow(Math.Pow(Math.Pow(Math.Pow(X2 - X1, 2) + Math.Pow(Y, 2), 0.5), 2) - Math.Pow(X2 - X1, 2), 0.5)), 2)
            - 4 * Math.Pow(Math.Pow(Math.Pow(X2-X1, 2) + Math.Pow(Y, 2), 0.5), 2))/8
            }";


    }
}
