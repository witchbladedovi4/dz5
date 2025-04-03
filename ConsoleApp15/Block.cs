using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Block
    {
        //Класс «Квадрат», содержащий поля с координатами левого верхнего угла и с длиной стороны, а также методы для вычисления площади и периметра квадрата
        public double x1;
        public double y1;
        public double a;

        public Block(double x1, double y1, double a)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.a = a;
        }
        public override string ToString() => $"Площадь: {Math.Pow(a, 2)}\n" +
            $"Пириметр: {4 * a}";
    }
}
