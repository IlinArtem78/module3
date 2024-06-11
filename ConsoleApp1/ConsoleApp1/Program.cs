// See https://aka.ms/new-console-template for more information
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        /*  Console.WriteLine("Как вас зовут?");
          string myName = Console.ReadLine();
          Console.WriteLine("Меня зовут: {0}", myName);
          Console.WriteLine("Сколько вам лет?");
          byte myAge = (byte)int.Parse(Console.ReadLine());
          Console.WriteLine("Мой возраст {0}", myAge);
          Console.WriteLine("Если ли у вас питомец? Введите 1 или 0 ");
          byte MyPet = Convert.ToByte(Console.ReadLine());
          if (MyPet == 1)
          {
              Console.WriteLine("Ecть питомец");
          }
          else if (MyPet == 0)
          {
              Console.WriteLine("Нет питомца");
          }
          Console.WriteLine("Какой у вас размер ноги?");
          byte MyFootSize = byte.Parse(Console.ReadLine());
          Console.WriteLine("Размер ноги {0}", MyFootSize);
          Console.WriteLine("Какой ваш любимый день недели?");

          DayOfWeek dayOfWeek = (DayOfWeek) byte.Parse(Console.ReadLine());
          Console.WriteLine("Ваш любимый день недели {0}", dayOfWeek); 
        string[] favcolors = new string[3]; 
        for (int i = 0; i < favcolors.Length; i++)
        {
            Console.WriteLine("Введите любимый цвет номер {0}", i + 1);
            favcolors[i] = Console.ReadLine(); 
        }
        foreach(var color  in favcolors)
        {
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
                    continue;
            }

            
            if (color == "stop")
            {
                Console.WriteLine("Цикл прерван");
                break;
            }

            Console.WriteLine("Привет, \n мир");
        } */

        Console.WriteLine("Введите ваше имя");
        string st = Console.ReadLine();
        foreach (var ch in st)
        {

            Console.Write(ch + " ");
            
        }
        Console.WriteLine();
        Console.Write("Последняя буква вашего имени {0}", st[st.Length - 1]);
        // Console.Write(ch + " ");  
        for (int i = st.Length - 1; i >= 0; i--)
                 {
            Console.Write(st[i] + " ");
               // Console.Write(i);
                   
                    }
       // Console.WriteLine(st[st.Length]);

        
      

    }
}
        
    enum DaysOfWeek: byte
        {
            Monday = 0, Tuesday = 1, Wednesday = 2, Thursday = 3, Friday = 4, Saturday, Sunday  

        }



