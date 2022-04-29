using class_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace class_1
{
    enum Color // тип данных: перечисление //уточнение типа данных получается
    {
        Red,
        Green,
        Orange,
        Yellow,
        Blue
    }
    class Point  //class- наш собственный тип данных (он ссылочный, кстати), состоящий из других типов данных
                 // как тип данных, класс может быть возвращаемым значением метода, и т-же этот тип данных можем принимать в качестве принимаемых пар-ров
    {                 //любой объект в С# - наследник типа данных object (из него берутся (наследуются) методы Equals, GetHashCode, GetType, ToString)
        public int x; // переменная х - это поле класса // public- модификатор поля доступа
        public int y;
        public Color color; //получается поле color типа Color с модификатором public
    }                        // в классе т-же могут быть и методы, не только данные
    class Class_1
    {
        static void Main(string[] args)
        {
            Point p = new Point();    //Point- название класса, р- экемпляр (или объекта) класса. Вышло р типа данных Point. 
     
            p.x = 4;                       //new Point() - выделение места в управляемой куче под объект класса
            p.y = 2;
            p.color = Color.Orange;

            Point p2 = new Point();
            //p2 = null;  // если так сделать, место в куче пропадет и данные будут собраны сборщиком мусора
            p2.x = 2;                     
            p2.y = 6;      //p2- переменная или правильно- объект класса, у нее есть поля х и у
                           // р и р2 никак м. с. не связаны, это, как две переменные типа int, 
                           //но в э. "переменных" может храниться вместо одного значения, много значений
            Console.WriteLine($"X:{p.x} | Y:{p.y} | Color:{p.color}");
        }
    }
}
