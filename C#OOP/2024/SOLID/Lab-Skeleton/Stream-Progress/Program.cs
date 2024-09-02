using System;

namespace StreamProgress
{
    public class Program
    {
        static void Main()
        {
            IProgressable song = new Music("Ed Sheeran", "Shape of You", 300, 30);

            StreamProgressInfo info = new StreamProgressInfo(song);

            while(song.BytesSent < song.Length){
                Console.WriteLine(info.CalculateCurrentPercent());
            }

        }
    }
}
