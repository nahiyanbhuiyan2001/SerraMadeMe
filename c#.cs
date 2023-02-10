using System;
//This example implements an interface IExample with three properties: Property1 is type int, Property2 is type string, and Property3 is type DateTime.
//The class Example implements the interface IExample and shows an implementation for the properties defined in the interface.
//In the Main method, I created an instance of Example and have given values to its properties, which are printed to the console.

namespace Test
{
    interface IExample
    {
        int Prop1 { get; set; }
        string Prop2 { get; set; }
        DateTime Prop3 { get; set; }
    }

    class Example : IExample
    {
        public int Prop1 { get; set; }
        public string Prop2 { get; set; }
        public DateTime Prop3 { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Example example = new Example
            {
                Prop1 = 42,
                Prop2 = "Hello, world!",
                Prop3 = DateTime.Now
            };
            Console.WriteLine("Prop1: " + example.Prop1);
            Console.WriteLine("Prop2: " + example.Prop2);
            Console.WriteLine("Prop3: " + example.Prop3);
        }
    }
}

