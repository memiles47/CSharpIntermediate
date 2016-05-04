namespace Lecture15_Exercise2
{
    public class Votes
    {
        public void Voting(Post post, string vote)
        {
            if (vote == "u")
                post.Votes ++;
            else
                post.Votes --;
        }
    }
}