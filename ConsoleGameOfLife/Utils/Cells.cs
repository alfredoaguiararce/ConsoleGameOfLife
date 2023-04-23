using ConwaysGameOfLife.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameOfLife.Utils
{
    internal class Cells
    {
        /// <summary>
        /// This function allows the user to add cells to a Game of Life board by inputting their
        /// coordinates.
        /// </summary>
        /// <param name="GameOfLifeBase">This is likely a class or object that represents the game of
        /// life simulation. It is being passed as a parameter to the AddCells method, which suggests
        /// that the method is part of the GameOfLifeBase class or is closely related to it.</param>
        public static void AddCells(GameOfLifeBase Game)
        {
            bool continueAdding = true;
            while (continueAdding)
            {
                Console.WriteLine("¿Desea agregar una nueva celda? (s/n)");
                string input = Console.ReadLine();
               /* This code block is checking the user's input to determine whether they want to add a
               new cell to the Game of Life board or not. If the user inputs "s", the program
               prompts the user to input the coordinates of the new cell and then adds it to the
               board using the `Game.SetCell()` method. If the user inputs "n", the program stops
               adding cells and exits the loop. If the user inputs anything else, the program
               prompts the user to input "s" or "n" again. */
                if (input.ToLower() == "s")
                {
                    Console.WriteLine("Ingrese los valores de la celda (x,y) separados por una coma:");
                    string cellInput = Console.ReadLine();
                    string[] cellValues = cellInput.Split(',');

                    int x, y;
                    if (int.TryParse(cellValues[0], out x) && int.TryParse(cellValues[1], out y))
                    {
                        Game.SetCell(x, y, true);
                        Console.WriteLine($"Se ha agregado la celda ({x}, {y}).");
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese sólo números separados por una coma.");
                    }
                }
                else if (input.ToLower() == "n")
                {
                    continueAdding = false;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese 's' o 'n'.");
                }
            }
        }
    }
}
