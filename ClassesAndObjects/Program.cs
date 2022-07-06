using System;

namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();  // создание объекта класса Person

            // Получаем значение полей в переменные
            string personName = tom.name;
            int personAge = tom.age;
            Console.WriteLine($"Имя: {personName}  Возраст {personAge}");   // Имя: Undefined  Возраст: 0

            // устанавливаем новые значения полей
            tom.name = "Tom";
            tom.age = 37;

            // обращаемся к методу Print
            tom.Print();    // Имя: Tom  Возраст: 37
            Console.WriteLine(Person.type); // Person
            // Person.type = "User";    // !Ошибка: изменить константу нельзя
        }
    }
}
