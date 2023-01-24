using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerLab
{
    internal class DiceRollerMethods
    {
        public static int GenerateRandomNumber(int DiceSide) 
        {            
            Random rand = new Random();           
            {
                int myRandomNum = rand.Next(1,DiceSide);                
                return myRandomNum;
            }
        }
        public static string ReturnValidCombination(int DiceSide1, int DiceSide2)
        {
            if (DiceSide1 == 1 && DiceSide2 == 1)
            {
                return "Snake Eyes: Two 1s";
            }
            else if(DiceSide1 == 1 && DiceSide2 == 2)
            {
                return "Ace Deuce";
            }
            else if (DiceSide1 == 6 && DiceSide2 == 6)
            {
                return "Box Cars";
            }
            else
                return "";
            
        }

        public static string ReturnValidTotal(int DiceSide1, int DiceSide2)
        {
            int TotalNumber = DiceSide1 + DiceSide2;
            if (TotalNumber == 7 || TotalNumber == 11)
            {
                return "Win!";
            }
            else if (TotalNumber == 2 || TotalNumber == 3 || TotalNumber == 12)
            {
                return "Craps:";
            }
            else
               return "";

        }
        public static string ReturnValidCombinationForOthers(int DiceSide1, int DiceSide2)
        {
            if (DiceSide1 == 2 && DiceSide2 == 6)
            {
                return "Easy Eight";
            }
            else if (DiceSide1 == 7 && DiceSide2 == 3)
            {
                return "Big one on the end";
            }
            else if (DiceSide1 == 6 && DiceSide2 == 6)
            {
                return "MidNight";
            }
            else
                return "";

        }

        public static string ReturnValidTotalForOthers(int DiceSide1, int DiceSide2)
        {
            int TotalNumber = DiceSide1 + DiceSide2;
            if (TotalNumber == 11 || TotalNumber == 16)
            {
                return "Win!";
            }
            else if (TotalNumber == 6 || TotalNumber == 8 || TotalNumber == 4)
            {
                return "Craps:";
            }
            else
                return "";

        }
    }
}
