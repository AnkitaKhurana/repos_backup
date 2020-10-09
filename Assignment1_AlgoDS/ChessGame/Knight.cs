using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame
{
    class Knight : Piece
    {
        public Knight(string color) : base(color)
        {
        }

        // Knight Moevement
        public override bool Move(Board board, Coordinate start, Coordinate end)
        {
            int step1 = 1;
            int step2 = 2;
            int startX = start.GetX();
            int startY = start.GetY();
            int endX = end.GetX();
            int endY = end.GetY();

            for (int i = 0; i < 2; i++)
            {
                if (i == 1)
                {
                    step1 = 2;
                    step2 = 1;
                }
                if (startX + step1 == endX)
                {
                    if (startY + step2 == endY)
                    {
                        return true;
                    }
                }
                if (startX - step1 == endX)
                {
                    if (startY - step2 == endY)
                    {
                        return true;
                    }
                }
                if (startX - step1 == endX)
                {
                    if (startY + step2 == endY)
                    {
                        return true;
                    }
                }
                if (startX + step1 == endX)
                {
                    if (startY - step2 == endY)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
