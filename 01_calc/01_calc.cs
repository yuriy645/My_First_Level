using System;                             //тут подключение различных пространств имен. подсвечено- значит, ипользуется
                                          // если его убрать, то нельзя будеть использовать console 
                                          //потому что класс console используууется в пространствве имен system
                                          //без него пришлось бы писать полное имя нахождения этого класса system.Console.WriteLine
using System.Collections.Generic;  //блоки кода, кот. разграничивают классы,  функционал логическим образом, чтобы они не конфликтовали др с др
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc       // наше пространство имен наз-ся calc                      
{

    class Calc
    {
        public static double odd1(double x)
        {
            if (x % 2 == 0) Console.WriteLine("Число " + x + "- четное");
            else Console.WriteLine("Число " + x + "- нечетное");
            return x;
        }

        static void Main(string[] args)


      {   while (true) //чтобы после отработки запускалось еще раз
	      
	        {
            Console.Clear();                              //очистка консоли
            Console.WriteLine("Calc");                 //console - это  класс writeline - метод этого класса
            double a, b, c=0;
            string action;

                try
                {
                    Console.WriteLine("Введите число 1");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите число 2");
                    b = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Не удалось преобразовать строку в число");
                    Console.ReadLine(); //нет смысла продолжать
                    continue; // попадем в начало цикла
                }

              
                Console.WriteLine("Введите операцию");
            action = Console.ReadLine();

          
            switch (action)
            {
                case "+":
                        c = a + b; //Console.WriteLine(a+b);
                    break;
                case "-":
                        c = a - b; // Console.WriteLine(a-b);
                    break;
                case "*":
                        c = a * b; // Console.WriteLine(a* b);
                    break;
                case "/":

                        if (b == 0) Console.WriteLine("На 0 делить нельзя");
                        else c = a / b; // Console.WriteLine(a/b);
                    
                    break;

                default:
                    Console.WriteLine("Ошибка: Неизвестное действие");
                    break;
            }
                Console.WriteLine("Результат: " + c + "; ");
                Console.WriteLine();

                Console.WriteLine("Проверка на четность:");
                Console.WriteLine("Входные данные:");
                odd1(a);
                odd1(b);
                Console.WriteLine("Результат:");
                odd1(c);



                Console.ReadLine();

                
            } 
	}
    }
}
