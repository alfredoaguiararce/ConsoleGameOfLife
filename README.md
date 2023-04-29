# Game of Life Console App

Welcome to the Game of Life Console App, an implementation of Conway's Game of Life in a console application, using a library created by Alfredo Aguiar Arce.

## **Getting started**

To use this application, you need to have .NET 5.0 or higher installed on your computer. You can download it **[here](https://dotnet.microsoft.com/download)**.

1. Clone this repository to your local machine.
2. Open the solution in Visual Studio or any other C# editor of your choice.
3. Build the solution to restore the NuGet packages.
4. Run the console application.

## **How to play**

1. When the application starts, you will be prompted to enter the height and width of the game board.
2. The board will be displayed on the screen with all cells set to dead (represented by **`.`**).
3. You can activate cells by typing their coordinates in the console. For example, to activate the cell at position (2,3), you would type **`2,3`** and press Enter.
4. Once you have activated some cells, the game will start.
5. The game board will be updated every half a second, and each generation will be displayed on the screen.
6. The game will continue indefinitely until you close the console window.

## **Contributing**

If you want to contribute to this project, please follow these steps:

1. Fork this repository.
2. Create a new branch for your changes.
3. Make your changes and commit them with descriptive messages.
4. Push your changes to your forked repository.
5. Create a pull request with a description of your changes.

## **About the update**

This update replaces the previous code that generated a console menu to select patterns for the Game of Life. Now the application runs directly when starting the program and is played with a fixed pattern. However, the same game functionality and usage instructions are maintained.

## **License**

This project is licensed under the MIT License. See the **[LICENSE](https://chat.openai.com/c/LICENSE)** file for more information.
