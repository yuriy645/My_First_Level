using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_1
{
    class Array_1
    {  //функция добавления элементов в массив с возвращением массива
        public static int[] myResize(int[] Array, int x)
        {
            int[] newArray = new int[x];
            for (int i = 0; i < Array.Length; i++)
            {
                newArray[i] = Array[i];
            }
                return newArray;
        }

        //функция добавления элементов в массив с изменением ссылки на данные массива
        public static void myRefResize(ref int[] Array, int x) // новый массив будем называть старым именем
        {
            int[] newArray = new int[x]; // создали новый массив
            for (int i = 0; i < Array.Length; i++)
            {
                newArray[i] = Array[i];
            }
            Array = newArray; // присваваем имени Array новый массив
        }

        //функция выполняет реверс массива т.е. [1,2,3] на выходе [3,2,1]
        public static void reverse(ref int[] Array) // новый массив будем называть старым именем
        {
            int a = 1;
            //int[] newArray = new int[]; // создали новый массив
            for (int i = 0; i < Array.Length/2; i++)
            {
                a = Array[Array.Length - i-1];
                Array[Array.Length - i-1] = Array[i];
                Array[i] = a;
            }
           // Array = newArray; // присваваем имени Array новый массив
        }

        //функция сортирует элементы массива пузырьком
        public static void bubble(ref int[] Array) // новый массив будем называть старым именем
        {
            int a = 0, b=0;
            for (int i = 0; i < 1000; i++) //повтор проходов
            {
                for (int j = 0; j < Array.Length-1; j++) //цикл каждого прохода
                {
                    if (Array[j] > Array[j + 1])
                    {
                        b = Array[j + 1];  //меняем местами элементы
                        Array[j + 1] = Array[j];
                        Array[j] = b;
                        a++;
                    }  
                }
                if (a == 0) break; //если элементы уже не менялись, то больше не повторяем проходы
            }           
        }

        //функция выдачи индексов искомого числа
        public static int[] Search(int[] Array, int x) 
        {
            int[] newArray = new int[Array.Length];
            int j = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                    if (Array[i] == x)
                    {
                        newArray[j] = i; //пишем в новый массив все индексы подходящих чисел
                        j++;          
                    } 
            }
            return newArray;// возвращаем массив со всеми подходящими индексами
        }

        //функция выдачи индексов искомого числа (бинарный поиск)
        public static void SearchBin(int[] Array,ref int x) // новый массив будем называть старым именем
        {
            int[] newArray = new int[Array.Length];
            int n = 0, k = x;
            int n1 = 0, n2 = Array.Length;


            for (int i = 0; i < Array.Length+100; i++)
            {
                n = (n2 + n1) / 2;
                if (k == Array[n]) x = n;//return n;
                else 
                {
                    if (k < Array[n])
                    {
                        n2 = n;
                    }
                    else n1 = n;
                }
            }
            
        }
        static void Main(string[] args)
        {
            int s=0;
            int[] myArray = new int[10];  //// создаем 3 одинаковых массива. Зачем 3 ? Для экспериментов.
            int[] myArray1 = new int[10];
            int[] myArray2 = new int[10];
            Random r = new Random(); // объявление переменной для генерации чисел

            Console.Write("Массив без изменений:            ");
            for (int i = 0; i < myArray.Length; i++)  
            {
                myArray[i] = r.Next(0, 99);
                myArray2[i] = myArray[i];
                Console.Write($"{myArray[i]}  ", $"     ");
            }
            Console.ReadLine();
            //Array.Resize(ref myArray, (myArray.Length+1));   // штатная функция Си#
            myArray = myResize(myArray, (myArray.Length + 1)); //1-й способ
           // myRefResize(ref myArray, (myArray.Length + 1));    //2-й способ
            Console.Write("Массив с добавленным элементом:  ");
            for (int i = 0; i < myArray.Length; i++)  //кол-во вмассиве
            {
                Console.Write($"{myArray[i]}  ", $"     ");
            }
            Console.WriteLine();
            
            reverse(ref myArray);
            Console.Write("Массив с реверсом:               ");
            for (int i = 0; i < myArray.Length; i++)  //кол-во вмассиве
            {
                Console.Write($"{myArray[i]}  ", $"     ");
            }
            Console.WriteLine();

            bubble(ref myArray);
            Console.Write("Сортировка пузырьком:            ");
            for (int i = 0; i < myArray.Length; i++)  //кол-во вмассиве
            {
                Console.Write($"{myArray[i]}  ", $"     ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Введите значение для поиска: ");
            s = int.Parse(Console.ReadLine());
            myArray1 = Search(myArray, s);
            Console.Write("Все ндексы искомого числа:  ");
            for (int i = 0; i < myArray.Length; i++)  //кол-во вмассиве
            {
                Console.Write($"{myArray1[i]}  ", $"     ");
            }
            Console.WriteLine();

            SearchBin(myArray,ref s);
            Console.Write("Индекс искомого числа (бин): ");
           // for (int i = 0; i < myArray.Length; i++)  //кол-во вмассиве
           // {
                Console.Write($"{s}  ", $"     ");
           // }

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
