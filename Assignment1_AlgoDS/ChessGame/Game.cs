using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame
{
    class Game
    {
        // Game Members
        private Board board;
        private Player player;

        // Initialise new game
        public Game()
        {
            this.board = new Board();
            this.player = new Player("white");
        }

        // Start New Game
        public void StartGame()
        {
            Console.Clear();
            DisplayBoard();
            TakeInput();
        }

        // Display Board
        public void DisplayBoard()
        {
            board.Display();
        }

        private Coordinate FindXY(string alphaCoord)
        {
            char col = alphaCoord[0];
            int column = 0;
            switch (col)
            {
                case 'a':
                    column = 0;
                    break;
                case 'b':
                    column = 1;
                    break;
                case 'c':
                    column = 2;
                    break;
                case 'd':
                    column = 3;
                    break;
                case 'e':
                    column = 4;
                    break;
                case 'f':
                    column = 5;
                    break;
                case 'g':
                    column = 6;
                    break;
                case 'h':
                    column = 7;
                    break;
                default: break;

            }
            int row = alphaCoord[1] - '0';
            return new Coordinate(row - 1, column);
        }
        Piece findPiece(Coordinate point)
        {
            return board.AtXY(point);
        }
        bool CheckValidColor(Coordinate start)
        {
            if (this.player.CurrentPlayer() == board.GetCoordColor(start))
            {
                return true;
            }
            return false;
        }
        bool CheckValidMove(Coordinate start, Coordinate end)
        {
            if (board.GetCoordColor(start) == board.GetCoordColor(end))
            {
                return false;
            }
            Piece pieceAtStart = findPiece(start);
            string name = pieceAtStart.GetType().Name;
            bool shouldMove = false;
            switch (name)
            {
                case "Empty":
                    Console.WriteLine("No Piece at given Position");
                    return false;
                default:
                    shouldMove = pieceAtStart.Move(board, start, end);
                    break;
            }
            return shouldMove;
        }
        public void GameOver()
        {
            Console.WriteLine("Game Over");
            Console.WriteLine(this.player.CurrentPlayer() + " Won!!");
        }
        public void TakeInput()
        {
            string startCoord;
            string endCoord;
            Console.WriteLine(this.player.CurrentPlayer() + " Enter Your Move");
            Console.Write("Starting Coordinate : ");
            startCoord = Console.ReadLine();
            Console.Write("Ending Coordinate : ");
            endCoord = Console.ReadLine();
            if (startCoord == endCoord)
            {
                StartGame();
            }
            else
            {
                Coordinate start = FindXY(startCoord);
                Coordinate end = FindXY(endCoord);
                if (CheckValidColor(start))
                {
                    if (CheckValidMove(start, end) == true)
                    {
                        {
                            char temp = board.GetCoord(start.GetX(), start.GetY());
                            if (board.GetCoord(end.GetX(), end.GetY()) == 'K' || board.GetCoord(end.GetX(), end.GetY()) == 'k')
                            {
                                GameOver();
                                return;
                            }
                            board.SetCoord(end.GetX(), end.GetY(), temp);
                            board.SetCoord(start.GetX(), start.GetY(), 'X');
                        }

                        this.player.ChangePlayer();
                        StartGame();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Move in");
                        StartGame();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Move out");
                    StartGame();
                }
            }

        }
    }
}
