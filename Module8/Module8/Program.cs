// See https://aka.ms/new-console-template for more information

using Module8;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

#pragma warning disable SYSLIB0011

namespace module8
{
    
    // Описываем наш класс и помечаем его атрибутом для последующей сериализации   

    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Pet(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string dir = "D:\\HW1";
            DirectoryInfo N = new DirectoryInfo(dir);
            long size; 
            
            Task1 _Hw1 = new Task1(dir);
            Task2 _Hw2 = new Task2();
            size = _Hw2.Size(N);
            Console.WriteLine("Размер папки {0} байт",size);            

        }
    }

}



