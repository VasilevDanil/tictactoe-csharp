using System;
using System.Threading; // Для использования задержки

namespace TicTacToe
{
    class Program
    {

        static int player = 1; 

        static int choice; 

        static Logic game = new Logic();    

        static void Main()
        {
            ConsoleKeyInfo cki;
            do
            {
                ScreenReload();
                do
                {
                    cki = Console.ReadKey(true);
                    choice = cki.KeyChar - 48;
                } while (choice < 1 || choice > 9);

               
                if (game.FreePosition(choice))
                {
                   
                    if (player % 2 == 0)
                    {
                        game.Move(choice, 'O');
                    }
                    else
                    {
                        game.Move(choice, 'X');
                    }
                    player++;
                }
                else
                {
                   
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(18, 27);
                    Console.WriteLine("\n\tПозиция занята.");
                    Thread.Sleep(1500);
                    Console.ResetColor();

                }

            } while (game.GetGameStatus() == 'g');

            ScreenReload();

            if (game.GetGameStatus() == 'v')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(18, 27);
                var viner = (player % 2) + 1;
                var symbol = (viner % 2) == 0 ? 'O' : 'X';
                Console.WriteLine($"Игрок {viner}: \"{symbol}\" выиграл.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(23, 27);
                Console.WriteLine("Ничья :)");
                Console.ResetColor();
            }
            Console.ReadKey();
        }

        static void ScreenReload()
        {
            Console.Clear();
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("::                    TicTacToe                       ::");
            Console.WriteLine("::         Игрок 1: \"X\"  vs   Игрок 2: \"O\"            ::");
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            
            game.Board();

            Console.ForegroundColor = ConsoleColor.Blue;
            if (game.GetGameStatus() == 'g')
            {
                Console.SetCursorPosition(18, 27);
                Console.Write("Хидит - ");
                if (player % 2 == 0)
                {
                    Console.Write("Игрок 2: \"O\"");
                }
                else
                {
                    Console.Write("Игрок 1: \"X\"");
                }
            }
            Console.ResetColor();
        }
    }
}

