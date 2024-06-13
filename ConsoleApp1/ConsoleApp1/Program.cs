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

        

        (string F_Name, string S_Name, string login, int l_login, bool Pit, byte Age, string color1, string color2, string color3) Anketa;
        // var Item = (name, age);
        Console.WriteLine("Введите свое имя:"); 
        Anketa.F_Name = Console.ReadLine();
        Console.WriteLine("Ваше имя {0}", Anketa.F_Name);
        Console.WriteLine("Введите свою фамилию:");
        Anketa.S_Name = Console.ReadLine();
        Console.WriteLine("Ваша фамилия {0}", Anketa.S_Name);
        Console.WriteLine("Введите пользовательский пароль:");
        Anketa.login = Console.ReadLine();
        Console.WriteLine("Ваш пароль {0}", Anketa.login);
        Console.WriteLine("Длинна пользовательского пароля:");
        Anketa.l_login = Anketa.login.Length;
        Console.WriteLine("Длина вашего пароля {0}", Anketa.l_login);
        Console.WriteLine("Есть ли у вас питомец? (введите 1 или 0):"); 
        Anketa.Pit = Convert.ToBoolean(Console.ReadLine());
        if (Anketa.Pit)
        {
            Console.WriteLine("У вас есть питомец"); 
        }
        else
        {
            Console.WriteLine("У вас нет питомца!")
        }
        Console.WriteLine("Введите свой возраст:");
        Anketa.Age = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Ваше возраст {0}", Anketa.Age);





        nketa.S_Name = Console.ReadLine();
        Console.WriteLine("Ваша фамилия {0}", Anketa.S_Name)



        Console.WriteLine("Введите тип (кошка или собака)");
        Pet.Type = Console.ReadLine();
        Console.WriteLine("Тип питомца {0}", Pet.Type);
        Console.WriteLine("Введите возраст питомца: ");
        Pet.Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Тип питомца {0}", Pet.Age);
        Pet.NameCount = 0;
        
       
        Pet.NameCount = Pet.Name.Length;
          
        
        Console.WriteLine("Длина имени {0}", Pet.NameCount);


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



