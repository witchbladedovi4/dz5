using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Phone
    {
        /*
         * Класс «Смартфон», имеющий поля модель, тактовая частота процессора,
         * объем оперативной памяти, объем постоянной памяти, тип операционной системы,
         * масса и свойство Info, выводящее информацию о смартфоне в виде строки.
         */
        public string Model { get; set; }
        public int Cpu { get; set; }
        public int Memory { get; set; }
        public int Сapacity { get; set; }
        public string Os {  get; set; }
        public int Weight { get; set; }
        public Phone(string model, int cpu, int memory, int capacity, string os, int weight)
        {
            Model = model;
            Cpu = cpu;
            Memory = memory;
            Сapacity = capacity;
            Weight = weight;
            Os = os;
        }

        public string Info() => $"Model: {Model}\nCPU: {Cpu}\nMemory: {Memory}\nHard disk capacity: {Сapacity}\nOs: {Os}\nWeight: {Weight}";
    }
}
