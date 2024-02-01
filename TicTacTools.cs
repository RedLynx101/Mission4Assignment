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

    }

}
