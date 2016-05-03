namespace Lecture15_Exercise2
{
    public class Votes
    {
        public void Voting(Post post, string vote)
        {
            //Up vote for a post
            if (vote == "u")
                post.Votes ++;
            else
                post.Votes --;
        }
    }
}