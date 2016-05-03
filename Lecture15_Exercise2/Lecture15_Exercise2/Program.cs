using System;
using System.Collections.Generic;

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
     * Issues:
     * 1) Correct location of created Post. Currently the scope of the created object is too limited
     * 2)
     */

    class Program
    {
        static void Main()
        {
            var input = "";
            var postList = new List<Post>();
            var viewPost = new PostView();
            var vote = new Votes();


            while (input != "quit")
            {
                Console.Clear();
                Console.Write("Create post or View post, press \"C\" or \"V\" or \"Quit\": ");
                input = Console.ReadLine()?.ToLower() ?? "";

                if (input == "c")
                {
                    Console.Clear();
                    Console.Write("Enter Post Title: ");
                    var title = Console.ReadLine()?.ToUpper();

                    Console.Write("Enter Post Description: ");
                    var description = Console.ReadLine();

                    postList.Add(new Post());
                    postList[0].CreatePost(title, description);
                }

                if (input == "v")
                {
                    viewPost.ViewPost(postList[0]);
                }

                if (input == "u" || input == "d")
                {
                    vote.Voting(postList[0], input);
                }
            }
        }
    }
}
