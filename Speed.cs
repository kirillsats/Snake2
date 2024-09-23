using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    internal class Speed
    {
        private double speed;

        public Speed(double speed)
        {
            this.speed = speed;
        }

        // Увеличение скорости (Kiiruse suurendamine)
        public void SuurendaKiirus()
        {
            speed = speed * 1.5; // Скорость увеличивается на 50%
        }

        // Уменьшение скорости (Kiiruse vähendamine)
        public void KiirustVфhendada()
        {
            speed = speed * 0.5; // Скорость уменьшается в два раза
        }

        public int Kiirus()
        {
            return (int)speed;
        }
    }
}
