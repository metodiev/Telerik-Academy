using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;




class FallingRocks
{
   
    
    private static string dwarf = "(0)>";
    private static int dwarfSize = dwarf.Length;
    private static int dwarfPosition;
    private static int maxRocks = 5;
    private static int activeRocks = 0;
    private static int score = 0;
    private static int maxPlayers = 5;
    private static int level = 1;
    private static int sleep = 200;
    private static string[] typeRocks = new string[] { "^", "@", "*", "&", "+", "%", "$", "#", "!", ".", ";", "-" };
    private static List<Rock> rocks = new List<Rock>();
    private static List<Player> players = new List<Player>();
    private static Random rand = new Random();

    static void removeScrollBars()
    {
        Console.WindowWidth = 50;
        Console.WindowHeight = 25;
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
    }

    static void setPosition()
    {
        Console.SetCursorPosition(Console.WindowHeight - 1, Console.WindowWidth / 2 - 1);
        dwarfPosition = Console.WindowWidth / 2 - 1;
        drowDwarf();
    }

    static void moveDwarf()
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                if (dwarfPosition + dwarfSize < Console.WindowWidth - 1)
                {
                    dwarfPosition++;
                    drowDwarf();
                }
            }
            if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                if (dwarfPosition > 0)
                {
                    dwarfPosition--;
                    drowDwarf();
                }
            }

        }
    }

    static void drowDwarf()
    {
        Console.SetCursorPosition(dwarfPosition, Console.WindowHeight - 1);
        Console.Write(dwarf);
    }

    static void fallingRocks()
    {
        generateNewRocks();
        drowRocks();
    }

    private static void drowRocks()
    {
        foreach (Rock r in rocks)
        {
            Console.SetCursorPosition(r.getX(), r.getY());
            for (int s = 0; s < r.getSize(); s++)
            {
                Console.Write(typeRocks[r.getType()]);
            }
            if (r.getY() < Console.WindowHeight - 1) r.setY();
        }
        int? remove = null;
        int i = 0;
        foreach (Rock r in rocks)
        {
            if (r.getY() == Console.WindowHeight - 1)
            {
                Console.SetCursorPosition(0, 15);
                if ((r.getX() >= dwarfPosition && r.getX() <= dwarfPosition + dwarfSize) ||
                    (r.getX() + r.getSize() >= dwarfPosition && r.getX() + r.getSize() <= dwarfPosition + dwarfSize))
                {
                    gameOver();
                    break;
                }
                else
                {
                    score += r.getSize();
                }
                remove = i;
                break;
            }
            i++;
        }
        if (remove.HasValue)
        {
            rocks.RemoveAt(remove.Value);
            activeRocks--;
        }
    }

    private static void generateNewRocks()
    {

        if (activeRocks < maxRocks)
        {
            activeRocks++;
            int x = rand.Next(0, Console.WindowWidth - 1);
            int t = rand.Next(0, typeRocks.Length - 1);
            Rock r = new Rock(x, 0, t);
            rocks.Add(r);
            if (score >= level * 100)
            {
                maxRocks++;
                level++;
            }
        }
    }

    private static void printScore()
    {
        Console.SetCursorPosition(0, 0);
        Console.Write("SCORE {0}", score);
        Console.SetCursorPosition(Console.WindowWidth - 8, 0);
        Console.Write("LEVEL {0,2}", level);
        Console.SetCursorPosition(Console.WindowWidth / 2 - 4, 0);
        Console.Write("ROCKS {0,2}", maxRocks);
    }

    private static void startGame()
    {
        removeScrollBars();
        setPosition();
        score = 0;
    }

    private static void gameOver()
    {
        Console.SetCursorPosition(10, 10);
        Console.WriteLine("GAME OVER\t{0}", score);
        Console.SetCursorPosition(10, 11);
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        players.Add(new Player(name, score));
        printTopPlayers();
        Console.ReadKey();
        rocks.Clear();
        activeRocks = 0;
        maxRocks = 5;
        level = 1;
        startGame();

    }

    private static void printTopPlayers()
    {
        players.Sort();
        Console.Clear();
        int i = 1;
        Console.SetCursorPosition(10, 10);
        Console.Write("N" + " " + "Player " + "\t" + "score");
        foreach (Player p in players)
        {
            Console.SetCursorPosition(10, 11 + i);
            Console.Write(i);
            Console.SetCursorPosition(12, 11 + i);
            Console.Write("{0,10}", p.getName());
            Console.SetCursorPosition(23, 11 + i);
            Console.Write(" " + p.getScore());
            if (i == maxPlayers) break;
            i++;
        }
    }

    static void Main(string[] args)
    {
        startGame();
        while (true)
        {
            moveDwarf();
            drowDwarf();
            fallingRocks();
            printScore();
            Thread.Sleep(sleep - level * 10);
            Console.Clear();
        }
    }
}


