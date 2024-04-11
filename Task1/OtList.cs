using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class OtList //класс однонаправленный список
    {
       public List<int> list { get; } //сам список
        public OtList() { } //стандартный конструктор
        public OtList(uint n, int b1, int b2)  //конструктор, который позволяет создать список с уже заданным количесвтом элементов n, диапозон которых находится между b1 и  b2
        {
            list= new List<int>();
            for(int i = 0; i < n; i++)
            {
                Random rnd = new Random();
                list.Add(rnd.Next(b1,b2));
            }
        }
        public void Add(int n) //функция добавления нового элемента в список
        {
            list.Add(n);
        }
        public void Add10() //функция добавления числа 10 после каждого отрицательного числа, как требуется по заданаию
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.Insert(i + 1, 10);
                    i++; 
                }
            }
        }
    }
}
