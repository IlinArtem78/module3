// See https://aka.ms/new-console-template for more information
class Human
{
    // Поля класса
    public string name;
    public int age;

    // Метод класса
    public void Greetings()
    {
        Console.WriteLine("Меня зовут {0}, мне {1}", name, age);
    }
    // Конструктор 1
    public Human()
    {
        name = "Неизвестно";
        age = 20;
    }
    // Конструктор 2
    public Human(string n)
    {
        name = n;
        age = 20;
    }
    // Конструктор 3
    public Human(string n, int a)
    {
        name = n;
        age = a;
    }
}

struct Animal
{
    // Поля структуры
    public string type;
    public string name;
    public int age;

    // Метод структуры
    public void Info()
    {
        Console.WriteLine("Это {0} по кличке {1}, ему {2}", type, name, age);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Human human = new Human();//вызов класса (конструктор)
        Human human1 = new Human("Артем");
        Human human2 = new Human("Артем", 29);
        human.Greetings();
        human1.Greetings(); 
        human2.Greetings();
        Animal animal = new Animal() { type = "Собака", name = "Вольт", age = 4 };

        ExternalClass.ClassInternalClass newClass;
        ExternalStruct.StructInternalStruct newStruct;
     
    }
   


}
class ExternalClass
{
    public class ClassInternalClass
    {
    }

    struct ClassInternalStruct // невозможно сослаться так как объект не public. 
    {
    }
}

class ExternalStruct
{
    class StructInternalClass // невозможно сослаться так как объект не public. 
    {
    }

    public struct StructInternalStruct
    {
    }
}

class Pen
{
    public string color;
    public int cost;

    public Pen()
    {
        color = "Черный";
        cost = 100; 
    }

    public Pen(string penColor, int penCost)
    {
        color = penColor;
        cost = penCost;
    }
}


class Rectangle
{
    public int a;
    public int b;
    public int Square()
    {
        int c = a * b; 
        return c; 
    }


}