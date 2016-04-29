using System;

namespace Lecture15_Exercise2
{
    /*
     * Design a class called Post. This class models a StackOverflow post. It should have properties
     * for title, description and the date/time it was created. We should be able to up-vote or down-vote
     * a post. We should also be able to see the current vote value. In the main method, create a post,
     * up-vote and down-vote it a few times and then display the current vote value.
     * In this exercise, you will lean that a StackOverflow post should provide methods for up-voting
     * and down-voting. You should not give the ability to set the Vote Property from the outside
     * because otherwise, you may accidentally change the votes of a class to 0 or to a random
     * number and this is how we create bugs in our programs. The class should always protect its
     * state and hide its implementation detail.
     * 
     * Issues: None
     */

    class Program
    {
        static void Main()
        {
            Console.Write("Create a post or View a post, press \"C\" or \"V\": ");
            var input = Console.Read();

            Console.WriteLine($"ASCII for character entered: {input}");


        }
    }
}
