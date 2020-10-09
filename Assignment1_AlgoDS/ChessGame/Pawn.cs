using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame
{
    class Pawn : Piece
    {
        public Pawn(string color) : base(color)
        {
        }
        
        // Pawn Movement validation
        public override bool Move(Board board, Coordinate start, Coordinate end)
        {
            int direction;
            if (this.PieceColor() == "white")
            {
                direction = 1;
            }
            else
            {
                direction = -1;
            }

            if (start.GetY() == end.GetY() &&
                start.GetX() + direction == end.GetX() &&
                board.GetPieceName(start.GetX() + direction, start.GetY()) == "Empty")
                return true;
            if ((start.GetY() + 1 == end.GetY() || start.GetY() - 1 == end.GetY()) &&
                start.GetX() + direction == end.GetX() &&
                board.GetPieceName(end) != "Empty" && board.GetCoordColor(end) != board.GetCoordColor(start))
            {
                return true;
            }
            return false;
        }
    }
}
