using System;
using System.IO; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{

    /*
    Класс DirectoryInfo
    Данный класс предоставляет функциональность для создания, удаления, перемещения и других операций с каталогами. 
    Во многом он похож на Directory, но не является статическим.

    для работы с файлами предназначена пара классов File и FileInfo. 
    С их помощью мы можем создавать, удалять, перемещать файлы, получать их свойства и многое другое.


   


    */
    public static class DirectoryExtension
    {

        public static long DirSize(DirectoryInfo d)
        {
            long size = 0;
            FileInfo[] fls = d.GetFiles(); // Возвращает коллекцию строк только для чтения, представляющих имена путей к файлам в папке.
            foreach (FileInfo fi in fls)
            {
                size += fi.Length;
            }

            DirectoryInfo[] dirs = d.GetDirectories(); //Возвращает подкаталоги текущего каталога.
            foreach (DirectoryInfo di in dirs) 
            { 
                size += DirSize(di);
            
            }


            return size;
        }

    }
}
