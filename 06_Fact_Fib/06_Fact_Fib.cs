using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fact_Fib
{
    class Fact_Fib
    {
        
        //функция факториала на цикле
        public static int fakCycle(int x)
        {
            int y = 1;
            for (int i = 1; i <= x; i++)
            {
                y = y * i;
            }
            return y;
        }

        //функция фибоначи на цикле (вычисление одного значения по его номеру)
        public static int fibCycle(int x)
        {
            int a3 = 1, a1=0, a2=1;     //a3 берем 1 т. к. когда запускаем в функцию 1, то цикл не срабатывает
            for (int i = 1; i < x; i++) // и выдается первое значение 0, а надо 1
            {
                a3 = a1 + a2; //делаем сумму из двух предыдущих
                a1 = a2;  //для следующей итерации нужно "сдвинуть" наши a1 и a2 вправо по ряду,
                a2 = a3;  //чтоб в следующей итерации получать a3 уже из новых значений
            }
            return a3;
        }

        //функция факториала рекурсией
        public static int fakRec(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            return x * fakRec(x - 1);
        }
        
        //функция фибоначи рекурсией
        public static int fibRec(int x)
        {
            //if (x < 1) return 0;
            if (x == 1) return 1;
            
            return fibMem(x - 1) + fibMem(x - 2); ;  
        }

        // функция факториала мемоизацией
        public static int fakMem(int x)
        {
            int[] knownFak = new int[1000];
            if (knownFak[x] != 0)   //если туда внесено какое-то значение, 
            {
                return knownFak[x]; //то использовать его
            }
            if (x == 0)    
            {
                return 1; //когда рекурсивная функция доходит до нуля - то результатом
            }             //поставить 1, что закончит формировать ряд и появится окончательное значение
            int t; 
            t = x * fakMem(x - 1); //перед выводом результата, заносим его в ячейку массива 
            return knownFak[x] = t; // (с номером входного значения)
        }
        
        //функция Фибоначи мемоизацией
        public static int fibMem(int x)
        {
            int[] knownFib = new int[1000];
            if (knownFib[x] != 0)   //если туда внесено какое-то значение, 
            {
                return knownFib[x]; //то использовать его
            }
            if (x < 1) return 0;       
            if (x == 1) return 1;
                                                                  //перед выводом результата, заносим его в ячейку массива 
            return knownFib[x] = fibMem(x - 1) + fibMem(x - 2); ;  // (с номером входного значения)
        }
        static void Main(string[] args)
        {
            int a, b;
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("Введите число для факториала: ");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Факториал цикл:     " + fakCycle(a));
                Console.WriteLine("Факториал рекурсия: " + fakRec(a));
                Console.WriteLine("Факториал мемоизация: " + fakMem(a));
                Console.WriteLine();
                Console.Write("Введите число для ряда фибоначи: ");
                b = int.Parse(Console.ReadLine());

                Console.WriteLine("Ряд Фибоначи цикл: " );
                for (int j = 1; j <= b; j++)              //рисуем ряд Фибоначи
                {
                    Console.Write(fibCycle(j) + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Ряд Фибоначи рекурсия: " );
                for (int j = 1; j <= b; j++)                 //рисуем ряд Фибоначи
                {
                    Console.Write(fibRec(j) + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Ряд Фибоначи мемоизация:"  );
                for (int j = 1; j <= b; j++)                    //рисуем ряд Фибоначи
                {
                    Console.Write(fibMem(j) + " ");
                }
                Console.ReadLine();
                
            }
                
            
        }

    }
}
