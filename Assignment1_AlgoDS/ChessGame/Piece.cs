/// <summary>
/// Base class for all piecies on the chessboard
/// </summary>

namespace ChessGame
{
    class Piece
    {
        string color;
        public bool hasMoved;

        // constructor to initialise New Piece
        public Piece(string color)
        {
            this.color = color;
            this.hasMoved = false;
        }

        // Piece Color return
        public string PieceColor()
        {
            return color;
        }       
        
        // Virtual Function to be inherited
        public virtual bool Move(Board board, Coordinate start, Coordinate end)
        {
            return true;
        }
    }
}
