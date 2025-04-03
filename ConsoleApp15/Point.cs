using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Point
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point(int x = 0, int y = 0, int z = 0)
        {
            X = x; Y = y; Z = z;
        }
        public void MoveBy(int dx, int dy, int dz)
        {
           
            X += dx;
            Y += dy;
            Z += dz;

        }
        public override string ToString() => $"Точка: {X}, {Y}, {Z}";
        
        //Класс «Точка», имеющего поля X, Y, Z и метод перемещения MoveBy(dx, dy, dz), смещающий точку на заданные значения по X, Y, Z.
    }
}
