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
        int whiteMoves = 0;
        int blackMoves = 0;

        if (Player == Player.White && whiteMoves == 0)
        {
            var result = new List<Square>
            {
                Square.At(currentSquare.Row - 2, currentSquare.Col)

            };

            whiteMoves++;

            return result;
        }
        else if (Player == Player.Black && blackMoves == 0)
        {
            var result = new List<Square>
            {
                Square.At(currentSquare.Row + 2, currentSquare.Col)

            };

            blackMoves++;

            return result;
        }
        
        else if (Player == Player.White && whiteMoves >= 1)
        {
            var result = new List<Square>
            {
                Square.At(currentSquare.Row - 1, currentSquare.Col)
            };

            whiteMoves++;

            return result;
        }
        else
        {
            var result = new List<Square>
            {
                Square.At(currentSquare.Row + 1, currentSquare.Col)
            };

            blackMoves++;

            return result;
        }       
      
    }
}