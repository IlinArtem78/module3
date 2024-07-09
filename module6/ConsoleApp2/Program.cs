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
            Obj a = new Obj();
            Obj b = new Obj();
            Obj c = a + b;
            Obj d = a - b;



            Console.ReadKey();


        }
    }


    /*
    Создайте схему классов A, B, C, D и E таким образом, чтобы B наследовался от A, С от A, D от B и E от C. А также:

Добавьте в класс A виртуальный метод Display (void тип, без параметров), который будет выводить в консоль "A".
В классе B скройте этот метод и сделайте так, чтобы в консоль выводилось "B".
Для класса C переопределите метод Display, чтобы в консоли было "C".
Для D снова скройте метод.
В классе E также скройте метод.



*/
    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("A");
        }
    }
    class B : A
    {
        public new void Display()
        {
            Console.WriteLine("B");
        }
    }
    class C : A
    {
        public override void Display()
        {
            Console.WriteLine("C");
        }
    }

    class D : B
    {
        public new void Display()
        {
            Console.WriteLine("D");
        }
    }

    class E : C
    {
        public new void Display()
        {
            Console.WriteLine("E");
        }
    }

    /*
    Для класса Obj перегрузите операторы + и -, чтобы результатом работы оператора был новый экземпляр класса Obj, а операции производились над полем Value.


    */
    class Obj
    {
        public int Value;

        public static Obj operator +(Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value + b.Value
            };
        }
        public static Obj operator -(Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value - b.Value
            };
        }

        class Vector //образец класса в котором перезагружается операторы x,y
        {
            public int X;
            public int Y;
            public static Vector operator +(Vector a, Vector b)
            {
                return new Vector
                {
                    X = a.X + b.X,
                    Y = a.Y + b.Y
                };
            }
        }




    }
}
