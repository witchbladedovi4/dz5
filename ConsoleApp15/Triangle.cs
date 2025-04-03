using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Triangle
    {
        //Объект «Треугольник» имеющий поля с длинами сторон, и методы, вычисляющие периметр и выводящий длины сторон, а также периметр треугольника на экран.
        public double A {get;set;}
        public double B {get;set;}
        public double C {get;set;}

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public string Info() => $"Длина стороны a: {A}\nb:{B}\nc:{C}";
        public string Perimetr() => $"Периметр = {A + B + C}";
        //По герону
        public string Area() => $"{Math.Pow((A + B + C) / 2 * (((A + B + C) / 2 - A)) * ((A + B + C) / 2 - B) * (((A + B + C) / 2 - C)), 0.5)}";
    }
}
