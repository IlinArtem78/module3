using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Module8
{
    
   
        // Описываем наш класс и помечаем его атрибутом для последующей сериализации
        [Serializable]
    class Pet
        {
            public string Name { get; set; }
             public int Age { get; set; }
public Pet(string name, int age)
            {
        Name = name;
        Age = age;
            }
        }
   
    
}
