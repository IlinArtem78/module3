using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    static class MYExtenssionc
    { 
        public static void Print(this DateTime dateTime)
        {
            Console.WriteLine(dateTime);
        }




        /*Для класса int создайте 2 метода расширения: GetNegative() и GetPositive().

Метод GetNegative должен возвращать отрицательное значение переменной (если оно положительно), либо саму переменную (если оно отрицательно или равно 0).

Метод GetPositive должен, наоборот, возвращать положительное значение (если оно отрицательно), либо саму переменную (если оно положительно или равно 0).

Иными словами, для вашего метода должен будет корректно выполняться следующий код:


        */

        public static int GetNegative(this int N) 
        {
         if (N > 0) 
          {
               return - N; 
             
           }
         else 
            {
                return N; 
            }

        }
        public static int GetPositive(this System.Int32 N)
        {
            if (N < 0)
            {
               return - N;
             
            }
            else { return N;}

        }
    }
}
