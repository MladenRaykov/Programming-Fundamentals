using System;

namespace _19TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
			int picturesTaken = int.Parse(Console.ReadLine());
            long filterTimePerPic = long.Parse(Console.ReadLine()); // seconds
            double totalPicturesPerc = double.Parse(Console.ReadLine()); // in percents
            long timeNeeded = long.Parse(Console.ReadLine());

            int totalFilteredPictures = (int)Math.Ceiling(picturesTaken * (totalPicturesPerc / 100));
            long totalFilterTime = picturesTaken * filterTimePerPic; //sec
            long uploadTime = totalFilteredPictures * timeNeeded;
            long totalTime = totalFilterTime + uploadTime; //sec
            TimeSpan time = TimeSpan.FromSeconds(totalTime);

            Console.WriteLine("{0}:{1:d2}:{2:d2}:{3:d2}", time.Days, time.Hours, time.Minutes, time.Seconds);


            /* друг вариант:
             * int secNeeded = totalTimeNeeded % 60;
             * int minutesNeeded = (totalTimeNeeded - secNeeded) / 60 % 60;
             * int hoursNeeded = (totalTimeNeeded - secNeeded - minutesNeeded * 60) / 3600;
             * int daysNeeded = (totalTimeNeeded - secNeeded - minutesNeeded * 60 - hoursNeeded * 360) / 86400;
            */
        }
    }
}
