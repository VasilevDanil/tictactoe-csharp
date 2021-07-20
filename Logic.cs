using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Logic
    {
       

        static char[] arr = { 'g', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static int left_ = 0;
        static int top_ = 3;

        static void CheckWin()
        {
            if (arr[7] == arr[8] && arr[8] == arr[9])
            {
                //  совп 1 строка
                //  Конец игры
                arr[0] = 'v';
                return;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                //  совп 2 строка
                //  Конец игры
                arr[0] = 'v';
                return;
            }
            else if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                //  совп 3 строка
                //  Конец игры
                arr[0] = 'v';
                return;
            }
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                //  совп 1 столбец
                //  Конец игры
                arr[0] = 'v';
                return;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                //  совп 2 столбец
                //  Конец игры
                arr[0] = 'v';
                return;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                //  совп 3 столбец
                //  Конец игры
                arr[0] = 'v';
                return;
            }
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                
                arr[0] = 'v';
                return;
            }
            else if (arr[7] == arr[5] && arr[5] == arr[3])
            {
                
                arr[0] = 'v';
                return;
            }

            
            if (arr[7] != '7' && arr[8] != '8' && arr[9] != '9' &&
                arr[4] != '4' && arr[5] != '5' && arr[6] != '6' &&
                arr[1] != '1' && arr[2] != '2' && arr[3] != '3')
            {
                
                arr[0] = 'd';   
            }
            else
            {
                arr[0] = 'g';   
            }
        }

        public char GetGameStatus()
        {
            return arr[0];
        }

        public void Board()
        {
            for (int i = 1; i <= 9; i++)
            {
                if (arr[i] == 'X')
                {
                    Print_X(i);
                }
                else if (arr[i] == 'O')
                {
                    Print_O(i);
                }
                else
                {
                    Print_Empty(i);
                }
            }
        }

        public bool FreePosition(int pos)
        {
            if (arr[pos] != 'O' && arr[pos] != 'X')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Move(int pos, char player)
        {
            arr[pos] = player;
            CheckWin();
        }

        private static void Print_X (int pos)
        {
            PrintPosition(in pos, out int _left, out int _top);
            Console.SetCursorPosition(_left, _top);   Console.WriteLine("::::::::::::::::::::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine(":: .===.   .===.  ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::  \\ * \\  / * /  ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::   \\ * \\/ * /   ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::    > *  * <    ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::   / * /\\ * \\   ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::  / * /  \\ * \\  ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine(":: '==='    '===' ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::::::::::::::::::::");
        }
        private static void Print_O (int pos)
        {
            PrintPosition(in pos, out int _left, out int _top);
            Console.SetCursorPosition(_left, _top);   Console.WriteLine("::::::::::::::::::::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::   .========.   ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine(":: ./   *  *   \\. ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine(":: |  *  /\\  *  | ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine(":: | *  |  |  * | ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine(":: |  *  \\/  *  | ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine(":: '\\   *  *   /' ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::   '========'   ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::::::::::::::::::::");
        }

        private static void Print_Empty(int pos)
        {
            PrintPosition(in pos, out int _left, out int _top);
            Console.SetCursorPosition(_left, _top);   Console.WriteLine("::::::::::::::::::::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::                ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine($"::  {pos}             ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::                ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::                ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::                ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::                ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::                ::");
            Console.SetCursorPosition(_left, ++_top);   Console.WriteLine("::::::::::::::::::::");
        }

        private static void PrintPosition(in int pos, out int _left, out int _top)
        {
            //  Поле:
            int with = 18;
            int heigth = 8;

            switch (pos)
            {
                case 7:
                    _left = left_ + with * 0;
                    _top = top_ + heigth * 0;
                    break;
                case 8:
                    _left = left_ + with * 1;
                    _top = top_ + heigth * 0;
                    break;
                case 9:
                    _left = left_ + with * 2;
                    _top = top_ + heigth * 0;
                    break;
                case 4:
                    _left = left_ + with * 0;
                    _top = top_ + heigth * 1;
                    break;
                case 5:
                    _left = left_ + with * 1;
                    _top = top_ + heigth * 1;
                    break;
                case 6:
                    _left = left_ + with * 2;
                    _top = top_ + heigth * 1;
                    break;
                case 1:
                    _left = left_ + with * 0;
                    _top = top_ + heigth * 2;
                    break;
                case 2:
                    _left = left_ + with * 1;
                    _top = top_ + heigth * 2;
                    break;
                case 3:
                    _left = left_ + with * 2;
                    _top = top_ + heigth * 2;
                    break;
                default:
                    _left = 0;
                    _top = 0;
                    break;
            }
        }
    }
}

