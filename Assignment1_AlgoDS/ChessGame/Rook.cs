using System;

namespace ChessGame
{
    class Rook : Piece
    {
        public Rook(string color) : base(color)
        {
        }

        // Rook's Movements Validated
        public override bool Move(Board board, Coordinate start, Coordinate end)
        {
            bool res = false;

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
                            res = false;
                            break;
                        }
                    }
                    res = true;
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
                            res = false;
                            break;
                        }
                    }
                    res = true;
                }
            }
            return res;
        }
    }
}

