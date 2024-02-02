// Authors: Nya Croft, Noah Hicks, Noah Haskett, Jensen Hermansen
// Section: 004
// Group: 4-15

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4Assignment
{
    // This class contains the logic for the tic tac toe game
    internal class TicTacTools
    {
        // The positions of the board, references
        string position1 = "1";
        string position2 = "2";
        string position3 = "3";
        string position4 = "4";
        string position5 = "5";
        string position6 = "6";
        string position7 = "7";
        string position8 = "8";
        string position9 = "9";

        // This method updates the board with the current game state
        public string UpdatePrintBoard(string[] game)
        {
            if (game.Length >= 9)
            {
                position1 = game[0];
                position2 = game[1];    
                position3 = game[2];    
                position4 = game[3];
                position5 = game[4];
                position6 = game[5];
                position7 = game[6];
                position8 = game[7];
                position9 = game[8];
            }
            else
            {
                Console.WriteLine("Array Update Error");
            }

            // The board is updated with the current game state
            string board = $" {position1} | {position2} | {position3}\n" +
                           $" ---------\n" +
                           $" {position4} | {position5} | {position6}\n" +
                           $" ---------\n" +
                           $" {position7} | {position8} | {position9}\n";
           
            // The updated board is returned
            return board;

        }

        // This method checks the current game state to see if a player has won in a horizontal line
        public bool CheckWinHorizontal(string[] positionArray, string name)
        {
            // The result is set to false by default
            bool result = false;

            // The logic to check if a player has won in a horizontal line, checks the current game state
            if (positionArray[0] == "X" && positionArray[1] == "X" && positionArray[2] == "X")
            {
                Console.WriteLine($"{name} Wins!");
                result = true;
            }
            else if (positionArray[3] == "X" && positionArray[4] == "X" && positionArray[5] == "X")
            {
                Console.WriteLine($"{name} Wins!");

                result = true;
            }
            else if (positionArray[6] == "X" && positionArray[7] == "X" && positionArray[8] == "X")
            {
                Console.WriteLine($"{name} Wins!");

                result = true;
            }
            else if (positionArray[0] == "O" && positionArray[1] == "O" && positionArray[2] == "O")
            {
                Console.WriteLine($"{name} Wins!");

                result = true;
            }
            else if (positionArray[3] == "O" && positionArray[4] == "O" && positionArray[5] == "O")
            {
                Console.WriteLine($"{name} Wins!");

                result = true;
            }
            else if (positionArray[6] == "O" && positionArray[7] == "O" && positionArray[8] == "O")
            {
                Console.WriteLine($"{name} Wins!");
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        // This method checks the current game state to see if a player has won in a vertical line
        public bool CheckWinVertical(string[] positionArray, string name)
        {
            // The result is set to false by default
            bool result = false;

            // The logic to check if a player has won in a vertical line, checks the current game state
            if (positionArray[0] == "X" && positionArray[3] == "X" && positionArray[6] == "X")
            {
                Console.WriteLine($"{name} Wins!");
                result = true;
            }
            else if (positionArray[1] == "X" && positionArray[4] == "X" && positionArray[7] == "X")
            {
                Console.WriteLine($"{name} Wins!");

                result = true;
            }
            else if (positionArray[2] == "X" && positionArray[5] == "X" && positionArray[8] == "X")
            {
                Console.WriteLine($"{name} Wins!");

                result = true;
            }
            else if (positionArray[0] == "O" && positionArray[3] == "O" && positionArray[6] == "O")
            {
                Console.WriteLine($"{name} Wins!");

                result = true;
            }
            else if (positionArray[1] == "O" && positionArray[4] == "O" && positionArray[7] == "O")
            {
                Console.WriteLine($"{name} Wins!");

                result = true;
            }
            else if (positionArray[2] == "O" && positionArray[5] == "O" && positionArray[8] == "O")
            {
                Console.WriteLine($"{name} Wins!");

                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        // This method checks the current game state to see if a player has won in a diagonal line
        public bool CheckWinDiagonal(string[] positionArray, string name)
        {
            // The result is set to false by default
            bool result = false;

            // The logic to check if a player has won in a diagonal line, checks the current game state
            if (positionArray[0] == "X" && positionArray[4] == "X" && positionArray[8] == "X")
            {
                Console.WriteLine($"{name} Wins!");

                result = true;
            }
            else if (positionArray[2] == "X" && positionArray[4] == "X" && positionArray[6] == "X")
            {
                Console.WriteLine($"{name} Wins!");

                result = true;
            }
            else if (positionArray[0] == "O" && positionArray[4] == "O" && positionArray[8] == "O")
            {
                Console.WriteLine($"{name} Wins!");

                result = true;
            }
            else if (positionArray[2] == "O" && positionArray[4] == "O" && positionArray[6] == "O")
            {
                Console.WriteLine($"{name} Wins!");

                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        // Logic to see if the array is full and no one has won
        public bool CheckTie(string[] positionArray)
        {
            if (!positionArray.Contains(" "))
            {
                Console.WriteLine("It's a tie!");
                return true;
            }
            else
            {
                return false;
            }
        }   

    }

}
