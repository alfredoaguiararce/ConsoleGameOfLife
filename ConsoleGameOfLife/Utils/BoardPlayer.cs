using ConwaysGameOfLife.Abstractions;

namespace ConsoleGameOfLife.Utils
{
    public class BoardPlayer
    {
        /// <summary>
        /// The Play function prints the game board, waits for a specified delay, advances to the next
        /// generation, and clears the console.
        /// </summary>
        /// <param name="GameOfLifeBase">GameOfLifeBase is a class or interface that represents the game
        /// of life. It contains the logic and rules for the game, as well as the current state of the
        /// game board.</param>
        /// <param name="FrameDelay">The delay (in milliseconds) between each frame of the game. It
        /// determines how fast the game will be played. The default value is 50 milliseconds.</param>
        public static void Play(GameOfLifeBase Game, int FrameDelay = 50)
        {
            /* This code block is implementing the game loop for Conway's Game of Life. It repeatedly
            prints the current state of the game board using the `PrintBoard.Print` method, waits
            for a specified delay using `Thread.Sleep`, advances to the next generation of the game
            using `Game.NextGeneration`, and clears the console using `Console.Clear`. This loop
            continues indefinitely (`while (true)`) until the program is terminated. */
            do
            {
                PrintBoard.Print(Game);
                Thread.Sleep(FrameDelay);
                Game.NextGeneration();
                Console.Clear();
            } while (true);
        }
    }
}
