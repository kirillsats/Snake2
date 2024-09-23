using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    internal class Score
    {
        private int score;
        private const int pointsPerFood = 5; // Очки за каждую съеденную еду

        public Score()
        {
            score = 0;
        }

        public void AddPoints()
        {
            score += pointsPerFood;
        }

        public int GetScore()
        {
            return score;
        }

        public void DisplayScore()
        {
            Console.SetCursorPosition(0, 1); // Устанавливаем курсор для отображения очков
            Console.Write($"Score: {score}");
        }
    }
}
