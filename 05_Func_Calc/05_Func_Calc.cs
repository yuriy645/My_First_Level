using System;                            


namespace calc                     
{
    class Calc
    {
        public static double add (double x,double y)
        {
            return x + y;
        }
        public static double sub(double x, double y)
        {
            return x - y;
        }
        public static double mul(double x, double y)
        {
            return x * y;
        }
        public static double div(double x, double y)
        {
            return x/y;
        }
        
        static void Main(string[] args)
        {
            while (true) //чтобы после отработки запускалось еще раз
            {
                Console.Clear();                              //очистка консоли
                Console.WriteLine("Calc");                 //console - это  класс writeline - метод этого класса
                double a, b, c = 0;
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
                        c = add(a,b); //Console.WriteLine(a+b);
                        break;
                    case "-":
                        c = sub(a,b); // Console.WriteLine(a-b);
                        break;
                    case "*":
                        c = mul(a,b); // Console.WriteLine(a* b);
                        break;
                    case "/":
                        if (b == 0) Console.WriteLine("На 0 делить нельзя");
                        else c = div(a,b); // Console.WriteLine(a/b);

                        break;

                    default:
                        Console.WriteLine("Ошибка: Неизвестное действие");
                        break;
                }
                Console.WriteLine("Результат: " + c + "; ");
                Console.WriteLine();

                Console.ReadLine();
            }
        }
    }
}
