using System;

namespace arrays
{
    class Program
    {


        public static int out1(int x)
        {
            Console.Write("    ");
            int a = x;
            while (a >= 1) 
            {
                a = a/10;
                Console.Write("\b"); //стирание одного символа (одного из пробелов)
            } 
            
            //string strx = Convert.ToString(x);
            //Console.Write("     ");
            //for (int i = 0; i <= strx.Length; i++)
            //{
            //    Console.Write("\b");  //стирание одного символа (одного из пробелов)
            //}
            Console.Write(x);
            return x;
        }
        static void Main(string[] args)
        {
      
            Console.WriteLine("Введите первое число по горизонтали");
            int x1 = 1;// int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число по горизонтали");
            int x2 = 10;// int.Parse(Console.ReadLine());
            Console.WriteLine("Введите первое число по вертикали");
            int y1 = 1;// int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число по вертикали");
            int y2 = 11;// int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write($"    " + "|"); //вывод левого верхнего угла
            for (int j1 = x1; j1 <= x2; j1++) //вывод верхней строчки
            {
                out1(j1); //Console.Write($"{j1} \t");
            }
            Console.WriteLine();
            Console.Write("----+");       //вывод горизонтального разделителя до плюса
            for (int j1 = x1; j1 <= x2; j1++)  //вывод горизонтального разделителя после плюса
            {
                Console.Write("----");
            }
            Console.WriteLine();

            for (int i1 = y1; i1 <= y2; i1++)  //вывод всего
            {
                out1(i1); Console.Write("|");//Console.Write("\t" + i1 + "|");   //($"{i1} \t" + "|");     //вывод первого элемента (столбца)
                for (int j1 = x1; j1 <= x2; j1++) //цикл вывода каждой строки
                {
                    out1(j1 * i1);//Console.Write("   " + j1 * i1);                                // Console.Write($"{j1*i1} \t");
                }
                Console.WriteLine();

            }


            Console.ReadLine();
            int[,] myArray2;
            myArray2 = new int[100, 100];
            //Вывод колонки по Х
            Console.WriteLine("Вывод диапазона по горизонтали:");
            int j = 1;
            for (int k = x1; k <= x2; k++) 
            {
                   myArray2[0, j] = k;
                   Console.Write($"{myArray2[0, j]} \t");
                   j++;
            }
                Console.WriteLine();

            // Вывод колонки по У
            Console.WriteLine("Вывод диапазона по вертикали:");
            int i = 1;
            for (int k = y1; k <= y2; k++) 
            {
                myArray2[i, 0] = k;
                
                Console.Write($"{myArray2[i, 0]} \t");
                i++;

            }
            Console.WriteLine();
            Console.WriteLine();

            //Заполнение таблицы пифагора

            i = 1;
            
            for (int k = 1; k <= y2; k++) 
            {
                j = 1;
                for (int n = 1; n <= x2; n++) 
                {
                    myArray2[i, j] = myArray2[0, j] * myArray2[i, 0];
                    j++;
                }
                i++;
            }

            //Вывод всего массива
            Console.WriteLine("Вывод массива без разметки");
            i = 0; 
            for (int k = y1; k <= y2+1; k++) // проходим от меньшего введенного значения к большему, но элементы пишем с первого адреса.
            {
                j = 0;
                for (int n = x1; n <= x2+1; n++) // проходим от меньшего введенного значения к большему, но элементы пишем с первого адреса.
                {                                  // + т. к. в этот раз захватываем вывод 0-го столбика.
                 Console.Write($"{myArray2[i, j]} \t");
                    j++;
                }
                i++;
                Console.WriteLine();
            }
            Console.WriteLine();
            //Вывод всего массива с разметкой
            Console.WriteLine("Вывод массива с разметкой");
            
            //Вывод первой строчки
            Console.Write(" " + "|" + $"\t");
            j = 1;
            for (int k = x1; k <= x2; k++) 
            {
               Console.Write($"{myArray2[0, j]} \t");
                j++;
            }
            Console.WriteLine();
           
            //Вывод горизонтального разделителя
            for (int k = 0; k < (x2-x1)*10; k++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

            //Вывод остального
            i = 1;
            for (int k = y1; k <= y2 ; k++)
            {
                j = 0;
                for (int n = x1; n <= x2+1 ; n++)
                {
                    if (j==0)
                    {
                    Console.Write(myArray2[i, j] + "|" + $"\t");
                    }
                    else
                    Console.Write($"{myArray2[i, j]} \t");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            Console.WriteLine();

        }
    }
}
