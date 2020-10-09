using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame
{
    class Queen : Piece
    {
        public Queen(string color) : base(color)
        {
        }

        // Queen's Movements validation
        public override bool Move(Board board, Coordinate start, Coordinate end)
        {
            if (Math.Abs(start.GetX() - end.GetX()) == Math.Abs(end.GetY() - start.GetY()))
            {
                int startX = start.GetX();
                int startY = start.GetY();
                int endX = end.GetX();
                int endY = end.GetY();

                while (startX != endX)
                {
                    if (startX > endX && startY > endY)
                    {
                        startX--;
                        startY--;
                    }
                    else if (startX < endX && startY > endY)
                    {
                        startX++;
                        startY--;
                    }
                    else if (startX > endX && startY < endY)
                    {
                        startX--;
                        startY++;
                    }
                    else if (startX < endX && startY < endY)
                    {
                        startX++;
                        startY++;
                    }
                    if (Math.Abs(startX - endX) >= 1 && board.GetPieceName(startX, startY) != "Empty")
                        return false;
                }
                return true;
            }
            else
            {
                if (start.GetX() == end.GetX() || start.GetY() == end.GetY())
                {
                    if (start.GetX() == end.GetX())
                    {
                        int startIndex = Math.Min(start.GetY(), end.GetY()) + 1;
                        int endIndex = Math.Max(start.GetY(), end.GetY());
                        int x = start.GetX();
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            if (board.GetPieceName(x, i) != "Empty")
                            {
                                return false;
                            }
                        }
                    }
                    else if (start.GetY() == end.GetY())
                    {
                        int startIndex = Math.Min(start.GetX(), end.GetX()) + 1;
                        int endIndex = Math.Max(start.GetX(), end.GetX());
                        int y = start.GetY();
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            if (board.GetPieceName(i, y) != "Empty")
                            {
                                return false;
                            }
                        }
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
