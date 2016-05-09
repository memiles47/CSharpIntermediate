using System;

namespace StackExercise
{
    internal class Program
    {
        private static void Main()
        {
            var stack = new Stack();

            //Push three integers onto the stack
            for (var i = 1; i <= 3; i++)
            {
                stack.Push(i);
            }

            //Pop three objects from stack
            for (var i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Popped Object: {stack.Pop()}"); 
            }

            //Clear has no function as the pop deleted them
            stack.Clear();
            Console.WriteLine("Stack has been cleared");
        }
    }
}