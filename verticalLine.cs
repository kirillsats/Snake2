using Snake2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    internal class verticalLine : Figure
    {
        public verticalLine(int yUp, int yDowm, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDowm; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }


        }
    }
}