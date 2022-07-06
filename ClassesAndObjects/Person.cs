using System;

namespace ClassesAndObjects
{
    class Person
    {
        public const string type = "Person";
        public string name = "Undefined";
        public int age;
        public void Print() => Console.WriteLine($"{type}: {name} - {age}");
    }
}
