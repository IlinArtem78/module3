// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;

class MainClass
{
    public static void Main(string[] args)
    {

        //Необходимо разработать методику анкетирования пользователей. Требуется сохранять информацию: об имени пользователя, фамилии, логине, длине логина,
        //наличии/отсутствии у пользователя питомца, возрасте пользователя, трех любимых цветах пользователя.

        int k = 0;
        while (k < 3)
        {


            (string F_Name, string S_Name, string login, int l_login, bool Pit, byte Age, string[] favcolor, string[] Dishes) User;
            // var Item = (name, age);
            Console.WriteLine("Введите свое имя:");
            User.F_Name = Console.ReadLine();
            Console.WriteLine("Ваше имя {0}", User.F_Name);
            Console.WriteLine("Введите свою фамилию:");
            User.S_Name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия {0}", User.S_Name);
            Console.WriteLine("Введите пользовательский пароль:");
            User.login = Console.ReadLine();
            Console.WriteLine("Ваш пароль {0}", User.login);
            Console.WriteLine("Длинна пользовательского пароля:");
            User.l_login = User.login.Length;
            Console.WriteLine("Длина вашего пароля {0}", User.l_login);
            Console.WriteLine("Есть ли у вас питомец? (введите true или false):");
            User.Pit = Convert.ToBoolean(Console.ReadLine());
            if (User.Pit)
            {
                Console.WriteLine("У вас есть питомец");
            }
            else
            {
                Console.WriteLine("У вас нет питомца!");
            }
            Console.WriteLine("Введите свой возраст:");
            User.Age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ваше возраст {0}", User.Age);
            User.favcolor = new string[3];
            Console.WriteLine("Введите три своих любимых цвета");

            for (int i = 0; i < 3; i++) { 
                User.favcolor[i] = Console.ReadLine();
                Console.WriteLine("Цыет 1: {0}", User.favcolor[i]);
            }
            User.Dishes = new string[5];
            Console.WriteLine("Введите пять своих любимых блюд");

            for (int i = 0; i < 5; i++)
            {
                User.Dishes[i] = Console.ReadLine();
                Console.WriteLine("Цыет 1: {0}", User.Dishes[i]);
            }

            k++; 
        }



       /* nketa.S_Name = Console.ReadLine();
        Console.WriteLine("Ваша фамилия {0}", Anketa.S_Name)



        Console.WriteLine("Введите тип (кошка или собака)");
        Pet.Type = Console.ReadLine();
        Console.WriteLine("Тип питомца {0}", Pet.Type);
        Console.WriteLine("Введите возраст питомца: ");
        Pet.Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Тип питомца {0}", Pet.Age);
        Pet.NameCount = 0;
        
       
        Pet.NameCount = Pet.Name.Length;
          
        
        Console.WriteLine("Длина имени {0}", Pet.NameCount);*/


        //   anketa.age = Convert.ToInt32(Console.ReadLine());
        //
        // Console.WriteLine("Ваше имя: {0}", anketa.name);
        // Console.WriteLine("Ваш возраст: {0}", anketa.age); 





    }
}
        
    enum DaysOfWeek: byte
        {
            Monday = 0, Tuesday = 1, Wednesday = 2, Thursday = 3, Friday = 4, Saturday, Sunday  

        }



