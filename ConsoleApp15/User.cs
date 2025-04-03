using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class User
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }

        public int Age { get; set; }


        public User(string firstname, string secondname, string thirdname, int age)
        {
            Name = firstname; SecondName = secondname; ThirdName = thirdname; Age = age;
        }
        public string Fio()
        {
            return $"{SecondName} {Name} {ThirdName}";
        }

        public override string ToString() => $"ФИО: {Fio}\nЛет: {Age}";
        //Класс «Пользователь» имеющий поля фамилия, имя, отчество и возраст, а также метод ФИО, выводящее фамилию, имя и отчество, разделенные пробелами в виде строки.

    }
}
