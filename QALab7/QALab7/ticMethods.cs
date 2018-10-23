using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QALab7
{
    public class ticMethods
    {
        string[,] tictac;

        //Creating Board
        public Array createBoard()
        {
            tictac = new string[3,3];
            return tictac;
        }


        //Getting Current Player
        public string currentPlayer(int player)
        {
            if(player == 1)
            {
                return "player1";
            }
            if(player == 2)
            {
                return "player2";
            }
            else
            {
                return "";
            }
        }


        //Changing PlayAAA
        public string changePlayer(int currentPlayer)
        {
            if(currentPlayer == 1)
            {
                return "player1";
            }
            if (currentPlayer == 2)
            {
                return "player2";
            }
            else
            {
                return "";
            }
        }


        //Making mewvs outchea
        public string makeMove(int playa, int row, int col)
        {
            createBoard();
            if(playa == 1)
            {
                tictac[row, col] = "x";
                return "x";
            }
            if(playa == 2)
            {
                tictac[row, col] = "o";
                return "o";
            }
            else
            {
                return "";
            }
        }

        public bool spaceInUse(int row, int col)
        {
            createBoard();
            if (tictac[row, col] == "o")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
