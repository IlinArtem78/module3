using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    /*
     * Напишите программу, которая чистит нужную нам папку от файлов  и папок, которые не использовались более 30 минут
     * 
     * На вход программа принимает путь до папки. 

        При разработке постарайтесь предусмотреть возможные ошибки (нет прав доступа, папка по заданному адресу не существует, передан некорректный путь) и уведомить об этом пользователя.
     * 
     */
    public class module8_Hw1
    {
        public string dirName { get; set; }// @"D:\HW1";

        
        public module8_Hw1(string dirName)
        {
            this.dirName = dirName;
            TimeSpan thirtyMinutes = new TimeSpan(0, 30, 0);

            try
            {
                DirectoryInfo newDirectory = new DirectoryInfo(dirName);
              if (newDirectory.Exists) 
              { 
                FileInfo[] fls = newDirectory.GetFiles();
                DirectoryInfo[] dirs = newDirectory.GetDirectories(); 
                foreach (FileInfo fi in fls) 
                {
                    var dataTime = fi.CreationTime;
                    var dataTime2 = dataTime + thirtyMinutes;
                    if (dataTime < dataTime2)
                    {
                        fi.Delete();
                    }
                }
                foreach (DirectoryInfo di in dirs)
                {
                    var dataTime = di.CreationTime;
                    var dataTime2 = dataTime + thirtyMinutes;
                    if (dataTime < dataTime2)
                    {
                        di.Delete();
                    }
                }
                    Console.WriteLine("Операция выполнена, проверьте исходный каталог");
               }

            }
            catch (Exception e) {
                Console.WriteLine("Ошибка в выполнение удаления");    
                Console.WriteLine(e);
            }
        }

    }
}
