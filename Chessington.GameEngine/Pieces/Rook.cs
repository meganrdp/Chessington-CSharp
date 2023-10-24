using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces;

public class Rook : Piece
{
    public Rook(Player player)
        : base(player)
    {
    }

    public override IEnumerable<Square> GetAvailableMoves(Board board)
    {
        var result = new List<Square>();
        var currentSquare = board.FindPiece(this);
        
        if (Player == Player.White)
        {
            result.Add(Square.At(currentSquare.Row - 1, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row - 2, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row - 3, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row - 4, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row - 5, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row - 6, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row - 7, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row + 1, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row + 2, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row + 3, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row + 4, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row + 5, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row + 6, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row + 7, currentSquare.Col));
            
            result.Add(Square.At(currentSquare.Row, currentSquare.Col - 1));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col - 2));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col - 3));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col - 4));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col - 5));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col - 6));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col - 7));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col + 1));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col + 2));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col + 3));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col + 4));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col + 5));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col + 6));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col + 7));
            
        }
        else 
        {
            result.Add(Square.At(currentSquare.Row - 1, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row - 2, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row - 3, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row - 4, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row - 5, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row - 6, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row - 7, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row + 1, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row + 2, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row + 3, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row + 4, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row + 5, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row + 6, currentSquare.Col));
            result.Add(Square.At(currentSquare.Row + 7, currentSquare.Col));

            result.Add(Square.At(currentSquare.Row, currentSquare.Col - 1));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col - 2));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col - 3));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col - 4));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col - 5));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col - 6));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col - 7));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col + 1));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col + 2));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col + 3));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col + 4));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col + 5));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col + 6));
            result.Add(Square.At(currentSquare.Row, currentSquare.Col + 7));
        }
        
        return result;       
    }
}