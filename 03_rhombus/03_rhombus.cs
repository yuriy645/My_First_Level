using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangles
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите размер ромба: ");
            int size = int.Parse(Console.ReadLine());

            // ромб

            for (int i = 0; i < (2 * size); i++)  // перевод вниз
            {
                if (i < size) //верхняя часть ромба
                {

                    for (int j = 0; j < (2 * size); j++) //вывод рядка
                    {
                        if (j >= (size - i) && j <= (size + i))
                            Console.Write("*");
                        else Console.Write(" ");

                    }
                    Console.WriteLine();
                }
                else           //нижняя часть ромба
                { for (int j = 0; j < (2 * size); j++) //вывод рядка
                    {
                        if ( j >( size - (2*size-i)+1  ) && (j < (size + (2 * size - i)-1 )) )
                            Console.Write("*");
                        else Console.Write(" ");

                    }
                    Console.WriteLine();
                }


            }
            Console.ReadLine();


            // треугольник 1           
            for (int i = 0; i < size; i++)  // перевод вниз
            {
                for (int j = 0; j < i; j++) //вывод рядка
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.ReadLine();


            // треугольник 2           
            for (int i = size; i > 0; i--)  // перевод вниз
            {
                for (int j = 0; j < i; j++) //вывод рядка
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            // треугольник 1  наоборот         
            for (int i = 0; i < size; i++)  // перевод вниз
            {
                for (int j = 0; j < i; j++) //вывод начала рядка
                {
                    Console.Write(" ");
                }
                for (int j = i; j < size; j++) //вывод продолжения рядка
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.ReadLine();


            // треугольник 1  вверх ногами      
            for (int i = size; i > 0; i--)  // перевод вниз
            {
                for (int j = 0; j < i; j++) //вывод начала рядка
                {
                    Console.Write(" ");
                }
                for (int j = i; j < size; j++) //вывод продолжения рядка
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
