// See https://aka.ms/new-console-template for more information

using System.IO;

namespace module8
{
    class Program
    {
        // Допустим, нам нужно создать файл и записать в него информацию, в коде выполним следующие действия: 

        // Проверим существование файла
        ///Если не существует, создадим его и запишем строку.
        //Откроем файл и прочитаем ранее записанную строку.
        static void Main(string[] args)
        {
            string tempFile = @"C:\Users\User\source\repos\module3\Module8\Module8\Program.cs"; //Path.GetTempFileName(); // используем генерацию имени файла.
            var fileInfo = new FileInfo(tempFile); // Создаем объект класса FileInfo.
            DateTime dateTime = DateTime.Now;
           

            //Открываем файл и читаем из него.
           
            Console.WriteLine(); 
            /*
            Сделайте так, чтобы ваша программа из задания 8.3.1 при каждом запуске добавляла в свой исходный код комментарий о времени последнего запуска. 
            tring tempFile2 = Path.GetTempFileName();
                var fileInfo2 = new FileInfo(tempFile2);

                // Убедимся, что файл назначения точно отсутствует
                fileInfo2.Delete();

                // Копируем информацию
                fileInfo.CopyTo(tempFile2);
                Console.WriteLine($"{tempFile} скопирован в файл {tempFile2}.");
                //Удаляем ранее созданный файл.
                fileInfo.Delete();
                Console.WriteLine($"{tempFile} удален.");
            */

            try
            {
                using (StreamWriter sr = fileInfo.AppendText())
                {
                    sr.WriteLine($"G: {dateTime:G}");
                }
                using (StreamReader sr = fileInfo.OpenText())
                {
                    string str = "";
                    while ((str = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(str);
                    }
                }



            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e}");
            }


        }
    }
}




G: 17.07.2024 13:26:27
