using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04Task03
{
    class classTicTacToe
    {
        private bool toogleValue=true;
        private string userOne = "O";
        private string userTwo = "X";
        private int scoreOne = 0;
        private int scoreTwo = 0;

        public bool getToogleValue()
        {
            return toogleValue;
        }
        public void setToogleValue(bool flag)
        {
            toogleValue = flag;
        }
        public string getUserOne()
        {
            return userOne;
        }
        public string getUserTwo()
        {
            return userTwo;
        }
        public int getScoreOne()
        {
            return scoreOne;
        }
        public void increaseScoreOne()
        {
            scoreOne++;
        }
        public int getScoreTwo()
        {
            return scoreTwo;
        }
        public void increaseScoreTwo()
        {
            scoreTwo++;
        }
    }
}
