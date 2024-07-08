// See https://aka.ms/new-console-template for more information
global using Base;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Net.Security;
using System.Runtime.InteropServices.Marshalling;
using System.Xml.Linq;


namespace module6
{
    //Для класса Bus реализуйте метод PrintStatus, который будет сообщать о количестве пассажиров в автобусе, если они есть. Или сообщать, что автобус пуст.

    class Program
    {
        public static void Main(string[] args)
        {

             
             DerivedClass derivedClass = new DerivedClass();
             derivedClass.Display(); 
          


            Console.ReadKey();


        }
    }






    class BaseClass
    {
        public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Метод класса DerivedClass");
        }
    }








}
