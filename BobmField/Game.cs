using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombField
{
    class Game
    {
        private readonly char[,] ShowPlaceField = new char[15, 15];
        private readonly int[,] BombPlaceField = new int[15, 15];
        private bool PlaceFlag, FirstStep = true;
        public Game()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int n = 0; n < 15; n++)
                {
                    ShowPlaceField[i, n] = '_';
                }
            }
            Draw();
            int Rows, Columns;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nEnter the number of row (1-15) or -1 to exit \n");
                int.TryParse(Console.ReadLine(), out Rows);
                if (Rows == -1) System.Environment.Exit(0);
                while (Rows > 15 || Rows < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Try again(no more 15, no less 1) \n");
                    int.TryParse(Console.ReadLine(), out Rows);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nEnter the number of columns (1-15) or -1 to exit \n");
                int.TryParse(Console.ReadLine(), out Columns);
                if (Columns == -1) System.Environment.Exit(0);
                while (Columns > 15 || Columns < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Try again(no more 15, no less 1) \n");
                    int.TryParse(Console.ReadLine(), out Columns);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                if (FirstStep == true)
                {
                    MakeBombField(Rows - 1, Columns - 1);
                }
                UpdateField(Rows, Columns);
                if (PlaceFlag == true)
                {
                    Draw();
                }
            } while (true);
        }

        private void UpdateField(int row, int col)
        {
            FirstStep = false;
            if (ShowPlaceField[row - 1, col - 1] == '_')
            {
                PlaceFlag = true;
                if (BombPlaceField[row - 1, col - 1] != -1 && BombPlaceField[row - 1, col - 1] != 0)
                {
                    ShowPlaceField[row - 1, col - 1] = (char)(BombPlaceField[row - 1, col - 1] + 48);
                    IsWinner();
                }
                else if (BombPlaceField[row - 1, col - 1] == -1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    ShowPlaceField[row - 1, col - 1] = '@';
                    Draw();
                    Console.WriteLine("Oh NO\nCRINGE\nTHAT WAS BOMB");
                    EndGame(false);
                    PlaceFlag = false;
                }
                else if (BombPlaceField[row - 1, col - 1] == 0)
                {
                    FreePlace(row - 1, col - 1);
                    Draw();
                    IsWinner();
                }
            }
            else
            {
                PlaceFlag = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Try again, this position is already open \n");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private void Left(int row, int col)
        {
            if (col > 0 && ShowPlaceField[row, col - 1] != '0')
            {
                if (BombPlaceField[row, col - 1] != 0)
                {
                    ShowPlaceField[row, col - 1] = (char)(BombPlaceField[row, col - 1] + 48);
                }
                else
                {
                    ShowPlaceField[row, col - 1] = (char)(BombPlaceField[row, col - 1] + 48);
                    Left(row, col - 1);
                    Up(row, col - 1);
                    Down(row, col - 1);
                    DownLeft(row, col - 1);
                    DownRight(row, col - 1);
                    UpLeft(row, col - 1);
                    UpRight(row, col - 1);
                }
            }
        }

        private void Right(int row, int col)
        {
            if (col < 15 - 1 && ShowPlaceField[row, col + 1] != '0')
            {
                if (BombPlaceField[row, col + 1] != 0)
                {
                    ShowPlaceField[row, col + 1] = (char)(BombPlaceField[row, col + 1] + 48);
                }
                else
                {
                    ShowPlaceField[row, col + 1] = (char)(BombPlaceField[row, col + 1] + 48);
                    Right(row, col + 1);
                    Up(row, col + 1);
                    Down(row, col + 1);
                    DownLeft(row, col + 1);
                    DownRight(row, col + 1);
                    UpLeft(row, col + 1);
                    UpRight(row, col + 1);
                }
            }
        }

        private void Up(int row, int col)
        {
            if (row > 0 && ShowPlaceField[row - 1, col] != '0')
            {
                if (BombPlaceField[row - 1, col] != 0)
                {
                    ShowPlaceField[row - 1, col] = (char)(BombPlaceField[row - 1, col] + 48);
                }
                else
                {
                    ShowPlaceField[row - 1, col] = (char)(BombPlaceField[row - 1, col] + 48);
                    Left(row - 1, col);
                    Right(row - 1, col);
                    Up(row - 1, col);
                    DownLeft(row - 1, col);
                    DownRight(row - 1, col);
                    UpLeft(row - 1, col);
                    UpRight(row - 1, col);
                }
            }
        }

        private void Down(int row, int col)
        {
            if (row < 15 - 1 && ShowPlaceField[row + 1, col] != '0')
            {
                if (BombPlaceField[row + 1, col] != 0)
                {
                    ShowPlaceField[row + 1, col] = (char)(BombPlaceField[row + 1, col] + 48);
                }
                else
                {
                    ShowPlaceField[row + 1, col] = (char)(BombPlaceField[row + 1, col] + 48);
                    Left(row + 1, col);
                    Right(row + 1, col);
                    Down(row + 1, col);
                    DownLeft(row + 1, col);
                    DownRight(row + 1, col);
                    UpLeft(row + 1, col);
                    UpRight(row + 1, col);
                }
            }
        }

        private void DownLeft(int row, int col)
        {
            if (row < 15 - 1 && col > 0 && ShowPlaceField[row + 1, col - 1] != '0')
            {
                if (BombPlaceField[row + 1, col - 1] != 0)
                {
                    ShowPlaceField[row + 1, col - 1] = (char)(BombPlaceField[row + 1, col - 1] + 48);
                }
                else
                {
                    ShowPlaceField[row + 1, col - 1] = (char)(BombPlaceField[row + 1, col - 1] + 48);
                    Left(row + 1, col - 1);
                    Right(row + 1, col - 1);
                    Up(row + 1, col - 1);
                    Down(row + 1, col - 1);
                    DownLeft(row + 1, col - 1);
                    DownRight(row + 1, col - 1);
                    UpLeft(row + 1, col - 1);
                }
            }
        }

        private void DownRight(int row, int col)
        {
            if (row < 15 - 1 && col < 15 - 1 && ShowPlaceField[row + 1, col + 1] != '0')
            {
                if (BombPlaceField[row + 1, col + 1] != 0)
                {
                    ShowPlaceField[row + 1, col + 1] = (char)(BombPlaceField[row + 1, col + 1] + 48);
                }
                else
                {
                    ShowPlaceField[row + 1, col + 1] = (char)(BombPlaceField[row + 1, col + 1] + 48);
                    Left(row + 1, col + 1);
                    Right(row + 1, col + 1);
                    Up(row + 1, col + 1);
                    Down(row + 1, col + 1);
                    DownLeft(row + 1, col + 1);
                    DownRight(row + 1, col + 1);
                    UpRight(row + 1, col + 1);
                }
            }
        }
        private void UpLeft(int row, int col)
        {
            if (row > 0 && col > 0 && ShowPlaceField[row - 1, col - 1] != '0')
            {
                if (BombPlaceField[row - 1, col - 1] != 0)
                {
                    ShowPlaceField[row - 1, col - 1] = (char)(BombPlaceField[row - 1, col - 1] + 48);
                }
                else
                {
                    ShowPlaceField[row - 1, col - 1] = (char)(BombPlaceField[row - 1, col - 1] + 48);
                    Left(row - 1, col - 1);
                    Right(row - 1, col - 1);
                    Up(row - 1, col - 1);
                    Down(row - 1, col - 1);
                    DownLeft(row - 1, col - 1);
                    UpLeft(row - 1, col - 1);
                    UpRight(row - 1, col - 1);
                }
            }
        }
        private void UpRight(int row, int col)
        {
            if (row > 0 && col < 15 - 1 && ShowPlaceField[row - 1, col + 1] != '0')
            {
                if (BombPlaceField[row - 1, col + 1] != 0)
                {
                    ShowPlaceField[row - 1, col + 1] = (char)(BombPlaceField[row - 1, col + 1] + 48);
                }
                else
                {
                    ShowPlaceField[row - 1, col + 1] = (char)(BombPlaceField[row - 1, col + 1] + 48);
                    Left(row - 1, col + 1);
                    Right(row - 1, col + 1);
                    Up(row - 1, col + 1);
                    Down(row - 1, col + 1);
                    DownRight(row - 1, col + 1);
                    UpLeft(row - 1, col + 1);
                    UpRight(row - 1, col + 1);
                }
            }
        }

        private void FreePlace(int row, int col)
        {
            if (BombPlaceField[row, col] == 0)
            {
                ShowPlaceField[row, col] = (char)(BombPlaceField[row, col] + 48);
            }
            Left(row, col);
            Right(row, col);
            Up(row, col);
            Down(row, col);
            DownLeft(row, col);
            DownRight(row, col);
            UpLeft(row, col);
            UpRight(row, col);
        }

        private void MakeBombField(int Row, int Col)
        {
            for (int i = 0; i < 15; i++)
            {
                for (int n = 0; n < 15; n++)
                {
                    BombPlaceField[i, n] = 0;
                }
            }
            Random rnd = new Random();
            int y = 0;
            while (y < 30)
            {
                int row = rnd.Next(0, 15);
                int column = rnd.Next(0, 15);
                if (BombPlaceField[row, column] == 0)
                {
                    BombPlaceField[row, column] = -1;
                    y++;
                }
            }
            BombPlaceField[Row, Col] = 0;
            if (Col > 0)
            {
                BombPlaceField[Row, Col - 1] = 0;
            }
            if (Col < 15 - 1)
            {
                BombPlaceField[Row, Col + 1] = 0;
            }
            if (Row > 0)
            {
                BombPlaceField[Row - 1, Col] = 0;
                if (Col > 0)
                {
                    BombPlaceField[Row - 1, Col - 1] = 0;
                }
                if (Col < 15 - 1)
                {
                    BombPlaceField[Row - 1, Col + 1] = 0;
                }
            }
            if (Row < 15 - 1)
            {
                BombPlaceField[Row + 1, Col] = 0;
                if (Col > 0)
                {
                    BombPlaceField[Row + 1, Col - 1] = 0;
                }
                if (Col < 15 - 1)
                {
                    BombPlaceField[Row + 1, Col + 1] = 0;
                }
            }
            for (int i = 0; i < 15; i++)
            {
                for (int n = 0; n < 15; n++)
                {
                    if (BombPlaceField[i, n] != -1)
                    {
                        if (i > 0)
                        {
                            if (BombPlaceField[i - 1, n] == -1)
                            {
                                BombPlaceField[i, n]++;
                            }
                            if (n > 0)
                            {
                                if (BombPlaceField[i - 1, n - 1] == -1)
                                {
                                    BombPlaceField[i, n]++;
                                }
                            }
                            if (n < 15 - 1)
                            {
                                if (BombPlaceField[i - 1, n + 1] == -1)
                                {
                                    BombPlaceField[i, n]++;
                                }
                            }
                        }
                        if (n > 0)
                        {
                            if (BombPlaceField[i, n - 1] == -1)
                            {
                                BombPlaceField[i, n]++;
                            }
                        }
                        if (n < 15 - 1)
                        {
                            if (BombPlaceField[i, n + 1] == -1)
                            {
                                BombPlaceField[i, n]++;
                            }
                        }
                        if (i < 15 - 1)
                        {
                            if (BombPlaceField[i + 1, n] == -1)
                            {
                                BombPlaceField[i, n]++;
                            }
                            if (n > 0)
                            {
                                if (BombPlaceField[i + 1, n - 1] == -1)
                                {
                                    BombPlaceField[i, n]++;
                                }
                            }
                            if (n < 15 - 1)
                            {
                                if (BombPlaceField[i + 1, n + 1] == -1)
                                {
                                    BombPlaceField[i, n]++;
                                }
                            }
                        }
                    }
                }
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
            Console.Write("  ");
            for (int i = 0; i < 15; i++)
            {
                if (i < 10)
                {
                    Console.Write("{0} ", i + 1);
                }
                else
                {
                    Console.Write("{0}", i + 1);
                }
            }
            Console.WriteLine();
            for (int i = 1; i <= 15; i++)
            {
                if (i < 10)
                {
                    Console.Write("{0} ", i);
                }
                else
                {
                    Console.Write("{0}", i);
                }
                for (int n = 0; n < 15; n++)
                {
                    Console.Write("{0} ", ShowPlaceField[i - 1, n]);
                }
                Console.WriteLine();
            }
        }

        private void IsWinner()
        {
            int amount = 0;
            for (int Rows = 0; Rows < 15; Rows++)
            {
                for (int Columns = 0; Columns < 15; Columns++)
                {
                    if (BombPlaceField[Rows, Columns] != -1 && ShowPlaceField[Rows, Columns] == (char)(BombPlaceField[Rows, Columns] + 48))
                    {
                        amount++;
                    }
                }
            }
            if (amount == 15 * 15 - 30)
            {
                EndGame(true);
            }
        }

        private void ClearField()
        {
            for (int Rows = 0; Rows < 15; Rows++)
            {
                for (int Columns = 0; Columns < 15; Columns++)
                {
                    ShowPlaceField[Rows, Columns] = '_';
                }
            }
        }

        private void EndGame(bool Fight)
        {
            if (Fight == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("YOU LOSE HAHAHA\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("OK OK YOU WIN\n");
            }
            FirstStep = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter any key\n");
            Console.ReadKey();
            ClearField();
            Draw();
            PlaceFlag = true;
        }
    }
}
