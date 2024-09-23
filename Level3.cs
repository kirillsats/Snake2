using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake2
{
    internal class Level3
    {
        public void Level_3_Play(string nimi)
        {
            Console.Clear();
            //Vähendatud väli (Уменьшенное поле)
            Walls walls = new Walls(45, 15);
            walls.Draw();

            //Suurenenud algkiirus (Увеличенние начальной скорости)
            Speed kiiruseMuutus = new Speed(30);
            Thread.Sleep(kiiruseMuutus.Kiirus() * 15);

            Console.SetCursorPosition(1, 2);

        }
    }
}