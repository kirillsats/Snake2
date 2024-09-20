using Snake2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)  // Kasutame <= lubamiseks xRight
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
        /*internal override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (Point point in pList)
            {
                pList.Draw();
            }
            Console.ForegroundColor = ConsoleColor.White;

        }*/

    }
}





/*pList = new List<Point>(); //loend
Point p1 = new Point(4,4, '*');
Point p2 = new Point(5, 4, '*');
Point p3 = new Point(6, 4, '*');
pList.Add(p1);
pList.Add(p2);
pList.Add(p3);*/


/*public void Drow()       //kuvamine
{
foreach (Point p in pList)
{
    p.Draw();
}
}*/

