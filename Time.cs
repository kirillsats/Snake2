using System;
using System.Diagnostics;
using System.IO;
using System.Threading; // Для задержки в основном потоке

namespace Snake2
{
    internal class Time

    {

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

        public void DisplayTime()
        {
            while (stopwatch.IsRunning)
            {
                Console.SetCursorPosition(2, 2); // Отображаем время в нужных координатах
                Console.WriteLine($"Прошло времени: {stopwatch.Elapsed.ToString(@"hh\:mm\:ss")}");
                Thread.Sleep(1000); // Задержка 1 секунда
            }
        }
        public string GetElapsedTime()
        {
            return stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
        }
    }
}