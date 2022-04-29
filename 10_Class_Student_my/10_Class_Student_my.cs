using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Student
{
    class Student
    {
        public Guid id;  // Guid - тип данных, спец. структура, которая использ-ся для создания уникальных id-шников

        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;
    }
    
    class Program
    {
        static Student GetStudent()  //выходит, функция GetStudent ничего не принимает, но 
        {                                                        // возвращает переменную типа Student  // это м. б. запрос к базе данных
            Student student = new Student(); // создаем экземпляр класса Student !!!! //тут можем впереди поставить var
            student.firstName = "Мартин";
            student.middleName = "Игоревич";
            student.lastName = "Дугин";
            student.age = 19;
            student.id = Guid.NewGuid();
            student.group = "ЙЦУКЕН_1";
            
            return student;
        }
        static void Print(Student student) //выходит, процедура "Print" получает переменную student типа Student
        {
            Console.WriteLine("Информация о студенте:");
            Console.WriteLine($"Id: {student.id}");
            Console.WriteLine($"Фамилия: {student.lastName}");
            Console.WriteLine($"Имя: {student.firstName}");
            Console.WriteLine($"Отчество: {student.middleName}");
            Console.WriteLine($"Возраст: {student.age}");
            Console.WriteLine($"Группа: {student.group}");
        }
        static void Main(string[] args)
        {
            var firstStudent = GetStudent(); // в переменную firstStudent кладём результат функции GetStuden

            Print(firstStudent);
        }
    }
}
