using System;

namespace ChessGame
{
    class Board
    {
        private char[,] boardLayout;
        // Board Constructor
        public Board()
        {
            // Capital : Black
            // Small : White
            boardLayout = new char[8, 8] {
                { 'R','N','B','K','Q','B','N','R'},
                 { 'P','P','P','P','P','P','P','P'},
                 { 'X','X','X','X','X','X','X','X'},
                 { 'X','X','X','X','X','X','X','X'},
                 { 'X','X','X','X','X','X','X','X'},
                 { 'X','X','X','X','X','X','X','X'},
                 { 'p','p','p','p','p','p','p','p'},
                { 'r','n','b','k','q','b','n','r'}
            };
        }

        // returns board coordinate
        public char GetCoord(int x , int y)
        {
            return boardLayout[x, y];
        }

        // Get Color of a coordinate
        public string GetCoordColor(Coordinate point)
        {
            char pieceAtCoord = boardLayout[point.GetX(), point.GetY()];
            if (pieceAtCoord == 'X')
                return "none";
            if (char.IsUpper(pieceAtCoord))
            {
                return "black";
            }
            else
                return "white";
        }       

        // Set Piece on coordinate
        public void SetCoord(int x, int y,char pieceType)
        {
            boardLayout[x, y] = pieceType;
        }

        // Display Board
        public void Display()
        {
            Console.Clear();
            char start = 'A';
            int startnum = 1;
            Console.Write("      ");
            for (int row = 0; row < 8; row++, start++)

                Console.Write(start + "  ");
            Console.WriteLine();
            Console.WriteLine();
            for (int row = 0; row < 8; row++, startnum++)
            {
                Console.Write(startnum+"     ");
                for (int col = 0;col < 8; col++)
                {
                    Console.Write(boardLayout[row, col] + "  ");
                }
                Console.WriteLine();
            }
        }

        // Sets Piece Name
        public string GetPieceName(Coordinate point)
        {
            return this.GetPieceName(point.GetX(), point.GetY());
        }

        // Returns Piece Name
        public string GetPieceName(int x , int y)
        {
            char found = boardLayout[x, y];
          
            switch (found)            {
                case 'K':
                    return "King";
                case 'k':
                    return "King";
                case 'Q':
                    return "Queen";
                case 'q':
                    return "Queen";
                case 'B':
                    return "Bishop";
                case 'b':
                    return "Bishop";
                case 'N':
                    return "Knight";
                case 'n':
                    return "Knight";
                case 'R':
                    return "Rook";
                case 'r':
                    return "Rook";
                case 'P':
                    return "Pawn";
                case 'p':
                    return "Pawn";
                default:
                    return "Empty";
            }

        }

        // Returns Piece at Coordinate
        public Piece AtXY(Coordinate point)
        {
            char piece = boardLayout[point.GetX(), point.GetY()];
            switch (piece)
            {
                case 'K':
                    return new King("white");
                case 'k':
                    return new King("black");
                case 'Q':
                    return new Queen("white");
                case 'q':
                    return new Queen("black");
                case 'B':
                    return new Bishop("white");
                case 'b':
                    return new Bishop("black");
                case 'N':
                    return new Knight("white");
                case 'n':
                    return new Knight("black");
                case 'R':
                    return new Rook("white");
                case 'r':
                    return new Rook("black");
                case 'P':
                    return new Pawn("white");
                case 'p':
                    return new Pawn("black");
                default:
                    return new Empty();
            }
        }

    }
}