using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake2
{
    internal class Level2
    {
        public void Level_2_Play(string nimi)
        {
            Console.Clear();
            //Vähendatud väli (Уменьшенное поле)
            Walls walls = new Walls(60, 20);
            walls.Draw();

            //Suurenenud algkiirus (Увеличенние начальной скорости)
            Speed kiiruseMuutus = new Speed(20);
            Thread.Sleep(kiiruseMuutus.Kiirus() * 15);

            Console.SetCursorPosition(2, 1);

        }
    }
}
