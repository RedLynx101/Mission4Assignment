using System.Runtime.InteropServices;
using Mission4Assignment;

TicTacTools ttt = new TicTacTools();

string[] gameBoardArray = new string[9];

string gameBoard = "";
string p1Position = "";
string positionsPlayed = "";
bool gameOver = false;

// Welcome the user to the game

Console.WriteLine("Welcome to our tic tac toe game!");
Console.WriteLine("Loading the playing field");
Thread.Sleep(300);
Console.Write(".");
Thread.Sleep(300);
Console.Write(".");
Thread.Sleep(300);
Console.Write(".");


// Noah Hicks did this. DO NOT DELETE I WILL DEMOTE YOU

// Testing the commit and push again.

gameBoard = ttt.DisplayBoard(gameBoardArray);

Console.WriteLine(gameBoard);

do
{
    // Get the user's play
    Console.WriteLine("Please enter your desired position from the array Player 1");

    do
    {
        p1Position = Console.ReadLine();

    } while (!ttt.ValidPosition(p1Position, positionsPlayed));

    positionsPlayed += p1Position;

    int positionInt = int.Parse(p1Position);

    gameBoardArray[positionInt - 1] = "X";

    Console.WriteLine(string.Join(", ", gameBoardArray));

    Console.WriteLine("Please select your position Player 2");

} while (!gameOver);