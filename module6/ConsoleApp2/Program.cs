// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace module6
{
    //Для класса Bus реализуйте метод PrintStatus, который будет сообщать о количестве пассажиров в автобусе, если они есть. Или сообщать, что автобус пуст.

    class Program
    {
        public static void Main(string[] args)
        {
            int i = 123;
            // Упаковка значения i в объект o
            object o = i;
            // Распаковка o
            int j = (int)o;



            Console.WriteLine(o);


        }
    }

  class Treug
    {
        public static int a, b, c;

        static int P_Treug()
        {
            var P = a + b + c; 
            return P;
        }



        static double S_Treug()
        {

            var p = Treug.P_Treug()/2;
            var S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));  
            return S;
        }


    }
    class Krug()
    {
        public static int r;
        static double S_Kruga()
        {
            var S = Math.PI * r*r;
            return S;
        }

        static double L_Kruga()
        {
            var L = 2*Math.PI * r;
            return L;

        }
    }

    class Kvadrat()
    {
        public static int a;
        static double S_Kvadrat()
        {
            var S = a * a;
            return S;
        }
        static double P_Kvadrata()
        {
            var P = 4 * a;
            return P;
        }



    }

}