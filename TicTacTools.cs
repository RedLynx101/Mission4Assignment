using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4Assignment
{
    internal class TicTacTools
    {
        public string DisplayBoard(string[] board)
        {
            string result = "";

            result = "\n 1 | 2 | 3 \n" +
                     "----------- \n" +
                     " 4 | 5 | 6 \n" +
                     "----------- \n" +
                     " 7 | 8 | 9 \n";

            return result;
        }

        public bool ValidPosition(string position, string positionString)
        {
            bool result = true; // Default to valid guess

            if (position.Length != 1) // Check for only one character
            {
                Console.WriteLine("Sorry, the position is invalid - must be one number. Try again!");
                result = false;
            }
            else if (!Char.IsDigit(position[0])) // Check to see if the character is a digit
            {
                Console.WriteLine("Sorry, the position is invalid - must be a digit. Try again!");
                result = false;
            }
            else if (positionString.Contains(position)) // Check to see if the letter has already been guessed
            {
                Console.WriteLine("Sorry, the position is invalid - that position has already been played Try again!");
                result = false;
            }

            return result;
        }

        public bool CheckWinHorizontal()
        {
            bool result = false;

            return result;
        }
    }
}
