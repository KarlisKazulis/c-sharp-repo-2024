using System;
using System.ComponentModel.Design;

namespace TicTacToe
{
    class Program
    {
        private static char[,] _board = new char[3, 3];

        private static char _currentPlayer = 'X';

        private static void Main(string[] args)
        {
            InitBoard();

            while (true)
            {
                DisplayBoard();

                Console.WriteLine($"{_currentPlayer}'s turn. Choose your location (row, column)");
                int row = int.Parse(Console.ReadLine());
                int column = int.Parse(Console.ReadLine());

                if (IsValidMove(row, column))
                {
                    _board[row, column] = _currentPlayer;

                    if (CheckWin())
                    {
                        DisplayBoard();
                        Console.WriteLine($"{_currentPlayer} wins!");
                        break;
                    }

                    if (IsBoardFull())
                    {
                        DisplayBoard();
                        Console.WriteLine("Board is full, it's a tie!!");
                        break;
                    }

                    SwitchPlayer(); //switch players function below uses switch
                }
                else
                {
                    Console.WriteLine("Invalid move. Try again!");
                }
            }
            
        }

        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    _board[r, c] = ' ';
            }

        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + _board[0, 0] + "|" + _board[0, 1] + "|" + _board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + _board[1, 0] + "|" + _board[1, 1] + "|" + _board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + _board[2, 0] + "|" + _board[2, 1] + "|" + _board[2, 2]);
            Console.WriteLine("    --+-+--");
        }

        private static bool IsValidMove(int row, int column)
        { 
            return row >= 0 && row < 3 && column >= 0 && column < 3 && _board[row, column] == ' ';
        }

        private static bool CheckWin()
        {
            return (CheckRow(0) || CheckRow(1) || CheckRow(2) ||
                    CheckColumn(0) || CheckColumn(1) || CheckColumn(2) ||
                    CheckDiagonals());
        }

        private static bool CheckRow(int row)
        {
            return (_board[row, 0] == _currentPlayer &&
                    _board[row, 1] == _currentPlayer &&
                    _board[row, 2] == _currentPlayer);
        }

        private static bool CheckColumn(int column)
        {
            return (_board[0, column] == _currentPlayer &&
                    _board[1, column] == _currentPlayer &&
                    _board[2, column] == _currentPlayer);
        }

        private static bool CheckDiagonals()
        {
            return ((_board[0, 0] == _currentPlayer &&
                     _board[1, 1] == _currentPlayer &&
                     _board[2, 2] == _currentPlayer) ||
                    (_board[0, 2] == _currentPlayer &&
                     _board[1, 1] == _currentPlayer &&
                     _board[2, 0] == _currentPlayer));
        }

        private static bool IsBoardFull()
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (_board[r, c] == ' ')
                    {
                        return false;
                    }
                }
            }
            
            return true;
        }

        private static void SwitchPlayer()
        {
            switch (_currentPlayer)
            {
                case 'X':
                    _currentPlayer = 'O';
                    break;
                case 'O':
                    _currentPlayer = 'X';
                    break;
            }
        }
    }
}
