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
        var directions = new List<Square>
        {
            Square.At(1, 0),
            Square.At(0, 1),
            Square.At(-1, 0),
            Square.At(0, -1),
        };

        // Loop through each direction
        foreach (var direction in directions)
        {
            for (int i = 1; i < 8; i++)
            {
                var square = Square.At(currentSquare.Row + i * direction.Row, currentSquare.Col + i * direction.Col);
                if (square.Row > 7 || square.Row < 0 || square.Col > 7 || square.Col <0)
                {
                    // stop because square is not on board
                    break;
                }
                result.Add(square);
            }
        }

        return result;
    }
}