using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Mail
    {
        //Класс «Почтовое отправление», содержащий поля адреса получателя: индекс, город, улица, дом, корпус, квартира, а также, тело письма(сообщение), и метод, выводящий адрес в виде строки.
        public int Index { get; set; }
        public string City {  get; set; }
        public string Street {  get; set; }
        public int Home {  get; set; }
        public int Body { get; set; }
        public int Flat {  get; set; }
        public string Message {  get; set; }

        public Mail(int index, string city, string street, int home, int body, int flat, string message)
        {
            Index = index;
            City = city;
            Street = street;
            Home = home;
            Body = body;
            Flat = flat;
            Message = message;
        }

        public override string ToString() => $"Сообщение: {Message}\nПо адресу: Индекс {Index}, город {City}, ул.{Street}, Дом {Home}, корус {Body}, кв.{Flat}";
    }

}
