using System;

namespace Lecture15_Exercise2
{
    public class Post
    {
        public int Votes { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; private set; }
        public string Description { get; set; }

        public Post()
        {
            Votes = 0;
            DateCreated = DateTime.Now;
        }

        public void CreatePost(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}