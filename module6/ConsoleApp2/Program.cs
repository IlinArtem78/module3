// See https://aka.ms/new-console-template for more information
global using Base;
using ConsoleApp2;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Transactions;
using System.Xml.Linq;
using ConsoleApp2;
using HWmodule7; 


namespace module6
{
    //Для класса Bus реализуйте метод PrintStatus, который будет сообщать о количестве пассажиров в автобусе, если они есть. Или сообщать, что автобус пуст.

    class Program
    {
        public static void Main(string[] args)
        {
            Product<HomeDelivery> product = new Product<HomeDelivery>();
            product.DescProduct = "Игровая приставка";
            product.Description = "Почтовое отправление";
            if (product.Delivery != null)
            {

                if (product.Delivery.IsDelivery != true)
                {
                    Console.WriteLine("Выберите другой способ доставки не курьером");
                }
                product.Delivery.IsDelivery = true;
                
                
            }

            Console.WriteLine("Введите адресс вашего дома:");
            product.Delivery.Address = Console.ReadLine();


            Console.WriteLine("Адресс вашего дома {0}", product.Delivery.Address);
           // product.Result();
           // product.DisplayAddress();



        }
    }

   



}
