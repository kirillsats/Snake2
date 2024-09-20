using System;
using System.Diagnostics;
using System.IO;
using System.Threading; // Для задержки в основном потоке

namespace Snake2
{
    internal class Time
    {
        public Stopwatch Stopwatch { get; private set; }
        public string FileName { get; private set; }

        public Time(string fileName)
        {
            Stopwatch = new Stopwatch();
            FileName = fileName;
        }

        public void Start()
        {
            Stopwatch.Start();
        }

        public void Stop()
        {
            Stopwatch.Stop();
            WriteTimeToFile();
        }

        public void WriteTimeToFile()
        {
            string elapsedTime = Stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
            File.AppendAllText(FileName, $"Game Duration: {elapsedTime}\n");
        }

        // Для вывода времени на экран каждую секунду
        public void DisplayTime()
        {
            while (Stopwatch.IsRunning)
            {
                Console.Clear();
                Console.WriteLine($"Прошло времени: {Stopwatch.Elapsed.ToString(@"hh\:mm\:ss")}");
                Thread.Sleep(1000); // Задержка 1 секунда
            }
        }
    }
}