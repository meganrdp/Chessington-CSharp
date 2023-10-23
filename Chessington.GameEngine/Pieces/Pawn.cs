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
        var currentSquare = board.FindPiece(this);
        
        if (Player == Player.White && currentSquare.Row == 6)
        {
            var result = new List<Square>
            {
                Square.At(currentSquare.Row - 2, currentSquare.Col),
                Square.At(currentSquare.Row - 1, currentSquare.Col)

            };

            return result;
        }
        else if (Player == Player.Black && currentSquare.Row == 1)
        {
            var result = new List<Square>
            {
                Square.At(currentSquare.Row + 2, currentSquare.Col),
                Square.At(currentSquare.Row + 1, currentSquare.Col)

            };

            return result;
        }
        
        else if (Player == Player.White && currentSquare.Row != 6)
        {
            var result = new List<Square>
            {
                Square.At(currentSquare.Row - 1, currentSquare.Col)
            };

            return result;
        }
        else
        {
            var result = new List<Square>
            {
                Square.At(currentSquare.Row + 1, currentSquare.Col)
            };

            return result;
        }       
      
    }
}