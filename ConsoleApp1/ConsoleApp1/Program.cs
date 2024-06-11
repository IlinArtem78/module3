// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;

class MainClass
{
    public static void Main(string[] args)
    {
      
        

        (string name, int age) anketa;
        // var Item = (name, age);

        anketa.name = Console.ReadLine();
        anketa.age = Convert.ToInt32(Console.ReadLine());



        Console.WriteLine("Ваше имя: {0}", anketa.name);
        Console.WriteLine("Ваш возраст: {0}", anketa.age); 





    }
}
        
    enum DaysOfWeek: byte
        {
            Monday = 0, Tuesday = 1, Wednesday = 2, Thursday = 3, Friday = 4, Saturday, Sunday  

        }



