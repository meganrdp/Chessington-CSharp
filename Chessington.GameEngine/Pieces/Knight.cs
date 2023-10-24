using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces;

public class Knight : Piece
{
    public Knight(Player player)
        : base(player)
    {
    }

    public override IEnumerable<Square> GetAvailableMoves(Board board)
    {
        var result = new List<Square>();
        var currentSquare = board.FindPiece(this);
        
        if ((Player == Player.White) || (Player == Player.Black))
        {
            result.Add(Square.At(currentSquare.Row - 1, currentSquare.Col - 2));
            result.Add(Square.At(currentSquare.Row - 1, currentSquare.Col + 2));
            result.Add(Square.At(currentSquare.Row - 2, currentSquare.Col - 1));
            result.Add(Square.At(currentSquare.Row - 2, currentSquare.Col + 1));
            
            result.Add(Square.At(currentSquare.Row + 1, currentSquare.Col + 2));
            result.Add(Square.At(currentSquare.Row + 1, currentSquare.Col - 2));
            result.Add(Square.At(currentSquare.Row + 2, currentSquare.Col + 1));
            result.Add(Square.At(currentSquare.Row + 2, currentSquare.Col - 1));
        }
              
        return result;       
    }
}