using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo // https://youtu.be/bkGKQ3pY6kE  //ПОЛИМОРФИЗМ - приведение к родительскому типу после наследования
{// Экземпляры класса потомка м. б. приведены к типу родительского класса. Э. процесс наз-ся об каст.
    class Animal                              //помимо модификаторов доступа к методу можно добавлять спецификаторы
    {                                          //один из таких спецификаторов virtual- дает возм-сть переопределить реализацию метода в дочерних классах
        public string Name { get; set; }
        public virtual void GetRoar()
        {
            Console.WriteLine("Абстрактный клич");
        }
    }
    class Cat : Animal
    {
        public override void GetRoar()  //переопределение метода GetRoar()
        {
            Console.WriteLine("Miau miau"); // но тут можно при помощи ссылки на базовый класс (Animal) вызвать исходный не переопределенный метод
        }                                                      //виртуальные члены класса представляют его полиморфный интерфейс
    }                                                   //а это значит, что мы можем переопределять этот интерфейс в дочерних классах
    class Dog : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine("Gaf gaf");
        }
    }
    class Rat : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine("Pfr pfr");
        }
    }
    class Boozer : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine("Ha-ha!!!");
        }
    }
   
    class P_Zoo
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[4]; //создаем массив animals со значениями типа Animal
            Cat cat = new Cat();            //создаем переменную cat типа Cat
            cat.Name = "Barsik";            //пишем в поле Name этой переменной имя "Barsik"
            Dog dog = new Dog();
            dog.Name = "Tuzik";
            Rat rat = new Rat();
            rat.Name = "Georgiy";
            Boozer boozer = new Boozer();  //создаем экземпляр конкретного типа Boozer
            boozer.Name = "Dyadya Vitya";
            
            animals[0] =cat;  //помещаем в массив при помощи апкаста //т. е. переменной типа Animal присваиваем переменную типа Cat
            animals[1] =dog;
            animals[2] =rat;
            animals[3] =boozer;  //при помощи приведения типов приводим к родительскому типу

            for (int i = 0; i < animals.Length; i++)
            {
                Console.Write($"Говорит {animals[i].Name}: ");
                animals[i].GetRoar();
                
            }

            Console.ReadKey();
        }
    }
}
