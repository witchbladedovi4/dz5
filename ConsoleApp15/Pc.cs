using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Pc
    {
        /*
         * Класс «Персональный компьютер», имеющий поля модель, тактовая частота процессора,
         * объем оперативной памяти, объем жесткого диска и метод Info,
         * выводящий информацию о персональном компьютере в виде строки.
         */
        public string Model {  get; set; }
        public int Cpu {  get; set; }
        public int Memory { get; set; }
        public int Сapacity { get; set; }

        public Pc(string model, int cpu, int memory, int capacity)
        {
            Model = model;
            Cpu = cpu;
            Memory = memory;
            Сapacity = capacity;
        }

        public string Info() => $"Model: {Model}\nCPU: {Cpu}\nMemory: {Memory}\nHard disk capacity: {Сapacity}";


    }
}
