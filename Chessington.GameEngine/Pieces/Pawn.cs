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
        if (Player == Player.White)
        {
            var currentSquare = board.FindPiece(this);

            var result = new List<Square>
            {
                Square.At(currentSquare.Row - 1, currentSquare.Col)
            };

            return result;
        }
        else
        {
            var currentSquare = board.FindPiece(this);

            var result = new List<Square>
            {
                Square.At(currentSquare.Row + 1, currentSquare.Col)
            };

            return result; 
        }
        
    }
}