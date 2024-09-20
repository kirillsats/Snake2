using Snake2;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Snake2
{
    public class mainClass
    {
        static void Main(string[] args)
        {

            try
            {
                // Открываем файл для записи (append = true)
                StreamWriter sw = new StreamWriter(@"..\..\RecordTable.txt", true);
                Console.WriteLine("Sisestage oma nimi: ");
                string nimi = Console.ReadLine();
                sw.WriteLine(nimi); // Записываем имя в файл           
                sw.Close();
                Console.Clear();
            }
            catch
            {
                Console.WriteLine("Tekkis viga.");
            }
            

            try
            {
                // Открываем файл для чтения
                StreamReader sr = new StreamReader(@"..\..\RecordTable.txt");
                string lines = sr.ReadToEnd();
                sr.Close();


                // Создаем список уникальных имен
                List<string> result = new List<string>();
                foreach (var rida in File.ReadAllLines(@"..\..\RecordTable.txt"))
                {
                    if (!string.IsNullOrEmpty(rida)) // Исключаем пустые строки
                    {
                        result.Add(rida);
                    }

                }
                Console.SetCursorPosition(2, 1);
                Console.WriteLine(" " + result.Last());
            }
            catch
            {
                Console.WriteLine("Tekkis viga.");
            }





            Console.SetWindowSize(80, 25);
            Walls walls = new Walls(80, 25);
            walls.Draw();

            // Отрисовка точек   
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                // Проверяем столкновение с границами или хвостом
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Console.SetCursorPosition(35, 12);
                    Console.WriteLine("Game Over");
                    break;
                }

                // Проверяем, съедена ли еда
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move(); // перемещение змейки
                }

                Thread.Sleep(100); // задержка между кадрами

                // Управление с помощью клавиш
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true); // true, чтобы не выводить символ
                    snake.HandleKey(key.Key); // изменение направления
                }
            }
            Console.ReadLine();
        }


    }

}






/*verticalLine v1 = new verticalLine(0, 10, 5, '%');
Draw(v1);

Point p = new Point(4, 5, '-');

//madu kuvamine
Snake snake = new Snake(p, 4, Direction.RIGHT);
Draw(fSnake);
Snake snake = (Snake)fSnake;

HorizontalLine h1 = new HorizontalLine(0, 5, 6, '&');

List<Figure> figures = new List<Figure>();
figures.Add(fSnake);
figures.Add(v1);
figures.Add(h1);

foreach (var f in figures)
{
    f.Draw();
}
}
}
static void Draw(Figure figure)
{
figure.Draw();
}
}




/* //söö
FoodCreator foodCreator = new FoodCreator(80, 25, '$');
Point food = foodCreator.CreateFood();
food.Draw();
while (true)
{
    if (snake.Eat(food))
    {
        food = foodCreator.CreateFood();
        food.Draw();
    }
    else
    {
        snake.Move();
    }

    if (Console.KeyAvailable) //передвижение змейки
    {
        ConsoleKeyInfo key = Console.ReadKey();
        snake.HandleKey(key.Key);
    }
    Thread.Sleep(100);
    snake.Move();
}








Console.ReadLine(); // в конце должно быть. 



/*topLine.Drow();
bottomLine.Drow();
leftLine.Drow();
rightLine.Drow();
Point p = new Point(4, 5, '*');
p.Draw();*/


/*Point p1 = new Point(1, 3, '*'); /*loob uue punkti p1*/
/*p1.x = 1;
p1.y = 3;
p1.sym = '*';*/
/* p1.Draw(); /*tõmbab punkti*/

/*Point p2 = new Point(4, 5, '#');
/*p2.Draw();*/
/*p2.x = 4;                 /*muutujad*/
/* p2.y = 5;
 p2.sym = '#';*/
/*HorizontalLine hLine = new HorizontalLine(3, 10, 5, '*');
hLine.Drow();
verticalLine vLine = new verticalLine(3, 10, 6, '#');
vLine.Drow();**




Console.ReadLine();*/

