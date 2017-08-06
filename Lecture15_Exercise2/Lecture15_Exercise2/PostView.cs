using System;
using System.Collections.Generic;

namespace Lecture15_Exercise2
{
    class PostView
    {
        public void PostViewer(List<Post> postList)
        {
            var index = postList.Count;

            if (index == 1)
                Viewer(postList, index - 1);
            else
            {
                Console.Clear();
                Console.WriteLine($"Item\t\t Title");
                var postNumber = 1;

                foreach (var post in postList)
                {
                    Console.WriteLine($"{postNumber}\t\t{post.Title}");
                    postNumber ++;
                }

                Console.Write("\nWhich post do you want to view? ");
                var postToView = Convert.ToInt32(Console.ReadLine()) - 1;

                Viewer(postList, postToView);
            }
        }

        private static void Viewer(List<Post> postList, int index)
        {
            try
            {
                Console.Clear();
                Console.WriteLine($"Title: {postList[index].Title}");
                Console.WriteLine($"Description: {postList[index].Description}");
                Console.WriteLine($"Creation Date: {postList[index].DateCreated:d}");
                Console.WriteLine($"Number of votes: {postList[index].Votes}");
                Console.Write("\n\nPress any key to continue...");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("You picked an incorrect number");
                Console.Write("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}