using System;

namespace SampleCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            PhotoProcessor process = new PhotoProcessor();
            Filters fliters = new Filters();
            Action<Photo> filtersDelegate = fliters.ApplyBrightness;

          //  PhotoProcessor.PhotoProcessorDelegate filtersDelegate = fliters.ApplyBrightness;
            filtersDelegate += fliters.contrast;
            process.PhotoProcess("abc", filtersDelegate);
            Console.ReadLine();
        }
    }
}
