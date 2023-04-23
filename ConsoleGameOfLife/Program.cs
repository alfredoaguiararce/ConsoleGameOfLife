// See https://aka.ms/new-console-template for more information

using ConsoleGameOfLife.Utils;
using ConwaysGameOfLife.Abstractions;
using ConwaysGameOfLife.Builders;

/* This code is prompting the user to input the height and width of the game board for the Game of Life
implementation. It also displays a welcome message to the user. The user's input is then converted
to integers and stored in the variables `Height` and `Width`. */
Console.WriteLine("Welcome to the game of life implementation by Alfredo Aguiar Arce");
Console.WriteLine("Write the Height of the board: ");
int Height = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write the Width of the board : ");
int Width = Convert.ToInt32(Console.ReadLine());

/* Creating a 2-dimensional boolean array with dimensions specified by the `Height` and `Width`
variables. The array is used to represent the initial state of the game board for the Game of Life
implementation. */
bool[,] InitBoard = new bool[Height, Width];

/* This code is creating an instance of the `GameOfLifeBase` class using the `GameOfLifeBuilder` class
to set its properties. The `SetAsClassicGameOfLife()` method sets the rules for the classic Game of
Life implementation. The `SetHeight()` and `SetWidth()` methods set the dimensions of the game
board. The `SetInitialGeneration()` method sets the initial state of the game board. The `Build()`
method creates the `GameOfLifeBase` instance with the specified properties. */
GameOfLifeBase Game = new GameOfLifeBuilder()
                         .SetAsClassicGameOfLife()
                         .SetHeight(Height)
                         .SetWidth(Width)
                         .SetInitialGeneration(InitBoard)
                         .Build();

PrintBoard.PrintNumericMap(Game);
Console.WriteLine("Select the cell that you want activate");

Cells.AddCells(Game);

Console.Clear();
/* This is an infinite loop that repeatedly prints the current state of the game board, waits for 500
milliseconds, calculates the next generation of the game board using the rules of the Game of Life,
waits for another 500 milliseconds, and clears the console before starting the loop again. This loop
continues indefinitely until the program is manually stopped. */
do
{
    PrintBoard.Print(Game);
    Thread.Sleep(500);

    Game.NextGeneration();
    Thread.Sleep(500);

    Console.Clear();
} while (true);
