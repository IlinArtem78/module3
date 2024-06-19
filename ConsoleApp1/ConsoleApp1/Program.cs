// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;


class MainClass
{




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
   
        public static void Main(string[] args)
        {
           // Console.WriteLine("Напишите что-то");

           // var str = Console.ReadLine();

           // Console.WriteLine("Укажите глубину эха");

           // var deep = int.Parse(Console.ReadLine());

           //     Echo(str,deep);
        decimal A = Factorial(20); 
        Console.WriteLine("Значение факториала = {0}", A);
            
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
    static void GetAge(out string Name, out byte Age)
    {
        Name = Console.ReadLine(); 
        Age = Convert.ToByte(Console.ReadLine());
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
}



