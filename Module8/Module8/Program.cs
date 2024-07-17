// See https://aka.ms/new-console-template for more information

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
            string filePath = @"C:\Users\User\source\repos\module3\Module8\Module8\Program.cs"; // Укажем путь  C:\Users\User\source\repos\module3\Module8\Module8\Program.cs
            if (!File.Exists(filePath)) // Проверим, существует ли файл по данному пути
            {
                //   Если не существует - создаём и записываем в строку
                using (StreamWriter sw = File.CreateText(filePath))  // Конструкция Using (будет рассмотрена в последующих юнитах)
                {
                    sw.WriteLine("Олег");
                    sw.WriteLine("Дмитрий");
                    sw.WriteLine("Иван");
                }
            }
            // Откроем файл и прочитаем его содержимое
            using (StreamReader sr = File.OpenText(filePath))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null) // Пока не кончатся строки - считываем из файла по одной и выводим в консоль
                {
                    Console.WriteLine(str);
                }
            }

        }
       

    }
}



