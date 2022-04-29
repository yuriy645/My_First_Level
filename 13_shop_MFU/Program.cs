using System;
using System.IO;

namespace _13_shop_MFU
{
    abstract class Printer  //абстрактный принтер
    {
        //string mark = "noname";
        abstract public void Print_Mark();
        public void Print(string txt)
        {
            Console.WriteLine($"Текст для печати: {txt}");
        }
    }
    abstract class Scaner  // абстрактный сканер
    {
        public void Scan()
        {
            string t;
            Console.WriteLine($"Введите текст для записи в файл: ");
            t = Console.ReadLine();

            FileStream file1 = new FileStream("c:\\note.txt", FileMode.Append); //создаем файловый поток
            StreamWriter print = new StreamWriter(file1); // добавить в файл //создаем «потоковый писатель» и связываем его с файловым потоком
            print.WriteLine();
            print.Write("Вывод текста в файл: \n" + t);
            print.Close();
        }
    }

    class Huawei_Printer : Printer // конкретный принтер Huawei
    {
        //int price = 200;
        //public static string mark = "Huawei";

        override public void Print_Mark()
        {
            Console.WriteLine($"Марка принтера - Huawei");
        }
    }
    class Samsung_Printer : Printer // конкретный принтер Samsung
    {
        //int price = 210;
        override public void Print_Mark()
        {
            Console.WriteLine($"Марка принтера - Samsung");
        }
    }
    class HP_Printer : Printer // конкретный принтер HP
    {
        //int price = 210;
        override public void Print_Mark()
        {
            Console.WriteLine($"Марка принтера - HP");
        }
    }

    class Huawei_Scaner : Scaner  // конкретный сканер Huawei
    {
        public void Scan_Mark()
        {
            FileStream file1 = new FileStream("c:\\note.txt", FileMode.Append); //создаем файловый поток
            StreamWriter print = new StreamWriter(file1); // добавить в файл
            print.WriteLine();
            print.Write(" Сканер Huawei \n");
            print.Close();
        }
    }
    class Samsung_Scaner : Scaner  // конкретный сканер Samsung
    {
        public void Scan_Mark()
        {
            FileStream file1 = new FileStream("c:\\note.txt", FileMode.Append); //создаем файловый поток
            StreamWriter print = new StreamWriter(file1); // добавить в файл
            print.WriteLine();
            print.Write(" Сканер Samsung \n");
            print.Close();
        }
    }
    class HP_Scaner : Scaner  // конкретный сканер HP
    {
        public void Scan_Mark()
        {
            FileStream file1 = new FileStream("c:\\note.txt", FileMode.Append); //создаем файловый поток
            StreamWriter print = new StreamWriter(file1); // добавить в файл
            print.WriteLine();
            print.Write(" Сканер HP \n");
            print.Close();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string[] buyer = new string[] { "Петя", "Вася", "Дима" };

            while (true)
            {
                Console.WriteLine("Кто пришел??");
                string name = Console.ReadLine();
                for (int i = 0; i <= buyer.Length; i++)
                {
                    if (i == buyer.Length)
                    {
                        Console.WriteLine("Вас нет в списке, убирайтесь!");
                        break;
                    }
                    if (buyer[i] == name)
                    {
                        Console.WriteLine("Привет, " + buyer[i] + " чего изволите?");
                        break;
                    }
                }
                Console.WriteLine();


                //использование класса "Printer"
                Printer printer = null;

                printer = new Huawei_Printer();
                printer.Print_Mark();
                printer.Print("Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor.");

                printer = new Samsung_Printer();
                printer.Print_Mark();
                printer.Print("Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor.");
                //Console.ReadKey();

                //использование класса "Scaner"
                Scaner scaner = new Huawei_Scaner();
                scaner.Scan();

                scaner = new HP_Scaner();
                scaner.Scan();



                //использование класса "MFU"
                //MFU m = new MFU();
                //m.Print("Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor.");
                //m.Scaner1(); 
                Console.ReadKey();
            }

        }

    }

}
