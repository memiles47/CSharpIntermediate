using System;
using System.Collections.Generic;

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

        public void CreatePost(List<Post> postList , string title, string description)
        {
            var index = postList.Count - 1;

            postList[index].Title = title;
            postList[index].Description = description;
        }
    }
}