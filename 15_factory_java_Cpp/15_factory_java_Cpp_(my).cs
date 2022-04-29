using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace fabric
{
//  Реализация интерфейсов.Фабричный метод.
// a)
//- Интерфейс регламентирует написание кода
//- Написание кода на Java
//- Написание кода на Cpp

// b)
//- Интерфейс регламентирует создание нового Java разработчика
//- Интерфейс регламентирует создание нового Cpp разработчика

//  с)
//В программе реализовали интерфейс создания разработчика,
//созданного разработчика попросили написать код.
//Напишет, как умеет (как реализован метод создания разработчика, так и напишет)
    interface IDeveloperFactory //cоздадим такую сущность. и сделаем 2-е реализации этого интерфейса
    {
        IDeveloper CreateDeveloper();
    }
    public class JavaDeveloperFactory : IDeveloperFactory
    {
        public IDeveloper CreateDeveloper()
        {
            return new JavaDeveloper();
        }
    }
    public class CppDeveloperFactory : IDeveloperFactory
    {
        public IDeveloper CreateDeveloper()
        {
            return new CppDeveloper();
        }

    }

    public interface IDeveloper  //создадим вместо 2-х классов 1 интерфейс и 2 класса реализации э. интерфейса
    {                          // по умолчанию в интерфейсе все public
        void writeCode();
    }

    public class JavaDeveloper : IDeveloper  // 1 применение (реализация) интерфейса
    {
        public void writeCode()
        {
            Console.WriteLine("Java developer writes Java code...");
        }
    }
    public class CppDeveloper : IDeveloper  // 2 применение интерфейса
    {
        public void writeCode()
        {
            Console.WriteLine("C++ developer writes C++ code...");
        }
    }

//public class JavaDeveloper
//{
//    public void writeJavaCode()
//    {
//        Console.WriteLine("Java developer writes Java code...");
//    }
//}
//public class CppDeveloper
//{
//    public void writeCppCode()
//    {
//        Console.WriteLine("Cpp developer writes Cpp code...");
//    }
//}
class Program
    {
        static void Main(string[] args)
        {
            IDeveloperFactory developerFactory = new JavaDeveloperFactory();
            IDeveloper developer = developerFactory.CreateDeveloper();

            
        }
    }
}
