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
            DirectoryInfo URL = new DirectoryInfo(dir);
            long size;
            Console.WriteLine("Выберите класс, который необходимо запустить (1, 2, 3 или 4)");
            byte typeClass = byte.Parse(Console.ReadLine());
            
            switch(typeClass)
            {
                case 1:
                    Task1 _Hw1 = new Task1(dir);
                break;
                case 2:
                    Task2 _Hw2 = new Task2();
                    size = _Hw2.Size(URL);
                    Console.WriteLine("Размер папки {0} байт", size);
                break;
                case 3:
                    Task3 _HW3 = new Task3();
                    _HW3.dirName = dir;
                    long size1 = _HW3.Size(URL);
                    
                    break; 
                case 4:
         
                    string dir1 = "C:\\Users\\User\\Downloads\\students.dat";
                    Task4 _HW4 = new Task4(dir1);            
                break;
                default:
                    Console.WriteLine("Числа могут быть от 1 до 4"); 
                    break; 
            }

            

            Console.ReadKey();

        }


       

    }

}



