using System;

namespace Lecture15_Exercise2
{
    public class Post
    {
        public static int Votes { get; set; }
        public static string Title { get; set; }
        public static DateTime DateCreated { get; set; }
        public static string Description { get; set; }

        public Post(string title)
        {
            Votes = 0;
            Title = title;
            DateCreated = DateTime.Now;
        }

        public static void CreatePost()
        {
            //Create a post with Title, DateCreated and the post itself the description
            Console.Write("Enter a Title: ");
            var input = Console.ReadLine()?.ToUpper() ?? "";

            if (input == "") return;

            var newPost = new Post(input);

            Console.Clear();
            Console.WriteLine($"Post Title: {Title}\nDate Created: {DateCreated}\n\nEnterPost: \n");
            Description = Console.ReadLine();
        }
    }
}