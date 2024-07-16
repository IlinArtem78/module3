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
using HWmodule7;
using System.Security.Cryptography.X509Certificates;


namespace module6
{
    //Для класса Bus реализуйте метод PrintStatus, который будет сообщать о количестве пассажиров в автобусе, если они есть. Или сообщать, что автобус пуст.

    class Program
    {
        public static void Main(string[] args)
        {
            byte st = Work();

        }
        

        public static byte Work()
        {
            Console.WriteLine("Выбирите способо доставки товара 0 - курьер, 1 - пункт выдачи, 2 - магазин");
            byte inNum = byte.Parse(Console.ReadLine());
            switch (inNum)
            {
                case 0:
                    Product<HomeDelivery> product = new Product<HomeDelivery>();
                    product.DescProduct = "Игровая приставка";
                    product.Description = "Почтовое отправление";
                    product.Delivery = new HomeDelivery();    //объевление класса. Инциализация.
                    product.Number = 128745;
                    product.Delivery.IsDelivery = true; // доставка осуществляется курьером. 
                    Console.WriteLine("Введите адресс вашего дома:");
                    product.Delivery.Address = Console.ReadLine();
                    Console.WriteLine("Ваш адресс доставки {0}", product.Delivery.Address);
                    return inNum;
                    break;
                case 1:
                    Product<PickPointDelivery> Punkt = new Product<PickPointDelivery>();
                    Punkt.Number = 128745;
                    Punkt.Delivery = new PickPointDelivery();
                    Punkt.Delivery.PickPoint();
                    return inNum;
                    break;
                case 2:
                    Product<ShopDelivery> shop = new Product<ShopDelivery>();   
                    shop.Delivery = new ShopDelivery(); 
                    return inNum;   
                    break;

                default:
                    Console.WriteLine("Вы ввели невернное число {0}", inNum);
                    return Work();
                    break;
            }
        }


    }


}
