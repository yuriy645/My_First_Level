using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Student1 //доступно из программы т. к. совпадает namespase. Либо в программе указать using Class_Student1(название вынесенног класса)
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
}
