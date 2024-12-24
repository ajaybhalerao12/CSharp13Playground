using System.Collections.Immutable;

namespace CSharp13Playground
{
    internal static class Disposer
    {
        public static void DisposeAll<T>(ImmutableArray<T> disposables)
                 where T : IDisposable
        {
            foreach (var disposable in disposables) { 
                disposable.Dispose();
            }
        }

        public static void DisposeAll<T>(IEnumerable<T> disposables)
            where T : IDisposable
        {
            foreach (var disposable in disposables)
            {
                disposable.Dispose();
            }
        }

        public static void DisposeAll<T>(params ReadOnlySpan<T> disposables)
           where T : IDisposable
        {
            foreach (var disposable in disposables)
            {
                disposable.Dispose();
            }
        }
    }

    internal static class Display
    {
        //public static void DisplayItem(params IEnumerable<string> names)
        //    => Console.WriteLine(String.Join(", ", names));

        public static void DisplayItem<T>(params IEnumerable<T> names)
            => Console.WriteLine(String.Join(", ", names));

    }
    public record Person(string FirstName,string LastName);
}
