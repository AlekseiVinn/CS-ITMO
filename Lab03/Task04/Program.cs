namespace Task04
{
    public struct Dot
    //структура точки
    { 
        public int xDot;
        public int yDot;
        public bool isCursed = false;

        public Dot(int x, int y) 
        // конутруктор точки
        {
            if (x == 404 || y == 404)
            {
                isCursed = true;
                Console.WriteLine("Получился проклятый выстрел");
            }
            else
            {
                xDot = x;
                yDot = y;
            }
        }

        public static Dot DotParse(string str)
        //парсинг введенных данных в консоли
        {
            try
            { 
                string[] dots = str.Split(',');
                if (dots.Length != 2)
                {
                    throw new ArgumentException();
                }
                else
                {
                    int x = Parse(dots[0]);
                    int y = Parse(dots[1]);
                    return new Dot(x, y);
                }
                
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Введен неверный формат выстрела");
                return new Dot(404,404);
            }
        }

        static int Parse(string str)
        //парсинг значений на формат данных и значение
        {
            try
            {
                int num;
                if (int.TryParse(str, out num))
                {
                    if (num < -10 || num > 10)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    return num; 
                }
                else 
                {
                    throw new ArgumentException(); 
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Значение вне поля игры");
                return 404;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Введен неверный формат выстрела");
                return 404;
            }
        }
    }

    public class Target
    //Класс мишени
    {
        Dot centerTarget;
        int radius10P = 1;
        int radius5P = 2;
        int radius1P = 3;

        public Target()
        //конструктор мишени
        {
            Random rnd = new Random();   
            centerTarget = new Dot(rnd.Next(-7, 8), rnd.Next(-7, 8));
            //Console.WriteLine($"Мишень ({centerTarget.xDot},{centerTarget.yDot}) создана");
            Console.WriteLine("Мишень создана.\n" + 
                              "Формат мишени: \n\n" +
                              "0______1______2______3______\n"+
                              "  10 б    5 б    1 б    0 б\n\n"+
                              "Размер поля: х(-10;10) на у(-10;10)\n"+
                              "Выстрелы вводятся в формате \"x,y\" в диапазоне размера поля.\n"+
                              "Если введен неверный формат выстрела, либо выстрел за границами поля - выстрел становиться проклятым.\n"+
                              "Модификаторы выстрела: стрельба вслепую + помеха выстрелу.\n");
        }

        /**static bool Blocked()
        //проверка на помеху выстрела - возращает true / false
        {
            Random rnd = new Random();
            return rnd.Next(0,2) == 0 ? false : true;
        }**/

        public int Points(Dot dotTrow)
        //подсчет очков в зависимости от координат выстрела
        {
            int result = (int)(Math.Pow(dotTrow.xDot - this.centerTarget.xDot, 2) + Math.Pow(dotTrow.yDot - this.centerTarget.yDot, 2));
            if (dotTrow.isCursed)
            {
                Console.WriteLine("Проклятый выстрел! - О баллов");
                return 0;
            }
            // слишком часто Blocked() == True из-за чего не получается хоть как-то попасть в мишень.
            /**else if (Blocked())
            {
                Console.WriteLine("Помеха выстрела! - О баллов");
                return 0;
            }**/
            else if (result <= Math.Pow(radius10P, 2))
            {
                Console.WriteLine($"({dotTrow.xDot},{dotTrow.yDot}) - Попал! 10 баллов!");
                return 10;
            }
            else if (result <= Math.Pow(radius5P, 2))
            {
                Console.WriteLine($"({dotTrow.xDot},{dotTrow.yDot}) - Попал! 5 баллов!");
                return 5;
            }
            else if (result <= Math.Pow(radius1P, 2))
            {
                Console.WriteLine($"({dotTrow.xDot},{dotTrow.yDot}) - Попал! 1 балл!");
                return 1;
            }
            else
            {
                Console.WriteLine($"({dotTrow.xDot},{dotTrow.yDot}) - Промах! 0 Баллов");
                return 0;
            }

        }
    }

    public class GameSession
    // класс для инициализации игры и подсчета бросков игрока
    {
        Target target;
        int tries;//количество бросков, по-умолчанию: 3
        Dot[]? throwsSave;
        int score;

        public GameSession(int tries = 3)
        {
            this.target = new Target();
            this.tries = tries;
            this.throwsSave = new Dot[tries];
            this.score = 0;
            Console.WriteLine("\n---ИГРОВАЯ СЕССИЯ СОЗДАНА---");
            this.Session();
        }

        public void Session()
        {
            for (int i=0; i < this.tries; i++)
            {
                Console.Write($"\nСделайте выстрел №{i+1} из {this.tries} :");
                string shot = Console.ReadLine();
                Dot dotThrown = Dot.DotParse(shot);
                this.score += target.Points(dotThrown);
            }
            Console.WriteLine($"\n Конец игры! Результат: {this.score} балл(ов)!");

        }
    }
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            GameSession Game = new GameSession(5);

        }
    }
}
