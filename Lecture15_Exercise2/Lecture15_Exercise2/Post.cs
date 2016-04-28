using System;

namespace Lecture15_Exercise2
{
    public class Post
    {
        public int Votes { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public string Description { get; set; }

        public Post(string title)
        {
            Votes = 0;
            Title = title;
        }
    }
}