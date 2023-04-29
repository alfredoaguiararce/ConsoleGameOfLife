using ConwaysGameOfLife.Abstractions;

namespace ConsoleGameOfLife.Utils
{
    public class PrintBoard
    {
        /// <summary>
        /// The function prints the current state of the Game of Life board in the console.
        /// </summary>
        /// <param name="GameOfLifeBase">This is likely a class or interface that represents the game of
        /// life simulation. It may contain methods for initializing the game board, updating the board
        /// based on the rules of the game, and retrieving the current state of the board.</param>
        public static void Print(GameOfLifeBase Game)
        {
            bool[,] Board = Game.GetCurrentBoard();
            int rows = Board.GetLength(0);
            int columns = Board.GetLength(1);
            string BoardFrame = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (Board[i, j])
                    {
                        BoardFrame += "X ";
                    }
                    else
                    {
                        BoardFrame += ". ";
                    }
                }
                BoardFrame += "\n";
            }

            Console.Write(BoardFrame);
        }

        /// <summary>
        /// This function prints a numeric map of the game board.
        /// </summary>
        /// <param name="GameOfLifeBase">GameOfLifeBase is likely a class or interface that represents
        /// the game of life simulation. It may contain methods and properties related to initializing
        /// the game board, updating the board based on the rules of the game, and retrieving the
        /// current state of the board. The PrintNumericMap method is likely a helper</param>
        public static void PrintNumericMap(GameOfLifeBase Game)
        {
            bool[,] Board = Game.GetCurrentBoard();
            int rows = Board.GetLength(0);
            int columns = Board.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($" [{i},{j}] ");
                }

                Console.WriteLine();
            }
        }
    }
}
