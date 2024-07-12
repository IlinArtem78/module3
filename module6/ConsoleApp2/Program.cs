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
            int num1 = 3;
            int num2 = 58;

            Helper.Swap(ref num1, ref num2);
            /*передача num1 и num2 в метод*/
            

            Console.WriteLine(num1); //58
            Console.WriteLine(num2); //3  


            Console.ReadKey();


        }
    }

    /*
    Создайте классы для следующих объектов компьютера: процессор (Processor), материнская карта (MotherBoard), видеокарта (GraphicCard). Унаследуйте их от класса ComputerPart.

    Добавьте в класс ComputerPart абстрактный метод Work без параметров и с типом void.



    */
    abstract class ComputerPart
    {

        public abstract void Work();
        
    }

    class Processor : ComputerPart
    {
        public override void Work()
        {

        }
    }

    class MotherBoard : ComputerPart
    { public override void Work() { } }


    class GraphicCard : ComputerPart { public override void Work() { } }


    /*
    Создайте класс Helper и определите в нем статический метод Swap типа void, который принимает 2 переменные типа int и меняет их значения местами.

    Иными словами, для вашего метода должен будет корректно выполняться следующий код:
    */


    class Helper
    {
       
        public static void Swap(ref int a, ref int b)
        {
            int num = a; //3
            a = b;
            b = num;
        }
    }
}
