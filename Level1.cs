using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake2
{
    internal class Level1
    {
        public void Level_1_Play(string nimi)
        {
            //Vähendatud väli (Уменьшенное поле)
            Walls walls = new Walls(80, 25);
            walls.Draw();



            //Suurenenud algkiirus (Увеличенние начальной скорости)
            Speed kiiruseMuutus = new Speed(10);



            Thread.Sleep(kiiruseMuutus.Kiirus() * 15);



            Console.SetCursorPosition(2, 1);

        }
    }
}
