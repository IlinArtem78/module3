// See https://aka.ms/new-console-template for more information
global using Base;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Xml.Linq;


namespace module6
{
    //Для класса Bus реализуйте метод PrintStatus, который будет сообщать о количестве пассажиров в автобусе, если они есть. Или сообщать, что автобус пуст.

    class Program
    {
        public static void Main(string[] args)
        {
          //Car car = new Car();

            Company microsoft = new("Microsoft");
            Person tom = new("Tom", microsoft);
            tom.Print();
            // Console.WriteLine();


        }
    }

 

}
enum TurnDirection
{
    None = 0,
    Left,
    Right
}

class Car
{
    private double Fuel;

    private int Mileage;

    private string color;

    private TurnDirection turn;

    public Car()
    {
        Fuel = 50;
        Mileage = 0;
        color = "White";
    }

    private void Move()
    {
        // Move a kilometer
        Mileage++;
        Fuel -= 0.5;
    }

    private void Turn(TurnDirection direction)
    {
        turn = direction;
    }

    public void FillTheCar()
    {
        Fuel = 50;
    }

    public string GetColor()
    {
        return color;
    }

    public void ChangeColor(string newColor)
    {
        if (color != newColor)
            color = newColor;
    }

    public bool IsTurningLeft()
    {
        return turn == TurnDirection.Left;
    }

    public bool IsTurningRight()
    {
        return turn == TurnDirection.Right;
    }
}



