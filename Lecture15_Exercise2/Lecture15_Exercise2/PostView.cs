using System;

namespace Lecture15_Exercise2
{
    class PostView
    {
        public void ViewPost(Post post)
        {
            Console.Clear();
            Console.WriteLine($"Title: {post.Title}");
            Console.WriteLine($"Description: {post.Description}");
            Console.WriteLine($"Creation Date: {post.DateCreated:d}");
            Console.WriteLine($"Number of votes: {post.Votes}");
            Console.Write("\n\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}