using System; 

namespace ConsoleApp
{
    // Defines an interface with various features
    interface IMyInterface
    {
        // Instance method
        void DoSomething();

        // Property with getter and setter
        string MyString { get; set; }

        // Read-only property
        int MyInt { get; }

        // Event with a delegate
        event EventHandler MyEvent;

        // Indexer
        int this[int index] { get; set; }
    }

    // Defines a class that implements the interface
    class MyClass : IMyInterface
    {
        private string _myString;
        private int[] _myArray;

        // Implementation of the instance method from the interface
        public void DoSomething()
        {
            Console.WriteLine("Doing something...");
        }

        // Implementation of the property with getter and setter from the interface
        public string MyString
        {
            get { return _myString; }
            set { _myString = value; }
        }

        // Implementation of the read-only property from the interface
        public int MyInt { get; } = 42;

        // Implementation of the event with a delegate from the interface
        public event EventHandler MyEvent;

        // Implementation of the indexer from the interface
        public int this[int index]
        {
            get { return _myArray[index]; }
            set { _myArray[index] = value; }
        }

        // Constructor to initialize the private array
        public MyClass()
        {
            _myArray = new int[10];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of MyClass
            MyClass myObj = new MyClass();

            // Call the DoSomething method from the interface
            myObj.DoSomething();

            // Set and get the value of the MyString property from the interface
            myObj.MyString = "Hello, world!";
            Console.WriteLine(myObj.MyString);

            // Read the value of the MyInt property from the interface
            Console.WriteLine(myObj.MyInt);

            // Subscribe to the MyEvent event from the interface
            myObj.MyEvent += (sender, e) => Console.WriteLine("Event fired!");

            // Set and get values using the indexer from the interface
            myObj[0] = 10;
            Console.WriteLine(myObj[0]);
        }
    }
}
