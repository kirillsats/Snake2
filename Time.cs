using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Snake2
{
    internal class Time
    {
        private bool isDisplayingTime = false;

        public void DisplayTime()
        {
            if (isDisplayingTime) return;

            isDisplayingTime = true;
            Console.Clear();
            Console.SetCursorPosition(0, 0);

            while (stopwatch.IsRunning)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write($"Teie aeg: {stopwatch.Elapsed.ToString(@"hh\:mm\:ss")}");
                Thread.Sleep(1000);
            }

            isDisplayingTime = false;
            
        }

        private Stopwatch stopwatch;
        private string fileName;

        public Time(string fileName)
        {
            stopwatch = new Stopwatch();
            this.fileName = fileName;
        }

        public void Start()
        {
            stopwatch.Start();
        }

        public void Stop()
        {
            stopwatch.Stop();
            WriteTimeToFile();
        }

        public void WriteTimeToFile()
        {
            string elapsedTime = stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
            File.AppendAllText(fileName, $"Game Duration: {elapsedTime}\n");
        }

        

        public string GetElapsedTime()
        {
            return stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
        }
    }
}
