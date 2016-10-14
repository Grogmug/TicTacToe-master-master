using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Services;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }
        private char currentPlayer = 'X';

        public char GetOppositePlayer()
        {
            if (currentPlayer == 'X')
            {
                return 'O';
            }
            else
                return 'X';
        }

        IGameWinnerServices gameWinnerServices = new GameWinnerService();


        public void Run()
        {
            bool running = true;
            char choice;

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("It's " + currentPlayer + "'s turn!");
                GameBoardLayout();
                choice = GetUsersChoice();

                switch (choice)
                {
                    case '1':
                        if (f1 == ' ')
                        {
                            f1 = currentPlayer;
                            gameBoard[0, 0] = f1;
                            currentPlayer = GetOppositePlayer();
                        }
                        else
                            ShowSelectionErrorOne();
                        break;
                    case '2':
                        if (f2 == ' ')
                        {
                            f2 = currentPlayer;
                            gameBoard[0, 1] = f2;
                            currentPlayer = GetOppositePlayer();
                        }
                        else ShowSelectionErrorOne();
                        break;
                    case '3':
                        if (f3 == ' ')
                        {
                            f3 = currentPlayer;
                            gameBoard[0, 2] = f3;
                            currentPlayer = GetOppositePlayer();
                        }
                        else ShowSelectionErrorOne();
                        break;
                    case '4':
                        if (f4 == ' ')
                        {
                            f4 = currentPlayer;
                            gameBoard[1, 0] = f4;
                            currentPlayer = GetOppositePlayer();
                        }
                        else ShowSelectionErrorOne();
                        break;
                    case '5':
                        if (f5 == ' ')
                        {
                            f5 = currentPlayer;
                            gameBoard[1, 1] = f5;
                            currentPlayer = GetOppositePlayer();
                        }
                        else ShowSelectionErrorOne();
                        break;
                    case '6':
                        if (f6 == ' ')
                        {
                            f6 = currentPlayer;
                            gameBoard[1, 2] = f6;
                            currentPlayer = GetOppositePlayer();
                        }
                        else ShowSelectionErrorOne();
                        break;
                    case '7':
                        if (f7 == ' ')
                        {
                            f7 = currentPlayer;
                            gameBoard[2, 0] = f7;
                            currentPlayer = GetOppositePlayer();
                        }
                        else ShowSelectionErrorOne();
                        break;
                    case '8':
                        if (f8 == ' ')
                        {
                            f8 = currentPlayer;
                            gameBoard[2, 1] = f8;
                            currentPlayer = GetOppositePlayer();
                        }
                        else ShowSelectionErrorOne();
                        break;
                    case '9':
                        if (f9 == ' ')
                        {
                            f9 = currentPlayer;
                            gameBoard[2, 2] = f9;
                            currentPlayer = GetOppositePlayer();
                        }
                        else ShowSelectionErrorOne();
                        break;
                    default: ShowSelectionError(); break;
                }
                if (gameWinnerServices.Validate(gameBoard) != ' ')
                {
                    Console.Clear();
                    GameBoardLayout();
                    Console.WriteLine("Player " + GetOppositePlayer() + " wins!!!");
                    Console.ReadKey();
                    gameBoard = new char[3, 3]
                    {
                         { ' ', ' ', ' ' },
                         { ' ', ' ', ' ' },
                         { ' ', ' ', ' ' }
                    };
                    f1 = ' ';
                    f2 = ' ';
                    f3 = ' ';
                    f4 = ' ';
                    f5 = ' ';
                    f6 = ' ';
                    f7 = ' ';
                    f8 = ' ';
                    f9 = ' ';

                }
            } while (running);
        }

        private void ShowSelectionError()
        {
            Console.WriteLine("You stupid");
        }
        private void ShowSelectionErrorOne()
        {
            Console.WriteLine("That cell is already full! Choose another option.");
        }
        private void GameBoardLayout()
        {
            string b = (" _ _ _" + Environment.NewLine +
                        "|" + f1 + "|" + f2 + "|" + f3 + "|" + Environment.NewLine +
                        "|" + f4 + "|" + f5 + "|" + f6 + "|" + Environment.NewLine +
                        "|" + f7 + "|" + f8 + "|" + f9 + "|");

            Console.WriteLine(b);
        }

        private char GetUsersChoice()
        {
            Console.WriteLine("Pick a square from 1 - 9");
            return Console.ReadKey().KeyChar;
        }


        public char f1 = ' ';
        public char f2 = ' ';
        public char f3 = ' ';
        public char f4 = ' ';
        public char f5 = ' ';
        public char f6 = ' ';
        public char f7 = ' ';
        public char f8 = ' ';
        public char f9 = ' ';

        public char[,] gameBoard = new char[3, 3]
        {
                    { ' ', ' ', ' ' },
                    { ' ', ' ', ' ' },
                    { ' ', ' ', ' ' }
        };
    }
}

