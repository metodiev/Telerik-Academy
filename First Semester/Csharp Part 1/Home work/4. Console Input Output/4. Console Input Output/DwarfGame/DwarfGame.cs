using System;
using System.Numerics;
using System.Collections.Generic;
using System.Threading;


struct dwarf
{
    public int x;
    public int y;
    public string symbol;
    public ConsoleColor color;
}

struct rock
{
    public int x1;
    public int y1;
    public string [] symbols;
    public ConsoleColor color;
}

class DwarfGame
{
   

    static void PrintOnPosition(int x, int y, string c,
        ConsoleColor color = ConsoleColor.Cyan)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.WriteLine(c);
    }

    static void PrintRockPosition(int x1, int y1, string[] c1,
        ConsoleColor color = ConsoleColor.Green)
    {
        
        Random newRandom  = new Random();
        color = console[newRandom.Next(7)];
        Console.SetCursorPosition(x1, y1);
        Console.ForegroundColor = color;
	    Console.WriteLine(c1[newRandom.Next(7)]);        
    }

    static void PrintInfoPosition(int x1, int y1, string str,
        ConsoleColor color = ConsoleColor.White)
    {
        Console.SetCursorPosition(x1, y1);
        Console.ForegroundColor = color;
        Console.WriteLine(str);
    }

    static void PrintScore(int x1, int y1, string str, BigInteger p,
       ConsoleColor color = ConsoleColor.White)
    {
        Console.SetCursorPosition(x1, y1);
        Console.ForegroundColor = color;
        Console.WriteLine("{0}:{1}",str, p);
    }

    public static ConsoleColor[] console = new ConsoleColor[] {
            ConsoleColor.Blue,
            ConsoleColor.Cyan,
            ConsoleColor.Gray,
            ConsoleColor.Green,
            ConsoleColor.Magenta,
            ConsoleColor.Red,
            ConsoleColor.White,
            ConsoleColor.Yellow
        };

    static void Main()
    {
        int livesCount = 5;
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
        dwarf dwarf = new dwarf(); 
        dwarf.x = Console.WindowTop;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.symbol = "(0)";
        dwarf.color = ConsoleColor.Yellow;
        Random randomGenerator = new Random();
        List<rock> rocks = new List<rock>(); 
        string [] someSymbols = new string [11] { "^", "@", "*", "&", "+", "%", "$", "#", "!", ".", ";" };
        BigInteger count = 0;
        rock newRock = new rock();
        newRock.y1 = 0;
       
        while (true)
        {
           
            newRock.symbols = someSymbols;
            newRock.x1 = randomGenerator.Next(Console.WindowWidth);
            rocks.Add(newRock);

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x - 1 >= 0)
                    {
                        dwarf.x = dwarf.x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x + 1 < Console.WindowWidth)
                    {
                        dwarf.x = dwarf.x + 1;
                    }
                }
            }

            List<rock> newList = new List<rock>();
            rock newRocks = new rock();
            for (int i = 0 ; i < rocks.Count; i++)
            {
                rock oldRock = rocks[i];
               
                newRocks.x1 = oldRock.x1;
                newRocks.y1 = oldRock.y1 + 1;
                newRocks.symbols = oldRock.symbols;
                newRocks.color = oldRock.color;
               
                rocks.Remove(oldRock);
             

                if (newRocks.y1 == dwarf.y && newRocks.x1 == dwarf.x)
                {
                    --livesCount;

                    if (livesCount <= 0)
                    {
                       PrintInfoPosition(8, 8, "GAME OVER !!!", ConsoleColor.Red);
                       PrintInfoPosition(8, 10, "Press enter key to exit", ConsoleColor.Red);
                       Console.ReadLine();
                      
                       Environment.Exit(0);
                    }
                }
                if (newRocks.y1 < Console.WindowHeight - 1)
                {
                    count++;
                    rocks.Add(newRocks);
                }
               
            }
          // rocks = newList;

            Console.Clear();
            PrintOnPosition(dwarf.x, dwarf.y, dwarf.symbol, dwarf.color);

            foreach (rock rock in rocks)
	        {
		        PrintRockPosition(rock.x1, rock.y1, rock.symbols, rock.color);
	        }

            PrintInfoPosition(0, 0, "Lives:" + livesCount, ConsoleColor.White);
            PrintScore(0, 1, "Rocks:",count, ConsoleColor.White);
            Thread.Sleep(150);
        }
    }
}




