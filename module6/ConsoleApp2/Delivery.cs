using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


/*
Вашей задачей будет развить и продолжить эту систему классов, чтобы она больше напоминала систему в реальном мире.

Здесь нет жестких рамок и все зависит от того, насколько вы хорошо поняли принципы ООП, и насколько хорошо сможете спроецировать реальные объекты в классы программы.

В качестве отправной точки, хотелось бы поделиться некоторыми советами по построению системы:

1) В качестве отправной точки всей системы вы можете оставить заказ (Order) или же сделать какой-то надкласс (MyOrders, OrderCollection или какой-то другой).
2) Систему стоит развивать вглубь, а не в ширину. То есть идти «внутрь» заказа и создавать связанные с ним сущности, а не уходить в «Настройки», «Личный кабинет» или что-то такое.
3) Заказ может содержать класс Product для описания товара. Либо же он может содержать несколько товаров, например, в массиве.
4) Вы можете создать какие-то общие используемые классы, которые облегчат работу, например, для адреса или мобильного телефона компании и прочего.
5) Для развития систем доставки следует обратить внимание на описание доставок в модуле:
5.1 HomeDelivery — доставка на дом. 
Этот тип будет подразумевать наличие курьера или передачу курьерской компании, в нем будет располагаться своя, отдельная от прочих типов доставки логика.
5.2 PickPointDelivery — доставка в пункт выдачи. Здесь будет храниться какая-то ещё логика, 
необходимая для процесса доставки в пункт выдачи, например, хранение компании и точки выдачи, а также какой-то ещё информации.
5.3 ShopDelivery — доставка в розничный магазин. 
Эта доставка может выполняться внутренними средствами компании и совсем не требует работы с «внешними&raquo; элементами.


*/
namespace HWmodule7
{
    abstract class Delivery 
    {
        public string Address; 
    }
    class HomeDelivery : Delivery
    {
       private bool Coureier; 
       public bool IsDelivery //наличие курьера 
        {
            get
            {
                return Coureier;
            }
            set {
            if  (value = true)
                {
                    Console.WriteLine("Курьер свободен доставка будет на дом");
                }
             else Coureier = value;
            }
      
        }
  //      public HomeDelivery()
    //    {
    //        Address = Console.ReadLine();
     //   }
    }
    //PickPointDelivery — доставка в пункт выдачи. Здесь будет храниться какая-то ещё логика, 
   // необходимая для процесса доставки в пункт выдачи, например, хранение компании и точки выдачи, а также какой-то ещё информации.
    class PickPointDelivery : Delivery
    {
        //В зависимости от загружеености и времени работы выбирается пункт выдачи 
        Company company1 = new Company() ;
        New_Company company2 = new New_Company();
        DateTime now = DateTime.Now; 
        public void PickPoint()
        {
            Console.WriteLine("Время похода за посылкой {0}", now.AddMinutes(40));
            company1.Adrress = Console.ReadLine(); //Адресс пункта выдачи вводит пользователь 
            company2.Adrress = Console.ReadLine(); // Адресс пункта выдачи вводит пользователь
            if (company1.NCompany(Address, now.AddMinutes(40)))
            {
                Console.WriteLine("Выбираем пункт выдачи компании 1");
            }
            else 
            {
                Console.WriteLine("Выбираем пункт выдачи компании 2"); 
            }

        } 
    }
 //   ShopDelivery — доставка в розничный магазин.
//Эта доставка может выполняться внутренними средствами компании и совсем не требует работы с «внешними элементами.

    class ShopDelivery : Delivery
    {
        /* ... */
    }

    class Order<TDelivery> where TDelivery : Delivery  //класс заказа
    {
        public TDelivery Delivery { get; set; }
  
        public int Number; 

        public string Description;

        public void DisplayAddress()
        {
            
                Console.WriteLine(Delivery.Address);

           

        }        
    }

    class Product<TDelivery> : Order<TDelivery> where TDelivery : Delivery
    {

        public string DescProduct; //Описание продукта
        public TDelivery Delivery; 
        
        public void Result()
        {
            
         Order<HomeDelivery> HomeOrder = new Order<HomeDelivery>();  
            
          HomeOrder.Description = DescProduct;
          HomeOrder.Number = Number;
          
          Order<PickPointDelivery> order = new Order<PickPointDelivery>();
          order.Number = Number;
          order.Description = DescProduct;  
          
          Order<ShopDelivery> ShopOrder = new Order<ShopDelivery>();
          ShopOrder.Description = DescProduct;
            ShopOrder.Number = Number;  
            
           
             
            
           
               
            }

        }

    }

    // класс Компания для обработки подходящего пункта выдачи.
 class Company
    {
 
        private string adrress = "ГлавПочтам";
        public virtual string Adrress  
        {
            get => adrress;
            set
            {  
                    adrress = value;
                
            }
        }                                // Адресс пунка выдачи, по умоплчанию ГлавПочтам 
       
        PunktLoad load = new PunktLoad(60); //Загрузка пункта выдачи
        DateTime h_start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 00, 00);   //Время начало работы 
        DateTime h_end = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 21, 00, 00);   //Конец работы                                                            //Загруженность пункта выдачи  

        public virtual bool NCompany(string Adrress, DateTime now) 
        {
            Adrress = Adrress; 
            if (now > h_start && now < h_end && load.load == 50) {

                return true;
            }
            else return false;
        }

    }


    class New_Company : Company  //Новая компания если не подойдет текущая 
    {
       // DateTime now = DateTime.Now; // ТЕКУЩЕЕ ВРЕМЯ
        PunktLoad load = new PunktLoad(60);
        DateTime h_start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 09, 00, 00);   //Время начало работы 
        DateTime h_end = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 22, 00, 00);   //Конец работы     
        public override string Adrress { get => base.Adrress; set => base.Adrress = value; }
        public override bool NCompany(string Adrress, DateTime now) 
        {
            
            if (now > h_start && now < h_end && load.load == 60)
            {
                return true;
            }
            else return false;
        }

    }
    public class PunktLoad //класс загрузка пункта выдачи. 
    {
        public int load; 
        public PunktLoad(int load)
        {
            Console.WriteLine("Загрузка пункта выдачи");
            this.load = load;

        }
        

    }


  

