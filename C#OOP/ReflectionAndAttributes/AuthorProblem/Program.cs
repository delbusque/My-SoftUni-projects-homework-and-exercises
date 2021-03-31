using System;

namespace AuthorProblem
{

    [Author("Ventsi")]
    public class StartUp
    {
        static void Main(string[] args)
        {
            var tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
        }

        [Author("Ventsi")]
        [Author("Goshso")]
        public void Hello()
        {

        }
    }
}
