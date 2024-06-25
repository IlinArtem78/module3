using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base { 

class Company
{
    string title;
    public Company(string title) => this.title = title;
    public void Print() => Console.WriteLine($"Компания: {title}");
}
}