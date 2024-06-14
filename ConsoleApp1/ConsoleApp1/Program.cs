// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;

class MainClass
{

    static string ShowColor()  //static - модификатор метода
    {
        Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
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
      /*  var (name, age) = ("Евгения", 27);

        Console.WriteLine("Мое имя: {0}", name);
        Console.WriteLine("Мой возраст: {0}", age);

        Console.Write("Введите имя: ");
        name = Console.ReadLine();
        Console.Write("Введите возрас с цифрами:");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя: {0}", name);
        Console.WriteLine("Ваш возраст: {0}", age); */

     //   ShowColor();

        GetDataFromConsole();

        int[] papa =  GetArray();

        Console.WriteLine("Введите три своих любимых цвета");
        var favcolors = new string[3]; 
        for (int i = 0; i < 3; i++)
        {
           favcolors[i] =  ShowColor();
            Console.WriteLine("Цыет {0}: {1}", i, favcolors[i]);
        }

    }
    static int[] GetArray()
    {
        var result = new int[5];
        int  temp = 0; 
        for (int i = 0;i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }
        for (int k = 0; k < result.Length - 1; k++)
        {
            for (int j = k + 1 ; j < result.Length; j++)
            {
                if (result[k] > result[j])
                {
                    temp = result[k];
                    result[k] = result[j];
                    result[j] = temp;

                }

            }
        }
        Console.WriteLine("Вывод отсортированного массива"); 


        return result;

    }






}


