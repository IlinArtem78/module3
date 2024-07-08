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

            /* BaseClass baseClass = new BaseClass();
             baseClass.Display();
             DerivedClass derivedClass = new DerivedClass();
             derivedClass.Display(); 
          */


            Console.ReadKey();


        }
    }






    class BaseClass
    {
        public virtual int Counter
        {
            get;
            set;
        }
    }

    class DerivedClass : BaseClass
    {
        public override int Counter
        {
            get
            {
                return Counter;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Число должно быть больше 0");
                }
                else
                {
                    Counter = value;
                }
            }
        }








    }
}