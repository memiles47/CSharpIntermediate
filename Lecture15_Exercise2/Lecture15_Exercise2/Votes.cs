using System.Collections.Generic;

namespace Lecture15_Exercise2
{
    public class Votes
    {
        public void PostVoting(List<Post> postList , string vote)
        {
            var index = postList.Count - 1;

            if (vote == "u")
                postList[index].Votes ++;
            else
                postList[index].Votes --;
        }
    }
}