using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    /*
     Доработайте программу из задания 1, используя ваш метод из задания 2.

    При запуске программа должна:

    1) Показать, сколько весит папка до очистки. Использовать метод из задания 2. 
    2) Выполнить очистку.
    3) Показать сколько файлов удалено и сколько места освобождено.
    4) Показать, сколько папка весит после очистки. 
    
     */
    public class Task3
    {
        public string dirName {  get; set; }
        
        public long Size(DirectoryInfo d) // 1 
        {
            long size = 0;
            int num_fl = 0;
            int num_dirs = 0;
            try
            {

                if (d.Exists)
                {
                    FileInfo[] fls = d.GetFiles(); // Возвращает коллекцию строк только для чтения, представляющих имена путей к файлам в папке.
                    foreach (FileInfo fi in fls)
                    {
                        num_fl++;
                        size += fi.Length;
                    }

                    DirectoryInfo[] dirs = d.GetDirectories(); //Возвращает подкаталоги текущего каталога.
                    foreach (DirectoryInfo di in dirs)
                    {
                        num_dirs++;
                        size += Size(di);
                    }
                    Console.WriteLine("Исходный размер {0} байт", size);
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (size > 0)
            {
                DeleteF();
                Console.WriteLine("Освобождено {0} байт", size);
                Console.WriteLine("Удалено папок {0} и файлов {1}", num_dirs, num_fl);
                Console.WriteLine("Текущий размер папки {0} байт", size - size); 
                return size;
            }
            
            return size;
        }


        public void DeleteF()
        {
        try
            {

            DirectoryInfo newDirectory = new DirectoryInfo(dirName);
            if (newDirectory.Exists)
            {
                FileInfo[] fls = newDirectory.GetFiles();
                DirectoryInfo[] dirs = newDirectory.GetDirectories();
                foreach (FileInfo fi in fls)
                {
                  
                        fi.Delete();
            
                }
                foreach (DirectoryInfo di in dirs)
                {
                    
                    
                        di.Delete();
                    
                }
                
            }

        }
            catch (Exception e) {
                Console.WriteLine("Ошибка в выполнение удаления");    
                Console.WriteLine(e);
            }
}



    }
}
