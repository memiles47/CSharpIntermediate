using System;

namespace Inheritance

{
    //Demonstration of inheritance to compare to Composition
    internal static class Program
    {
        private static void Main()
        {
            var text = new Text {Width = 100};

            text.Copy();
            Console.WriteLine($"The Width of this text is {text.Width}");
        }
    }
}
