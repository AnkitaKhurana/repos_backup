using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame
{
    class King : Piece
    {
        public King(string color) : base(color)
        {
        }

        // kind movements Validation
        public override bool Move(Board board, Coordinate start, Coordinate end)
        {
            int startX = start.GetX();
            int startY = start.GetY();
            int endX = end.GetX();
            int endY = end.GetY();
            if ((startX == endX - 1 && startY == endY - 1) ||
                (startX == endX - 1 && startY == endY) ||
                (startX == endX - 1 && startY == endY + 1) ||
                (startX == endX && startY == endY - 1) ||
                (startX == endX && startY == endY) ||
                (startX == endX && startY == endY + 1) ||
                (startX == endX + 1 && startY == endY - 1) ||
                (startX == endX + 1 && startY == endY) ||
                (startX == endX + 1 && startY == endY + 1))
            {
                return true;
            }
            return false;

        }
    }

}