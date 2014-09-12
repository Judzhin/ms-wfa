using System;

class Program
{
    static void Main()
    {
        Myclass myClass = new Myclass("Первый");
        myClass = new Myclass("Второй");
    }
}

class Myclass
{
    String name;

    public Myclass(string name)
    {
        this.name = name;
    }
}