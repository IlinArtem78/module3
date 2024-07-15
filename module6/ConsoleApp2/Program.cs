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


namespace module6
{
    //Для класса Bus реализуйте метод PrintStatus, который будет сообщать о количестве пассажиров в автобусе, если они есть. Или сообщать, что автобус пуст.

    class Program
    {
        public static void Main(string[] args)
        {


            DateTime currentDate = DateTime.Now;
            currentDate.Print();

            int num1 = 7;
            int num2 = -13;
            int num3 = 0;

            Console.WriteLine(num1.GetNegative()); //-7
            Console.WriteLine(num1.GetPositive()); //7
            Console.WriteLine(num2.GetNegative()); //-13
            Console.WriteLine(num2.GetPositive()); //13
            Console.WriteLine(num3.GetNegative()); //0
            Console.WriteLine(num3.GetPositive()); //0



            Console.ReadKey();


        }
    }

    //Измените класс Obj так, чтобы статические поля инициализировались в статическом конструкторе:

    class Obj
    {
        public string Name;
        public string Description;

        public static string Parent;
        public static int DaysInWeek;
        public static int MaxValue;

        static Obj()
        {
            DaysInWeek = 7;
            MaxValue = 2000;
            Parent = "System.Object";
        }
    }

    //Создайте класс-обобщение Car для автомобиля. Универсальным параметром будет тип двигателя в автомобиле (электрический и бензиновый).
    //Для типов двигателей также создайте классы — ElectricEngine и GasEngine.
   // В классе Car создайте поле Engine в качестве типа которому укажите универсальный параметр.

    class car <T1> where T1 : Engine
                       
    {
        public T1 Engine ; 

        public virtual void changePart <T2> (T2 newPart) where T2 : CarPart
        {
            
        }

    }

    abstract class Engine
    {

    }
    class ElectricEngine : Engine
    {

    }

    class GasEngine : Engine    
    {

    }

    abstract class CarPart
    {

    }

    class Battery : CarPart
    {

    }

    class Differential : CarPart
    {

    }

    class Wheel : CarPart
    {

    }











    class Record <T1, T2>
    {
        public T1 Id;
        public T2 Value;
        public DateTime Date; 
    }




}
