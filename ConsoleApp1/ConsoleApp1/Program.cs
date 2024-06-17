// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;

class MainClass
{

    static string ShowColor(string username, int userage)  //static - модификатор метода
    {

        Console.WriteLine("{0}, {1} лет \nНапишите свой любимый цвет на английском с маленькой буквы ", username, userage);
        var color = Console.ReadLine();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
               
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is yellow!");
                break;

        }
        return color;
    }


    static string GetDataFromConsole() => Console.ReadLine(); //работает только с методами где только одна операция


    public static void Main(string[] args)
    {

        (string F_Name, string S_Name, string login, int l_login, bool Pit, byte Age, string[] favcolor) User;
        /*   var (name, age) = ("Евгения", 27);

           Console.WriteLine("Мое имя: {0}", name);
           Console.WriteLine("Мой возраст: {0}", age);

           Console.Write("Введите имя: ");
           name = Console.ReadLine();
           Console.Write("Введите возрас с цифрами:");
           age = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Ваше имя: {0}", name);
           Console.WriteLine("Ваш возраст: {0}", age); 

         //   ShowColor();*/

           GetDataFromConsole();
           int[] array = new int[5];

           for (int i = 0; i < array.Length; i++)
           {
               array[i] = GetArrayFromConsole()[i];

           } 

        Console.WriteLine("Введите свое имя:");
        User.F_Name = Console.ReadLine();
        Console.WriteLine("Ваше имя {0}", User.F_Name);
        Console.WriteLine("Введите свой возраст:");
        User.Age = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Ваше возраст {0}", User.Age);

        Console.WriteLine("Введите три своих любимых цвета");
          User.favcolor = new string[3]; 
          for (int i = 0; i < 3; i++)
          {
            User.favcolor[i] = ShowColor(User.F_Name, User.Age);
              Console.WriteLine("Цыет {0}: {1}", i + 1, User.favcolor[i]);
          }

      } 
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];
            
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
        return result;
    }

        static int[] SortArray(int[] array)
    {
        int temp = 0;
        
        for (int k = 0; k < array.Length - 1; k++)
        {
            for (int j = k + 1; j < array.Length; j++)
            {
                if (array[k] > array[j])
                {
                    temp = array[k];
                    array[k] = array[j];
                    array[j] = temp;

                }

            }
        }
        Console.WriteLine("Вывод отсортированного массива : ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i] + " ");
        }

        return array;


    }




}



