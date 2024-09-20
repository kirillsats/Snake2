
using Snake2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    public class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {
        }
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        internal void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)  //если координаты равны вправо, то х увеличить на расстояние offset
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }
        //проверка равенства координат
        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }


        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }
        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }



    }
}