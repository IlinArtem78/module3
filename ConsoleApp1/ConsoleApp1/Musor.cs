using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*    internal class Musor
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
           } 

           Console.WriteLine("Введите ваше имя");
           string st = Console.ReadLine();
           foreach (var ch in st)
           {

               Console.Write(ch + " ");

           }
           Console.WriteLine();
           Console.Write("Последняя буква вашего имени {0}", st[st.Length - 1]);
           Console.WriteLine();
           // Console.Write(ch + " ");  
           for (int i = st.Length - 1; i >= 0; i--)
                    {
               Console.Write(st[i] + " ");
                  // Console.Write(i);

                       }
          // Console.WriteLine(st[st.Length]);
           int[,] a = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
           Console.Write("Количество строк: ");
           Console.WriteLine(a.GetUpperBound(0) + 1 + " ");
           Console.Write("Количество колонок: ");
           Console.WriteLine(a.GetUpperBound(1) + 1 + " ");
           int temp = 0;
           int sum = 0; 
           for (int i = 0; i<a.GetUpperBound(0) + 1; i++)
           {
               for (int j = 0; j<a.GetUpperBound(1)+ 1; j++)
               {
                   for (int k = j+1;  k<a.GetUpperBound(1) + 1; k++)
                       if (a[i, j] > a[i, k])
                       {
                           temp = a[i, j];
                           a[i, j] = a[i, k];
                           a[i, k] = temp;
                       }
       Console.Write(a[i, j] + " ");
               }



   Console.WriteLine();
           }


           //Console.WriteLine(a.GetUpperBound(0));
           /*  foreach (var item in a)
             {
                 Console.Write(item + " ");
             } 
             int temp = 0; 

             for(int i = 0; i < a.GetUpperBound(0) + 1; i++)
             {

                 for (int j = i+1; j < a.GetUpperBound(0) + 1; j++)
                 {
                     if (a[i] > a[j])
                     {
                         temp = a[i];
                         a[i] = a[j]; 
                         a[j] = temp;
                     }
                 }
             } 
             //вывод
             int sum = 0; 
             Console.WriteLine("Вывод сортированного массива:"); 
             for(int i = 0;i < a.Length; i++)
             {
                 if (a[i] > 0)
                 {  sum++; 
                 }
                 Console.Write(a[i] + " ");
                // sum += a[i];


             }
           Console.Write("Количество положительных элементов массива: {0}", sum);  

           //Необходимо разработать методику анкетирования пользователей. Требуется сохранять информацию: об имени пользователя, фамилии, логине, длине логина,
           //наличии/отсутствии у пользователя питомца, возрасте пользователя, трех любимых цветах пользователя.

           int k = 0;
           while (k< 3)
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

   for (int i = 0; i < 3; i++)
   {
       User.favcolor[i] = Console.ReadLine();
       Console.WriteLine("Цыет {0}: {1}", i, User.favcolor[i]);
   }
   User.Dishes = new string[5];
   Console.WriteLine("Введите пять своих любимых блюд");

   for (int i = 0; i < 5; i++)
   {
       User.Dishes[i] = Console.ReadLine();
       Console.WriteLine("Блодо {0}: {1}", i, User.Dishes[i]);
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


           Console.WriteLine("Длина имени {0}", Pet.NameCount);


           //   anketa.age = Convert.ToInt32(Console.ReadLine());
           //
           // Console.WriteLine("Ваше имя: {0}", anketa.name);
           // Console.WriteLine("Ваш возраст: {0}", anketa.age); 





       }
   }

       enum DaysOfWeek : byte
   {
       Monday = 0, Tuesday = 1, Wednesday = 2, Thursday = 3, Friday = 4, Saturday, Sunday

   }


            static void Echo(string phrase, int deep)
        {
        var modif = phrase; 
        if (modif.Length > 2)
        {
            modif = modif.Remove(0, 2);
        }

        
        if (deep > 1)
        {
            Echo(modif, deep - 1);

            
            
                    Console.BackgroundColor = (ConsoleColor) deep;
                    Console.WriteLine("..." + modif);

              
            

        }

        



    }

   
        static decimal Factorial (int x)
            {
        if (x == 0)
        {
            return 1;
        }
        else
        {
            return x * Factorial(x - 1); 
        }


            }

    private static int PowerUp(int N, byte pow)
    {
        switch (pow)
        {
            case 0: 
                return 1;
            break;
            case 1:
                return N;
            break;
            default:
                return N * PowerUp(N, --pow); 

        }
    }


    static int[] GetArrayFromConsole(ref int num)
        {
            var result = new int[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            foreach (int k in result) {
            Console.WriteLine(k + " ");  
            
                 }
        return result;
    }
 

    static void SortArray(in int[] array, out int[] sorteddesc, out int[] sorted_asc ) 
    {

       sorteddesc = SortArrayDesc(array);
       sorted_asc = SortArrayAsc(array);

    }


    static int[] SortArrayDesc(int[] arr1)
    {
        int temp = 0;

        for (int k = 0; k < arr1.Length - 1; k++)
        {
            for (int j = k + 1; j < arr1.Length; j++)
            {
                if (arr1[k] < arr1[j])
                {
                    temp = arr1[k];
                    arr1[k] = arr1[j];
                    arr1[j] = temp;

                }

            }
        }
        Console.WriteLine("Вывод отсортированного массива : ");
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.WriteLine(arr1[i] + " ");
        }

        return arr1;
    }
    static int[] SortArrayAsc(int[] arr2)
    {
        int temp = 0;

        for (int k = 0; k < arr2.Length - 1; k++)
        {
            for (int j = k + 1; j < arr2.Length; j++)
            {
                if (arr2[k] > arr2[j])
                {
                    temp = arr2[k];
                    arr2[k] = arr2[j];
                    arr2[j] = temp;

                }

            }
        }
        Console.WriteLine("Вывод отсортированного массива : ");
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.WriteLine(arr2[i] + " ");
        }

        return arr2;


    }




    static int[] ShowArray(int[] arr, bool show, bool nonParametr =  false)
    {
       var temp = 0; //временная переменная для храенения значения массива 
        for (int i = 0; i < arr.Length; i++) // заполнение элемента массива
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
        if (show == true) // если признак сортировки true, сортируем текущий массив
        {
            for (int k = 0; k < arr.Length - 1; k++)
            {
                for (int j = k + 1; j < arr.Length; j++)
                {
                    if (arr[k] > arr[j])
                    {
                        temp = arr[k];
                        arr[k] = arr[j];
                        arr[j] = temp;

                    }

                }
            }
            Console.WriteLine("Вывод отсортированного массива : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }


        return arr;

    }


 

    static void BigDataOperation(in int[] arr) //IN - этот модификатор защищает данные от изменения: в методе их изменить нельзя, но сам параметр при этом передается по ссылке.
    {
        arr[0] = 4;
    }


     static void ShowColor(string username, string[] favcolors)  //static - модификатор метода
    {

        Console.WriteLine("{0} \nНапишите свой любимый цвет на английском с маленькой буквы ", username);
        // var color = Console.ReadLine();

        foreach (var color in favcolors)
        {
            Console.ReadLine();


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
            
        }
    }
       
    

  
    static string GetDataFromConsole() => Console.ReadLine(); //работает только с методами где только одна операция

    static void ChangeAge(ref int age)
    {
        Console.WriteLine("Введите свой возраст:");
        age = Convert.ToByte(Console.ReadLine());
        ChangeAge(ref age);

    }


       } */
}
