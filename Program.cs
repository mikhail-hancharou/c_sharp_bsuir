/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombField
{
    class Game
    {
        private char[,] GameField = new char[3, 3] {
                { ' ', ' ', ' ' },
                { ' ', ' ', ' ' },
                { ' ', ' ', ' ' },
            };

        private bool Flag = true, PlaceFlag;

        public Game()
        {
            Draw();

            int Rows, Columns;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nEnter the number of row (1-3) or -1 to exit \n");
                Console.ForegroundColor = ConsoleColor.White;
                int.TryParse(Console.ReadLine(), out Rows);
                while (Rows > 3 || Rows < -1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Try again \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Rows = int.Parse(Console.ReadLine());
                }
                if (Rows == -1) System.Environment.Exit(0);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nEnter the number of columns (1-3) or -1 to exit \n");
                Console.ForegroundColor = ConsoleColor.White;
                int.TryParse(Console.ReadLine(), out Columns);
                while (Columns > 3 || Columns < -1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Try again \n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Columns = int.Parse(Console.ReadLine());
                }
                if (Columns == -1) System.Environment.Exit(0); 
                UpdateField(Rows, Columns);
                if (PlaceFlag == true)
                {
                    Draw();
                }
            } while (true);
        }

        private void UpdateField(int row, int col)
        {
            if (GameField[row - 1, col - 1] == ' ')
            {
                PlaceFlag = true;
                GameField[row - 1, col - 1] = Flag ? 'X' : 'O';
                if (IsWinner('X'))
                {
                    Draw();
                    EndGame("Сrosses");
                }
                else if (IsWinner('O'))
                {
                    Draw();
                    EndGame("Zeros");
                }
                Flag = !Flag;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Try again \n");
                Console.ForegroundColor = ConsoleColor.White;
                PlaceFlag = false;
            }
        }

        private void Draw()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nGame \n");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            ShowField();
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        private void ShowField()
        {
            Console.WriteLine("  {0} | {1} | {2}", GameField[0, 0], GameField[0, 1], GameField[0, 2]);
            Console.WriteLine(" ---+---+---");
            Console.WriteLine("  {0} | {1} | {2}", GameField[1, 0], GameField[1, 1], GameField[1, 2]);
            Console.WriteLine(" ---+---+---");
            Console.WriteLine("  {0} | {1} | {2}", GameField[2, 0], GameField[2, 1], GameField[2, 2]);
        }

        private bool IsWinner(char player)
        {
            if((GameField[0, 0] == player && GameField[0, 1] == player && GameField[0, 2] == player) ||
                (GameField[1, 0] == player && GameField[1, 1] == player && GameField[1, 2] == player) ||
                (GameField[2, 0] == player && GameField[2, 1] == player && GameField[2, 2] == player) ||
                (GameField[0, 0] == player && GameField[1, 0] == player && GameField[2, 0] == player) ||
                (GameField[0, 1] == player && GameField[1, 1] == player && GameField[2, 1] == player) ||
                (GameField[0, 2] == player && GameField[1, 2] == player && GameField[2, 2] == player) ||
                (GameField[0, 0] == player && GameField[1, 1] == player && GameField[2, 2] == player) ||
                (GameField[0, 2] == player && GameField[1, 1] == player && GameField[2, 0] == player))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ClearField()
        {
            for (int Rows = 0; Rows < 3; Rows++)
            {
                for (int Columns = 0; Columns < 3; Columns++)
                {
                    GameField[Rows, Columns] = ' ';
                }
            }
        }

        private void EndGame(string player)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nWins {0}!\n", player);
            Console.WriteLine("\nEnter any key");
            Console.ReadKey();
            ClearField();
        }
        static void Main(string[] args)
        {
            new Game();
        }
    }
}
*/

using BombField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombFieldReal
{
    class Programm
    {   
        static void Main(string[] args)
        {
            new Game();

        }
    }
}
