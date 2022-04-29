using System;
namespace Dev 
{
    //Полиморфизм.Переопределение строительных компаний и домов.
    //a)
    //-Абстрактный дом
    //- Панельный дом
    //- Деревянный дом

    //b)
    //-Абстрактный застройщик
    //- Панельный застройщик создаёт панельные дома
    //- Деревянный застройщик создаёт деревянные дома

    //c)
    //В программе создаём застройщика с названием, командуем ему строить и он строит, как умеет

    // абстрактный класс строительной компании
    abstract class Developer  //абстрактный класс вместо интерфейса   (строитель)
    {
        public string Name { get; set; }

        public Developer(string n)            //конструктор. принимать имя застройщика           
        {
            Name = n;                                    // и без этого тоже работает
        }
        // фабричный метод
        abstract public House Create(); // пустая{} ф-ция Create() возвращает House 
    }

    // строит панельные дома
    class PanelDeveloper : Developer  // панельный строитель
    {
        public PanelDeveloper(string n) : base(n)       //конструктор, кот. принимает имя застройщика. Если имя передается, то он нужен.
        { }

        public override House Create()                            // этот класс здесь функцией Create() в поле House 
        {                                                         //
            return new PanelHouse();                              //возвращает PanelHouse
        }
    }
    // строит деревянные дома
    class WoodDeveloper : Developer   // деревянный строитель
    {
        public WoodDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new WoodHouse();
        }
    }

    abstract class House    //абстрактный класс вместо интерфейса  (дом)
    { }

    class PanelHouse : House    // панельный дом
    {
        public PanelHouse()
        {
            Console.WriteLine("Панельный дом построен");
        }
    }
    class WoodHouse : House     // деревянный дом
    {
        public WoodHouse()
        {
            Console.WriteLine("Деревянный дом построен");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new PanelDeveloper("ООО КирпичСтрой"); // берём конкретного строителя dev (типа Строитель), 
            House house2 = dev.Create(); // потом он получает задачу построить дом и строит, как умеет
                                         // (конкретный дом типа Дом делается, обащением к функции Create текущего застройщика)
            dev = new WoodDeveloper("Частный застройщик");
            House house = dev.Create();

            Console.ReadLine();
        }
    }
}