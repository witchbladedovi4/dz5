using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class NoteBook

    {
        /*
         * Класс «Ноутбук», имеющий поля модель, тактовая частота процессора,
         * объем оперативной памяти, объем жесткого диска, масса и метод Info, выводящий информацию о ноутбуке в виде строки.
         */
        public string Model { get; set; }
        public int Cpu { get; set; }
        public int Memory { get; set; }
        public int Сapacity { get; set; }

        public int Weight {  get; set; }
        public NoteBook(string model, int cpu, int memory, int capacity, int weight)
        {
            Model = model;
            Cpu = cpu;
            Memory = memory;
            Сapacity = capacity;
            Weight = weight;
        }

        public string Info() => $"Model: {Model}\nCPU: {Cpu}\nMemory: {Memory}\nHard disk capacity: {Сapacity}\nWeight: {Weight}";
    }
}
