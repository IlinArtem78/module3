using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.Design;
using System.Xml.Linq;
using System.Security.Authentication;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;
using System.Text.Json;
using System.IO;


/*
 * 
 * Написать программу-загрузчик данных из бинарного формата в текст.

    На вход программа получает бинарный файл, предположительно, это база данных студентов.

    Свойства сущности Student:

    Имя — Name (string);
    Группа — Group (string);
    Дата рождения — DateOfBirth (DateTime).
    Средний балл — (decimal).
    Ваша программа должна:

    Cчитать данные о студентах из файла; +
    Создать на рабочем столе директорию Students. +
       Внутри раскидать всех студентов из файла по группам (каждая группа-отдельный текстовый файл), 
        в файле группы студенты перечислены построчно в формате "Имя, дата рождения, средний балл".
 * 
 * 
 */


namespace Module8
{
    public class Task4
    {
        public string SettingsFileName;
        public string path = @"C:\Users\Public\Documents\Student";
        public Task4(string SettingFileName)
        {
            this.SettingsFileName = SettingFileName;
            string path1 = "C:\\Users\\Public\\Documents\\Student\\OneGroup.txt";
            string path2 = "C:\\Users\\Public\\Documents\\Student\\TwoGroup.txt";

         //   string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

            //   string path1 = "C:\\Users\\User\\Desktop\\Student\\";
            if (!Directory.Exists(path))
            {  Directory.CreateDirectory(path);
               
            }   
            else
            {
                Console.WriteLine("Папка уже создана");
            }
            
            if (File.Exists(SettingsFileName)) //если существует бинарный файл, то^
            {

                List<Student> Students = new List<Student>(); //инциализация листа для работы с классом

                // Создаем объект BinaryReader и инициализируем его возвратом метода File.Open.
                using (BinaryReader reader = new BinaryReader(File.Open(SettingsFileName, FileMode.Open)))
                {
                    // Применяем специализированные методы Read для считывания соответствующего типа данных.

                    while (reader.PeekChar() > -1) // Пока не кончатся строки - считываем из файла по одной и выводим в консоль
                    {
                        Student Gr = new Student();
                        Gr.Name = reader.ReadString();
                        Gr.Group = reader.ReadString();
                        long dt = reader.ReadInt64();
                        Gr.DateOfBirth = DateTime.FromBinary(dt);
                        Gr.AverBall = reader.ReadDecimal();
                        // BooleanValue = reader.ReadBoolean();
                        Students.Add(Gr);
                    }

                }






                foreach (Student student in Students)
                {
                    Console.WriteLine($"Name: {student.Name}  Group: {student.Group}   AverBall : {student.AverBall} DateOfBirth  {student.DateOfBirth}");

                }

                for (int i = 0; i < Students.Count - 1; i++)
                {
                    if (Students[i].Group == Students[i + 1].Group)
                    {
                          
                        Console.WriteLine("Группы одинаковый, создается текстовый файл");
                        try
                        {
                            // File StreamWriter writer = new StreamWriter(path, true)

                           
                            using (StreamWriter sw = new StreamWriter(path1, true, System.Text.Encoding.Default))
                            {
                                sw.WriteLine(Students[i].Name);
                                sw.WriteLine(Students[i].DateOfBirth);
                                sw.WriteLine(Students[i].AverBall);
                                sw.WriteLine(Students[i+1].Name); 
                                
                                sw.WriteLine(Students[i+1].DateOfBirth);
                               
                                sw.WriteLine(Students[i+1].AverBall);
                                


                               sw.Close();
                            }

                            

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                             
                        }

                    }
                    else
                    {
                        Console.WriteLine("Люди участься в разных. не добавляем их в файл");
                        path1 = path2;
                    }

                }
            
        }
            else
            {
                Console.WriteLine("Указан неверный путь до исходного бинарного файлая. Проверьте путь!");
            }

        }

       



    }




}




