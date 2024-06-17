﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;


class MainClass
{

    static void ShowColor(string username, params string[] favcolors)  //static - модификатор метода
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


    public static void Main(string[] args)
    {
   
        int n = 6;    
       var array = GetArrayFromConsole(ref n); //задание массива array
                                               //  var sortedarray = SortArray(array); //сортировка массива
                                               //  var sortedarray = ShowArray(array,true);

        //   ChangeAge(ref MyAge); // При передаче значений параметрам по ссылке метод получает адрес переменной в памяти.
        // И, таким образом, если в методе изменяется значение параметра, передаваемого по ссылке, то также изменяется и значение переменной,
        // которая передается на его место..


        GetAge(out )


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


    static void ChangeAge(ref int age)
    {
        Console.WriteLine("Введите свой возраст:"); 
        age = Convert.ToByte(Console.ReadLine()); 

    }

    static void BigDataOperation(in int[] arr) //IN - этот модификатор защищает данные от изменения: в методе их изменить нельзя, но сам параметр при этом передается по ссылке.
    {
        arr[0] = 4;
    }
}



