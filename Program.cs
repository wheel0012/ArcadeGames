﻿using System;

namespace C_Sharp_SnakeGame_DotnetCore
{
    enum Games { Snake }
    class Program
    {
        static void Main(string[] args)
        {
            Program instance = new Program();
            Console.WriteLine("|    Select game |\n" +
                              "|    a. Snake    |\n");
            ConsoleKeyInfo a = Console.ReadKey();
            switch (a.Key)
            {
                
                case ConsoleKey.A:
                    instance.InitiateGame(Games.Snake);
                    break;
            }
        }
        void InitiateGame(Games game)
        {
            switch (game)
            {
                case Games.Snake:
                    Console.Clear();
                    SnakeGame snake = new SnakeGame();
                    snake.Init();
                    snake.Game();
                    break;
            }
        }
    }
}
