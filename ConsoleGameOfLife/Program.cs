// See https://aka.ms/new-console-template for more information

using ConsoleGameOfLife.Utils;
using ConwaysGameOfLife.Abstractions;
using ConwaysGameOfLife.Builders;
using MenuBuilder.Builders.MenuBuilder;

/* This code is creating a console menu using the `ConsoleMenuBuilder` class. The menu has four
options, each representing a different pattern for the Game of Life cellular automaton. The options
are labeled with numbers and names, and each one is associated with a specific action that will be
executed when the user selects it. The `AsLoop()` method ensures that the menu will keep looping
until the user chooses to exit. The `setClearInEveryLoop()` method clears the console screen before
displaying the menu again in each loop iteration. Finally, the `Build()` method creates and displays
the menu. */
new ConsoleMenuBuilder()
    .SetFirstPrompt("Select a Game of life pattern example : ")
    .AsLoop()
    .AddOption("1", "Glider Gun", GliderGun())
    .AddOption("2", "Pulsar", Pulsar())
    .AddOption("3", "Goster Glider Gun", GosperGliderGun())
    .AddOption("4", "Pentadecathlon", Pentadecathlon())
    .setClearInEveryLoop()
    .Build();

/// <summary>
/// The function creates a Game of Life board with the Glider Gun pattern and plays it for 10
/// generations.
/// </summary>
/// <returns>
/// A lambda expression that defines a method to create and play the Game of Life with the Glider Gun
/// pattern.
/// </returns>
static Action GliderGun()
{
    return () =>
    {
        int Width = 50;
        int Height = 80;
        bool[,] Board = new bool[Width, Height];

        // Patrón del Glider Gun
        Board[5, 1] = true;
        Board[6, 1] = true;
        Board[5, 2] = true;
        Board[6, 2] = true;

        Board[3, 13] = true;
        Board[3, 14] = true;
        Board[4, 12] = true;
        Board[4, 16] = true;
        Board[5, 11] = true;
        Board[5, 17] = true;
        Board[6, 11] = true;
        Board[6, 15] = true;
        Board[6, 17] = true;
        Board[6, 18] = true;
        Board[7, 11] = true;
        Board[7, 17] = true;
        Board[8, 12] = true;
        Board[8, 16] = true;
        Board[9, 13] = true;
        Board[9, 14] = true;

        Board[1, 25] = true;
        Board[2, 23] = true;
        Board[2, 25] = true;
        Board[3, 21] = true;
        Board[3, 22] = true;
        Board[4, 21] = true;
        Board[4, 22] = true;
        Board[5, 21] = true;
        Board[5, 22] = true;
        Board[6, 23] = true;
        Board[6, 25] = true;
        Board[7, 25] = true;

        Board[3, 35] = true;
        Board[3, 36] = true;
        Board[4, 35] = true;
        Board[4, 36] = true;

        GameOfLifeBase Game = new GameOfLifeBuilder()
                         .SetAsClassicGameOfLife()
                         .SetHeight(Height)
                         .SetWidth(Width)
                         .SetInitialGeneration(Board)
                         .Build();

        BoardPlayer.Play(Game, 10);
    };
}


/// <summary>
/// The function creates a pulsar pattern in the Game of Life and plays it for 10 generations.
/// </summary>
/// <returns>
/// A lambda expression that creates a Pulsar pattern in the Game of Life and plays it for 10
/// generations using the BoardPlayer class.
/// </returns>
static Action Pulsar()
{
    return () =>
    {
        // Pulsar pattern
        int Width = 15;
        int Height = 15;
        bool[,] Board = new bool[Width, Height];

        Board[1, 3] = true;
        Board[1, 4] = true;
        Board[1, 5] = true;
        Board[1, 9] = true;
        Board[1, 10] = true;
        Board[1, 11] = true;

        Board[3, 1] = true;
        Board[4, 1] = true;
        Board[5, 1] = true;
        Board[3, 6] = true;
        Board[4, 6] = true;
        Board[5, 6] = true;
        Board[3, 8] = true;
        Board[4, 8] = true;
        Board[5, 8] = true;
        Board[3, 13] = true;
        Board[4, 13] = true;
        Board[5, 13] = true;

        Board[9, 3] = true;

        GameOfLifeBase Game = new GameOfLifeBuilder()
                         .SetAsClassicGameOfLife()
                         .SetHeight(Height)
                         .SetWidth(Width)
                         .SetInitialGeneration(Board)
                         .Build();

        BoardPlayer.Play(Game, 10);
    };
}


/// <summary>
/// The function sets up and plays the classic Game of Life pattern called Gosper Glider Gun.
/// </summary>
/// <returns>
/// A lambda expression that creates and plays the GosperGliderGun pattern in the Game of Life.
/// </returns>
static Action GosperGliderGun()
{
    return () =>
    {
        // GosperGliderGun pattern
        int Width = 40;
        int Height = 40;
        bool[,] Board = new bool[Width, Height];

        Board[5, 1] = true;
        Board[6, 1] = true;
        Board[5, 2] = true;
        Board[6, 2] = true;

        Board[3, 13] = true;
        Board[3, 14] = true;
        Board[4, 12] = true;
        Board[4, 16] = true;
        Board[5, 11] = true;
        Board[5, 17] = true;
        Board[6, 11] = true;
        Board[6, 15] = true;
        Board[6, 17] = true;
        Board[6, 18] = true;
        Board[7, 11] = true;
        Board[7, 17] = true;
        Board[8, 12] = true;
        Board[8, 16] = true;
        Board[9, 13] = true;
        Board[9, 14] = true;

        Board[1, 25] = true;
        Board[2, 23] = true;
        Board[2, 25] = true;
        Board[3, 21] = true;
        Board[3, 22] = true;
        Board[4, 21] = true;
        Board[4, 22] = true;
        Board[5, 21] = true;
        Board[5, 22] = true;
        Board[6, 23] = true;
        Board[6, 25] = true;
        Board[7, 25] = true;

        Board[3, 35] = true;
        Board[3, 36] = true;
        Board[4, 35] = true;
        Board[4, 36] = true;

        GameOfLifeBase Game = new GameOfLifeBuilder()
                                 .SetAsClassicGameOfLife()
                                 .SetHeight(Height)
                                 .SetWidth(Width)
                                 .SetInitialGeneration(Board)
                                 .Build();

        BoardPlayer.Play(Game, 10);
    };
}

/// <summary>
/// The function creates a Game of Life simulation with the Pentadecathlon pattern.
/// </summary>
/// <returns>
/// A lambda expression that defines an action.
/// </returns>
static Action Pentadecathlon()
{
    return () =>
    {

        int Width = 20;
        int Height = 20;
        bool[,] Board = new bool[Width, Height];

        // Patrón Pentadecathlon
        Board[9, 7] = true;
        Board[10, 7] = true;
        Board[11, 6] = true;
        Board[11, 8] = true;
        Board[12, 7] = true;
        Board[13, 7] = true;
        Board[14, 7] = true;
        Board[15, 6] = true;
        Board[15, 8] = true;
        Board[16, 7] = true;
        Board[17, 7] = true;
        Board[18, 7] = true;

        GameOfLifeBase Game = new GameOfLifeBuilder()
                         .SetAsClassicGameOfLife()
                         .SetHeight(Height)
                         .SetWidth(Width)
                         .SetInitialGeneration(Board)
                         .Build();

        BoardPlayer.Play(Game);
    };
};