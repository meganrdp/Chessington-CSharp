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

        // Define direction for movement
        var directions = new int[] { -1, 1 };

        // Loop through each direction
        foreach (var rowDirection in directions)
        {
            for (int i = 1; i <= 7; i++)
            {
                // Move vertically
                result.Add(Square.At(currentSquare.Row + i * rowDirection, currentSquare.Col));

                // Move horizontally
                result.Add(Square.At(currentSquare.Row, currentSquare.Col + i * rowDirection));
            }
        }

        return result;
    }
}