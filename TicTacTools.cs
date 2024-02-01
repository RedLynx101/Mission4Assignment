using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4Assignment
{

    internal class TicTacTools
    {
        string position1 = "1";
        string position2 = "2";
        string position3 = "3";
        string position4 = "4";
        string position5 = "5";
        string position6 = "6";
        string position7 = "7";
        string position8 = "8";
        string position9 = "9";

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

            string board = $" {position1} | {position2} | {position3}\n" +
                           $" ---------\n" +
                           $" {position4} | {position5} | {position6}\n" +
                           $" ---------\n" +
                           $" {position7} | {position8} | {position9}\n";
           
            return board;

        }

        public bool CheckWinHorizontal(string[] positionArray)
        {
            bool result = false;

            if (positionArray[0] == "X" && positionArray[1] == "X" && positionArray[2] == "X")
            {
                Console.WriteLine("Player 1 Wins Horizontally!");
                result = true;
            }
            else if (positionArray[3] == "X" && positionArray[4] == "X" && positionArray[5] == "X")
            {
                Console.WriteLine("Player 1 Wins Horizontally!");

                result = true;
            }
            else if (positionArray[6] == "X" && positionArray[7] == "X" && positionArray[8] == "X")
            {
                Console.WriteLine("Player 1 Wins Horizontally!");

                result = true;
            }
            else if (positionArray[0] == "O" && positionArray[1] == "O" && positionArray[2] == "O")
            {
                Console.WriteLine("Player 2 Wins Horizontally!");

                result = true;
            }
            else if (positionArray[3] == "O" && positionArray[4] == "O" && positionArray[5] == "O")
            {
                Console.WriteLine("Player 2 Wins Horizontally!");
                result = true;
            }
            else if (positionArray[6] == "O" && positionArray[7] == "O" && positionArray[8] == "O")
            {
                Console.WriteLine("Player 2 Wins Horizontally!");
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public bool CheckWinVertical(string[] positionArray)
        {
            bool result = false;

            if (positionArray[0] == "X" && positionArray[3] == "X" && positionArray[6] == "X")
            {
                Console.WriteLine("Player 1 Wins Vertically!");
                result = true;
            }
            else if (positionArray[1] == "X" && positionArray[4] == "X" && positionArray[7] == "X")
            {
                Console.WriteLine("Player 1 Wins Vertically!");

                result = true;
            }
            else if (positionArray[2] == "X" && positionArray[5] == "X" && positionArray[8] == "X")
            {
                Console.WriteLine("Player 1 Wins Vertically!");

                result = true;
            }
            else if (positionArray[0] == "O" && positionArray[3] == "O" && positionArray[6] == "O")
            {
                Console.WriteLine("Player 2 Wins Vertically!");

                result = true;
            }
            else if (positionArray[1] == "O" && positionArray[4] == "O" && positionArray[7] == "O")
            {
                Console.WriteLine("Player 2 Wins Vertically!");
                result = true;
            }
            else if (positionArray[2] == "O" && positionArray[5] == "O" && positionArray[8] == "O")
            {
                Console.WriteLine("Player 2 Wins Vertically!");
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public bool CheckWinDiagonal(string[] positionArray)
        {
            bool result = false;

            if (positionArray[0] == "X" && positionArray[4] == "X" && positionArray[8] == "X")
            {
                Console.WriteLine("Player 1 Wins Diagonally!");
                result = true;
            }
            else if (positionArray[2] == "X" && positionArray[4] == "X" && positionArray[6] == "X")
            {
                Console.WriteLine("Player 1 Wins Diagonally!");

                result = true;
            }
            else if (positionArray[0] == "O" && positionArray[4] == "O" && positionArray[8] == "O")
            {
                Console.WriteLine("Player 2 Wins Diagonally!");

                result = true;
            }
            else if (positionArray[2] == "O" && positionArray[4] == "O" && positionArray[6] == "O")
            {
                Console.WriteLine("Player 2 Wins Diagonally!");
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

    }

}
