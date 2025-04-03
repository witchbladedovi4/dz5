using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Circle
    {
        //Класс «Окружность», содержащая поля с координатами центра окружности и радиуса, а также методы, вычисляющие длину окружности и площадь.
        public double O;
        public double R;
        public Circle(double o, double r)
        {
            O = o;
            R = r;
        }
        public override string ToString() => $"Площадь: {Math.PI * Math.Pow(R, 2)}\n" +
            $"Пириметр: {2 * Math.PI * R}";
    }
}
