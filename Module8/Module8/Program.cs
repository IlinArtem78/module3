// See https://aka.ms/new-console-template for more information

namespace module8
{
    class Program
    {
        static void Main(string[] args)
        {

            GetCatalogs();
            // получим системные диски
            DriveInfo[] drives = DriveInfo.GetDrives();

            // Пробежимся по дискам и выведем их свойства
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Объем: {drive.TotalSize}");
                    Console.WriteLine($"Свободно: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Метка: {drive.VolumeLabel}");
                }
            }
        }
        static void GetCatalogs()
        {
            int k = 0; 
            int t = 0; 
            string dirName = @"C:\"; // Прописываем путь к корневой директории MacOS (для Windows скорее всего тут будет "C:\")
            if (Directory.Exists(dirName)) // Проверим, что директория существует
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога

                foreach (string d in dirs) // Выведем их все
                { Console.WriteLine(d);
                    k++;
                    
                }
                Console.WriteLine("Количество папок {0}", k);
                Console.WriteLine();

                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);// Получим все файлы корневого каталога

                foreach (string s in files)   // Выведем их все
                {
                    Console.WriteLine(s);
                    t++;
                   
                }
                Console.WriteLine("Количество файлов {0}", t);

            }

        }

    }
}
