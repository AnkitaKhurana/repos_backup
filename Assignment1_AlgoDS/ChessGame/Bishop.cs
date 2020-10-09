using System;

namespace ChessGame
{
    class Bishop : Piece
    {
        public Bishop(string color) : base(color)
        {
        }

        // Bishop Move 
        public override bool Move(Board board, Coordinate start, Coordinate end)
        {
            if (Math.Abs(start.GetX() - end.GetX()) == Math.Abs(end.GetY() - start.GetY()))
            {
                int startX = start.GetX();
                int startY = start.GetY();
                int endX = end.GetX();
                int endY = end.GetY();
                int addI = startX - endX;
                int addJ = startY - endY;
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
            return false;
        }
    }
}