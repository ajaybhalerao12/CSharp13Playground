// See https://aka.ms/new-console-template for more information
using CSharp13Playground;
using System.Text;

Console.WriteLine("Hello, World!");

// 1. Params collection enhancements
Disposer.DisposeAll<StringReader>(new("Hello"), new("World"));

var persons = new List<Person> {
        new Person("Ajay", "Bhalerao"),
        new Person("Prashant", "Bhalerao"),
        new Person("Yash", "Bhalerao")
    };
//Disposer.DisposeAll<StringReader>(persons);
Display.DisplayItem<string>(persons.Select(p=>p.FirstName));


