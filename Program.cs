using System.Runtime.InteropServices;
using Mission4Assignment;

TicTacTools ttt = new TicTacTools();

string player1 = ""; // Player 1's name
string player2 = ""; // Player 2's name
int playerTurn = 0; // 0 = player 1, 1 = player 2
string playerName = ""; // Temporarily holds the current player's name
string token = ""; // Temporarily holds the current player's token
bool isContinuing = true;
string[] game = new string[9];
int position = 0;

Console.WriteLine("Welcome to our tic tac toe game!");
Console.WriteLine("Loading the playing field");
Thread.Sleep(300);
Console.Write(".");
Thread.Sleep(300);
Console.Write(".");
Thread.Sleep(300);
Console.Write(".");


Console.WriteLine("Please enter player 1's name: ");
player1 = Console.ReadLine();
Console.WriteLine("Please enter player 2's name: ");
player2 = Console.ReadLine();  

for (int i = 0; i < game.Length; i++)
{
    if (playerTurn == 0)
    {
        playerName = player1;
        token = "X";
    }
    if (playerTurn == 1)
    {
        playerName = player2;
        token = "O";
    }
    

    while (isContinuing)
    {
        Console.WriteLine($"{playerName}, please enter the position number you would like: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out position))
        {
            isContinuing = false;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
    isContinuing = true;
    game[position - 1] = token; // -1 because the array is 0 indexed
    Console.WriteLine(ttt.UpdatePrintBoard(game));
    
    if (playerTurn == 0)
    {
        playerTurn = 1;
    }
    else
    {
        playerTurn = 0;
    }
}
