// See https://aka.ms/new-console-template for more information
using CSharp13Playground;
using System.Text;

Console.WriteLine("Hello, World!");

// 1. Params collection enhancements
Disposer.DisposeAll<StringReader>(new("Hello"), new("World"));


