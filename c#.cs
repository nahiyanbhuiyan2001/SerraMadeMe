using System;

interface IExample
{
    int Property1 { get; set; }
    string Property2 { get; set; }
    DateTime Property3 { get; set; }
}

class Example : IExample
{
    public int Property1 { get; set; }
    public string Property2 { get; set; }
    public DateTime Property3 { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Example example = new Example
        {
            Property1 = 42,
            Property2 = "Hello, world!",
            Property3 = DateTime.Now
        };

        Console.WriteLine("Property1: " + example.Property1);
        Console.WriteLine("Property2: " + example.Property2);
        Console.WriteLine("Property3: " + example.Property3);
    }
}

