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

            Console.Write("Введите высоту треугольника: ");
            int height = int.Parse(Console.ReadLine());

            // прямоугольник
            for (int i = 0; i < height; i++)  // перевод вниз
            {
                for (int j = 0; j < height; j++) //вывод рядка
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.ReadLine();


            // треугольник 1           
            for (int i = 0; i < height; i++)  // перевод вниз
            {
                for (int j = 0; j < i; j++) //вывод рядка
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.ReadLine();


            // треугольник 2           
            for (int i = height; i > 0; i--)  // перевод вниз
            {
                for (int j = 0; j < i; j++) //вывод рядка
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            // треугольник 1  наоборот         
            for (int i = 0; i < height; i++)  // перевод вниз
            {
                for (int j = 0; j < i; j++) //вывод начала рядка
                {
                    Console.Write(" ");
                }
                for (int j = i; j < height; j++) //вывод продолжения рядка
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.ReadLine();


            // треугольник 1  вверх ногами      
            for (int i = height; i > 0; i--)  // перевод вниз
            {
                for (int j = 0; j < i; j++) //вывод начала рядка
                {
                    Console.Write(" ");
                }
                for (int j = i; j < height; j++) //вывод продолжения рядка
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
