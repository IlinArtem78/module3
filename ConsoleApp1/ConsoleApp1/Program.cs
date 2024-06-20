// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;


class MainClass
{

   
        public static void Main(string[] args)
        {
    //    (string F_Name, string S_Name, byte Age, string HavePit, byte PitKol) Name;
        Anketa();

        }



    /*Необходимо создать метод, который заполняет данные с клавиатуры по пользователю (возвращает кортеж):
    // Имя;
    //Фамилия;
    //Возраст;
    Наличие питомца;
    Если питомец есть, то запросить количество питомцев;
    Если питомец есть, вызвать метод, принимающий на вход количество питомцев и возвращающий массив их кличек(заполнение с клавиатуры);
   
    Запросить количество любимых цветов;
    Вызвать метод, который возвращает массив любимых цветов по их количеству(заполнение с клавиатуры);
   1 Сделать проверку, ввёл ли пользователь корректные числа: возраст, количество питомцев, количество цветов в отдельном методе;
    Требуется проверка корректного ввода значений и повтор ввода, если ввод некорректен;
    Корректный ввод: ввод числа типа int больше 0.
    Метод, который принимает кортеж из предыдущего шага и показывает на экран данные. 
    Вызов методов из метода Main. */


    static void Anketa()  // объявление метода 
    {
     (string F_Name, string S_Name, byte Age, string HavePit, byte PitKol) User; //КОРТЕЖ для работы внутри метода
    Console.WriteLine("Введите свое имя: ");
    User.F_Name = Console.ReadLine();
    Console.WriteLine("Ваше имя {0}", User.F_Name);
    Console.WriteLine("Введите свою фамилию:");
    User.S_Name = Console.ReadLine();
    Console.WriteLine("Ваша фамилия {0}", User.S_Name);
    //вспомогательные переменные
    string AgeS; 
    byte AgeCur;    
    string NumPit;
    byte NPit;     
       
        do
        {
            Console.WriteLine("Введите ваш возраст:");
            AgeS = Console.ReadLine();
           
        } while (CheckNum(AgeS, out AgeCur)) ; 

      User.Age = AgeCur;
      Console.WriteLine("Есть ли у Вас питомцы?");     
      string HavePit = Console.ReadLine();
        if (HavePit == "Есть" || HavePit == "True")
        {

            do
            {
               Console.WriteLine("Сколько у Вас питомцев?");
               NumPit = Console.ReadLine();
            } while (CheckNum(NumPit, out NPit));
            User.PitKol = NPit;
            string[] st; 
            st = NamePit(in User.PitKol); 

        } else if (HavePit == "Нет" || HavePit == "False")
        {
            Console.WriteLine("У вас нет питомцев.");
            User.PitKol = 0;
        }



      
    }
    //Если питомец есть, вызвать метод, принимающий на вход количество питомцев и возвращающий массив их кличек(заполнение с клавиатуры);
    static string[] NamePit(in byte num)
    {
        var st = new string[num]; 
        for (int i = 0; i < st.Length; i++)
        {
            Console.ReadLine();
        }
     
        return st;
    }

  
    //Метод для проверки правильности введенного количетсва (возраста, питомца и т.д.)
    static bool CheckNum(string input, out byte output)
    {
        byte output1; 
        bool nCorrect = byte.TryParse(input, out output1);
        if (nCorrect)
        {
            output = output1;
            Console.WriteLine("Ваши данные: {0}", output);
            
            return false;
            
        }
        else
        {
            output = 0; 
            Console.WriteLine("Введены неверные данные!!!");
            return true;
        }
       

        
    }





}


