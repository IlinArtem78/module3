using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Напишите программу, которая считает размер папки на диске (вместе со всеми вложенными папками и файлами). 
На вход метод принимает URL директории, в ответ — размер в байтах.

*/

namespace Module8
{
    public class Task2
    {
       
        public long Size(DirectoryInfo d)
        {
            long size = 0;
          
            try
            {
                
              if (d.Exists) { 
                FileInfo[] fls = d.GetFiles(); // Возвращает коллекцию строк только для чтения, представляющих имена путей к файлам в папке.
                foreach (FileInfo fi in fls)
                {
                    
                    size += fi.Length;
                }

                DirectoryInfo[] dirs = d.GetDirectories(); //Возвращает подкаталоги текущего каталога.
                foreach (DirectoryInfo di in dirs)
                {
                    
                    size += Size(di);

                }

              }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return size;
        }
    }
}
