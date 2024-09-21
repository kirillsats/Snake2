using Snake2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace Snake2
{
    public class mainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere tulemast Snake mängu!");
            Console.WriteLine("Vali tase: ");
            Console.WriteLine("1. Tase 1");
            Console.WriteLine("2. Tase 2");
            Console.WriteLine("3. Tase 3");

            string userInput = Console.ReadLine();
            string playerName;

            // Запрос имени игрока после выбора уровня
            Console.WriteLine("Sisestage oma nimi: ");
            playerName = Console.ReadLine();

            Time gameTimer = new Time(@"..\..\GameRecord.txt");
            gameTimer.Start(); // Запускаем таймер
            Thread displayThread = new Thread(gameTimer.DisplayTime);
            displayThread.Start();

            Walls walls;
            Snake snake;
            FoodCreator foodCreator;
            Point food;

            switch (userInput)
            {
                case "2":
                    Console.Clear();
                    Console.WriteLine("Sa valisid tase 2");
                    walls = new Walls(80, 25);
                    walls.Draw();
                    Point p1 = new Point(4, 5, '*');
                    snake = new Snake(p1, 4, Direction.RIGHT);
                    snake.Draw();
                    foodCreator = new FoodCreator(80, 25, '$');
                    food = foodCreator.CreateFood();
                    food.Draw();
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Sa valisid tase 3");
                    walls = new Walls(60, 20);
                    walls.Draw();
                    Point p2 = new Point(4, 5, '*');
                    snake = new Snake(p2, 4, Direction.RIGHT);
                    snake.Draw();
                    foodCreator = new FoodCreator(60, 20, '$');
                    food = foodCreator.CreateFood();
                    food.Draw();
                    break;

                case "1":
                    Console.Clear();
                    Console.WriteLine("Sa valisid tase 1");
                    walls = new Walls(100, 30); // Например, для уровня 1
                    walls.Draw();
                    Point p3 = new Point(4, 5, '*');
                    snake = new Snake(p3, 4, Direction.RIGHT);
                    snake.Draw();
                    foodCreator = new FoodCreator(100, 30, '$');
                    food = foodCreator.CreateFood();
                    food.Draw();
                    break;

                default:
                    Console.WriteLine("Vale valik (Неправильный выбор). Proovi uuesti.");
                    return; // Выход, если выбор некорректный
            }

            // Основной игровой цикл
            while (true)
            {
                // Проверяем столкновение с границами или хвостом
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Console.SetCursorPosition(35, 12);
                    Console.WriteLine("Game Over");
                    gameTimer.Stop();
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
                    snake.Move(); // Перемещение змейки
                }

                Thread.Sleep(100); // Задержка между кадрами

                // Управление с помощью клавиш
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true); // true, чтобы не выводить символ
                    snake.HandleKey(key.Key); // Изменение направления
                }
            }

            // Получаем время игры
            string elapsedTime = gameTimer.GetElapsedTime();

            // Запись имени игрока и времени в файл
            try
            {
                using (StreamWriter sw = new StreamWriter(@"..\..\RecordTable.txt", true))
                {
                    sw.WriteLine($"{playerName} - {elapsedTime}"); // Записываем имя и время в файл
                }
            }
            catch
            {
                Console.WriteLine("Tekkis viga.");
            }

            // Чтение и отображение последнего имени игрока
            try
            {   
                Console.Clear();
                using (StreamReader sr = new StreamReader(@"..\..\RecordTable.txt"))
                {
                    string lines = sr.ReadToEnd();
                    var result = lines.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    Console.SetCursorPosition(2, 1);
                    Console.WriteLine("Viimane mängija: " + result.Last()); // Выводим последнее имя
                }
            }
            catch
            {
                Console.WriteLine("Tekkis viga.");
            }

            // Завершаем поток таймера
            displayThread.Join();
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

