using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces;

public class Pawn : Piece
{
    public Pawn(Player player)
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
        }
        else 
        {
            result.Add(Square.At(currentSquare.Row + 1, currentSquare.Col));
        }
        
        if (Player == Player.White && currentSquare.Row == 6)
        {
            result.Add(Square.At(currentSquare.Row - 2, currentSquare.Col));
        }

        if (Player == Player.Black && currentSquare.Row == 1)
        {
            result.Add(Square.At(currentSquare.Row + 2, currentSquare.Col));
        }

        return result;       
      
    }
}