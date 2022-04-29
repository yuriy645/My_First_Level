using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace arrays
{
    class Array
    {
        static void Main(string[] args)
        {
            //  int[] myArray;       //объявление
            // myArray = new int[5]; //инициализация 5шт. элементов нулями т.к. для int дефолтное значение это "0"
            //выделяем память под массив

            //  int[] myArray = new int[5]; //сразуобъявляем и выделяем под него память

            //  int[] myArray = new int[5] {5,6,9,7,8}; //тут надо вписать именно 5 элементов

            //  int[] myArray = new int[] {5,6,9,7}; //тут сколько угодно элементов 
            //если нет фиг скобок, то в квадратных должно быть число

            //  int[] myArray = new [] {5,6,9,7}; //можно и так
            //  int[] myArray = new [5];          //а так не прокатит

            //int[] myArray = Enumerable.Repeat(5, 10).ToArray();
            //Enumerable- класс //Repeat- метод повторяет элемент 5  10 раз //.ToArray() отправляет в массив

            //int[] myArray = Enumerable.Range(5, 10).ToArray(); //10 эл-тов, начиная с 5, т. е. будет 5 6 7 8... 

            //int[] myArray = new int[7]; //{ 5, 6, 9, 7 };
            int[] myArray = new int[] { 5, 6, 9, 7 };
            //Array.Resize(ref myArray, 10);
            //Array.Resize(ref myArray, (myArray.Length + 1));
            //Array.Resize(ref arr, 4);
            //int[] myArray = new int[myArray.Length + 1]; ;
            
            //myArray[4] = 10;
            for (int i = 0; i < myArray.Length; i++)  //кол-во вмассиве
            {
                Console.Write($"{myArray[i]}  ", $"     ");

            }
            Console.ReadLine();
            Console.WriteLine();

            int[,] myArray2 =
            {
                { 1,   6,   9, 8 },
                { 32,  6,  97, 17 },
                { -60, 66,  9,  79 },
                { 5,  311, 9,  17 },

            };
            int max = myArray2[0, 0];
            int min = myArray2[0, 0];
            for (int i = 0; i < myArray2.GetUpperBound(0) + 1; i++) //или GetLength(0); //кол-во вмассиве
            {
                for (int j = 0; j < myArray2.GetUpperBound(1) + 1; j++) //или GetLength(1); 1- мерность
                {
                    Console.Write($"{myArray2[i,j]} \t");
                    if (myArray2[i, j] > max) max = myArray2[i, j];
                    
                    if (myArray2[i, j] < min) min = myArray2[i, j];
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("Максимальное число матрицы: " + max);
            Console.WriteLine("Минимальное число матрицы: " + min);
            Console.ReadLine();

            Console.WriteLine("Использование foreach для вывода");
            foreach (var item in myArray2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("мерность массива " + myArray2.Rank);
            Console.WriteLine();
        }
    }
}
