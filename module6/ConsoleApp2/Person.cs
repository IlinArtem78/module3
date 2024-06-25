using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Person
{
    string name;
    Company company;
    public Person(string name, Company company)
    {
        this.name = name;
        this.company = company;
    }
    public void Print()
    {
        Console.WriteLine($"Имя: {name}");
        company.Print();
    }
}