public class Rock
{
    int x;
    int y;
    int type;
    int rockSize;
    public Rock(int x, int y, int type)
    {
        Random rand = new Random();
        this.x = x;
        this.y = y;
        this.type = type;
        rockSize = rand.Next(1, 4);
    }
    public int getX() { return this.x; }
    public int getY() { return this.y; }
    public int getType() { return this.type; }
    public int getSize() { return this.rockSize; }
    public void setY() { this.y++; }

}

public class Player : IComparable<Player>
{
    String name;
    int score;
    public Player(String name, int score)
    {
        this.name = name;
        this.score = score;
    }

    public int CompareTo(Player other)
    {
        if (this.score < other.score) return 1;
        else if (this.score > other.score) return -1;
        else return 0;
    }

    public string getName() { return this.name; }
    public int getScore() { return this.score; }
}

 /*class Program
{
      static void Main(string[] args)
     {
          Console.WriteLine("It's time to enter some text.");
          Console.Write("Enter it here: ");
          string text = Console.ReadLine();
          int left = Console.CursorLeft;
          int top = Console.CursorTop;
          Console.SetCursorPosition(15, 20);
         

          Console.ForegroundColor = ConsoleColor.Blue;
          Console.BackgroundColor = ConsoleColor.Yellow;
          Console.Write("symbols ^, @, *, &, +, %, $, #, ! ");
          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.BackgroundColor = ConsoleColor.DarkGray;
          Console.Write(text);
          Console.ForegroundColor = ConsoleColor.Magenta;
          Console.BackgroundColor = ConsoleColor.Cyan;
          Console.Write(" <- ");
          Console.ResetColor();
      }
 }
/*
namespace JustPingPong
{
    class Program
    {
        static int firstPlayerPadSize = 10;
        static int secondPlayerPadSize = 4;
        static int ballPositionX = 0;
        static int ballPositionY = 0;
        static bool ballDirectionUp = true; // Determines if the ball direction is up
        static bool ballDirectionRight = false;
        static int firstPlayerPosition = 0;
        static int secondPlayerPosition = 0;
        static int firstPlayerResult = 0;
        static int secondPlayerResult = 0;
        static Random randomGenerator = new Random();

        static void RemoveScrollBars()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
        }

        static void DrawFirstPlayer()
        {
            for (int y = firstPlayerPosition; y < firstPlayerPosition + firstPlayerPadSize; y++)
            {
                PrintAtPosition(0, y, '|');
                PrintAtPosition(1, y, '|');
            }
        }

        static void PrintAtPosition(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        static void DrawSecondPlayer()
        {
            for (int y = secondPlayerPosition; y < secondPlayerPosition + secondPlayerPadSize; y++)
            {
                PrintAtPosition(Console.WindowWidth - 1, y, '|');
                PrintAtPosition(Console.WindowWidth - 2, y, '|');
            }
        }

        static void SetInitialPositions()
        {
            firstPlayerPosition = Console.WindowHeight / 2 - firstPlayerPadSize / 2;
            secondPlayerPosition = Console.WindowHeight / 2 - secondPlayerPadSize / 2;
            SetBallAtTheMiddleOfTheGameField();
        }

        static void SetBallAtTheMiddleOfTheGameField()
        {
            ballPositionX = Console.WindowWidth / 2;
            ballPositionY = Console.WindowHeight / 2;
        }

        static void DrawBall()
        {
            PrintAtPosition(ballPositionX, ballPositionY, '@');
        }

        static void PrintResult()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, 0);
            Console.Write("{0}-{1}", firstPlayerResult, secondPlayerResult);
        }

        static void MoveFirstPlayerDown()
        {
            if (firstPlayerPosition < Console.WindowHeight - firstPlayerPadSize)
            {
                firstPlayerPosition++;
            }
        }

        static void MoveFirstPlayerUp()
        {
            if (firstPlayerPosition > 0)
            {
                firstPlayerPosition--;
            }
        }

        static void MoveSecondPlayerDown()
        {
            if (secondPlayerPosition < Console.WindowHeight - secondPlayerPadSize)
            {
                secondPlayerPosition++;
            }
        }

        static void MoveSecondPlayerUp()
        {
            if (secondPlayerPosition > 0)
            {
                secondPlayerPosition--;
            }
        }

        static void SecondPlayerAIMove()
        {
            int randomNumber = randomGenerator.Next(1, 101);
            //if (randomNumber == 0)
            //{
            //    MoveSecondPlayerUp();
            //}
            //if (randomNumber == 1)
            //{
            //    MoveSecondPlayerDown();
            //}
            if (randomNumber <= 70)
            {
                if (ballDirectionUp == true)
                {
                    MoveSecondPlayerUp();
                }
                else
                {
                    MoveSecondPlayerDown();
                }
            }
        }

        private static void MoveBall()
        {
            if (ballPositionY == 0)
            {
                ballDirectionUp = false;
            }
            if (ballPositionY == Console.WindowHeight - 1)
            {
                ballDirectionUp = true;
            }
            if (ballPositionX == Console.WindowWidth - 1)
            {
                SetBallAtTheMiddleOfTheGameField();
                ballDirectionRight = false;
                ballDirectionUp = true;
                firstPlayerResult++;
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                Console.WriteLine("First player wins!");
                Console.ReadKey();
            }
            if (ballPositionX == 0)
            {
                SetBallAtTheMiddleOfTheGameField();
                ballDirectionRight = true;
                ballDirectionUp = true;
                secondPlayerResult++;
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                Console.WriteLine("Second player wins!");
                Console.ReadKey();
            }

            if (ballPositionX < 3)
            {
                if (ballPositionY >= firstPlayerPosition
                    && ballPositionY < firstPlayerPosition + firstPlayerPadSize)
                {
                    ballDirectionRight = true;
                }
            }

            if (ballPositionX >= Console.WindowWidth - 3 - 1)
            {
                if (ballPositionY >= secondPlayerPosition
                    && ballPositionY < secondPlayerPosition + secondPlayerPadSize)
                {
                    ballDirectionRight = false;
                }
            }

            if (ballDirectionUp)
            {
                ballPositionY--;
            }
            else
            {
                ballPositionY++;
            }


            if (ballDirectionRight)
            {
                ballPositionX++;
            }
            else
            {
                ballPositionX--;
            }
        }

        static void Main(string[] args)
        {
            RemoveScrollBars();
            SetInitialPositions();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.UpArrow)
                    {
                        MoveFirstPlayerUp();
                    }
                    if (keyInfo.Key == ConsoleKey.DownArrow)
                    {
                        MoveFirstPlayerDown();
                    }
                }
                SecondPlayerAIMove();
                MoveBall();
                Console.Clear();
                DrawFirstPlayer();
                DrawSecondPlayer();
                DrawBall();
                PrintResult();
                Thread.Sleep(60);
            }
        }
    }
}
/*
|____________________________________ |
|                1-0                  |
|                                     |
|                                     |
||         *                         *|
||                                   *|
||                                   *|
||                                   *|
|                                     |
|                                     |
|                                     |
|                                     |
|                                     |
|_____________________________________|_*/

