using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04Task03
{
    public partial class Form1 : Form
    {
        classTicTacToe ob = new classTicTacToe();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (ob.getToogleValue())
            {
                this.btnOne.Text = ob.getUserOne();
                this.btnOne.Enabled = false;
                ob.setToogleValue(false);
                lblInfo.Text = "Player Two turn";
            }
            else
            {
                this.btnOne.Text = ob.getUserTwo();
                this.btnOne.Enabled = false;
                ob.setToogleValue(true);
                lblInfo.Text = "Player One turn";
            }
            //
            //player one
            //
            if (btnOne.Text == ob.getUserOne() && btnTwo.Text == ob.getUserOne() && btnThree.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
            }
            else if (btnOne.Text==ob.getUserOne() && btnFour.Text==ob.getUserOne() && btnSeven.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
            }
            else if (btnOne.Text == ob.getUserOne() && btnFive.Text == ob.getUserOne() && btnNine.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
            }
            //
            //conditions for player two
            //
            if (btnOne.Text == ob.getUserTwo() && btnTwo.Text == ob.getUserTwo() && btnThree.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
            }
            else if (btnOne.Text == ob.getUserTwo() && btnFour.Text == ob.getUserTwo() && btnSeven.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
            }
            else if (btnOne.Text == ob.getUserTwo() && btnFive.Text == ob.getUserTwo() && btnNine.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (ob.getToogleValue())
            {
                this.btnTwo.Text = ob.getUserOne();
                this.btnTwo.Enabled = false;
                ob.setToogleValue(false);
                lblInfo.Text = "Player Two turn";
            }
            else
            {
                this.btnTwo.Text = ob.getUserTwo();
                this.btnTwo.Enabled = false;
                ob.setToogleValue(true);
                lblInfo.Text = "Player One turn";
            }
            //conditions for player one
            if (btnOne.Text == ob.getUserOne() && btnTwo.Text == ob.getUserOne() && btnThree.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
            }
            else if (btnTwo.Text == ob.getUserOne() && btnFive.Text == ob.getUserOne() && btnEight.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
            }
            //conditions for player two
            if (btnOne.Text == ob.getUserTwo() && btnTwo.Text == ob.getUserTwo() && btnThree.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
            }
            else if (btnTwo.Text == ob.getUserTwo() && btnFive.Text == ob.getUserTwo() && btnEight.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (ob.getToogleValue())
            {
                this.btnThree.Text = ob.getUserOne();
                this.btnThree.Enabled = false;
                ob.setToogleValue(false);
                lblInfo.Text = "Player Two turn";
            }
            else
            {
                this.btnThree.Text = ob.getUserTwo();
                this.btnThree.Enabled = false;
                ob.setToogleValue(true);
                lblInfo.Text = "Player One turn";
            }
            //conditions for player one
            //1-2-3
            if (btnOne.Text == ob.getUserOne() && btnTwo.Text == ob.getUserOne() && btnThree.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
            }
            else if (btnThree.Text == ob.getUserOne() && btnFive.Text == ob.getUserOne() && btnSeven.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
            }
            //3-6-9
            else if (btnThree.Text == ob.getUserOne() && btnSix.Text == ob.getUserOne() && btnNine.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
            }
            //player two
            if (btnOne.Text == ob.getUserTwo() && btnTwo.Text == ob.getUserTwo() && btnThree.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
            }
            else if (btnThree.Text == ob.getUserTwo() && btnFive.Text == ob.getUserTwo() && btnSeven.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
            }
            //3-6-9
            else if (btnThree.Text == ob.getUserTwo() && btnSix.Text == ob.getUserTwo() && btnNine.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (ob.getToogleValue())
            {
                this.btnFour.Text = ob.getUserOne();
                this.btnFour.Enabled = false;
                ob.setToogleValue(false);
                lblInfo.Text = "Player Two turn";
            }
            else
            {
                this.btnFour.Text = ob.getUserTwo();
                this.btnFour.Enabled = false;
                ob.setToogleValue(true);
                lblInfo.Text = "Player One turn";
            }
            //player one
            if (btnOne.Text == ob.getUserOne() && btnFour.Text == ob.getUserOne() && btnSeven.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
            }
            else if (btnFour.Text == ob.getUserOne() && btnFive.Text == ob.getUserOne() && btnSix.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
            }
            //player two
            //1-4-7
            if (btnOne.Text == ob.getUserTwo() && btnFour.Text == ob.getUserTwo() && btnSeven.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
            }
            else if (btnFour.Text == ob.getUserTwo() && btnFive.Text == ob.getUserTwo() && btnSix.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (ob.getToogleValue())
            {
                this.btnFive.Text = ob.getUserOne();
                this.btnFive.Enabled = false;
                ob.setToogleValue(false);
                lblInfo.Text = "Player Two turn";
            }
            else
            {
                this.btnFive.Text = ob.getUserTwo();
                this.btnFive.Enabled = false;
                ob.setToogleValue(true);
                lblInfo.Text = "Player One turn";
            }
            //conditions for player one
            //2-5-8
            if (btnTwo.Text == ob.getUserOne() && btnFive.Text == ob.getUserOne() && btnEight.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
            }
            //1-5-9
            else if (btnOne.Text == ob.getUserOne() && btnFive.Text == ob.getUserOne() && btnNine.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
            }
            //4-5-6
            else if (btnFour.Text == ob.getUserOne() && btnFive.Text == ob.getUserOne() && btnSix.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
            }
            //3-5-7
            else if (btnThree.Text == ob.getUserOne() && btnFive.Text == ob.getUserOne() && btnSeven.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
            }
            //conditions for player two
            //2-5-8
            if (btnTwo.Text == ob.getUserTwo() && btnFive.Text == ob.getUserTwo() && btnEight.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
            }
            //1-5-9
            else if (btnOne.Text == ob.getUserTwo() && btnFive.Text == ob.getUserTwo() && btnNine.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
            }
            //4-5-6
            else if (btnFour.Text == ob.getUserTwo() && btnFive.Text == ob.getUserTwo() && btnSix.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
            }
            //3-5-7
            else if (btnThree.Text == ob.getUserTwo() && btnFive.Text == ob.getUserTwo() && btnSeven.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (ob.getToogleValue())
            {
                this.btnSix.Text = ob.getUserOne();
                this.btnSix.Enabled = false;
                ob.setToogleValue(false);
                lblInfo.Text = "Player Two turn";
            }
            else
            {
                this.btnSix.Text = ob.getUserTwo();
                this.btnSix.Enabled = false;
                ob.setToogleValue(true);
                lblInfo.Text = "Player One turn";
            }
            //player one
            //4-5-6
            if (btnFour.Text == ob.getUserOne() && btnFive.Text == ob.getUserOne() && btnSix.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
            }
            //3-6-9
            else if (btnThree.Text == ob.getUserOne() && btnSix.Text == ob.getUserOne() && btnNine.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
            }
            //player two
            //4-5-6
            if (btnFour.Text == ob.getUserTwo() && btnFive.Text == ob.getUserTwo() && btnSix.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
            }
            //3-6-9
            else if (btnThree.Text == ob.getUserTwo() && btnSix.Text == ob.getUserTwo() && btnNine.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (ob.getToogleValue())
            {
                this.btnSeven.Text = ob.getUserOne();
                this.btnSeven.Enabled = false;
                ob.setToogleValue(false);
                lblInfo.Text = "Player Two turn";
            }
            else
            {
                this.btnSeven.Text = ob.getUserTwo();
                this.btnSeven.Enabled = false;
                ob.setToogleValue(true);
                lblInfo.Text = "Player One turn";
            }
            //player one
            //1-4-7
            if (btnOne.Text == ob.getUserOne() && btnFour.Text == ob.getUserOne() && btnSeven.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player one wins";
            }
            //3-5-7
            else if (btnThree.Text == ob.getUserOne() && btnFive.Text == ob.getUserOne() && btnSeven.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
            }
            //7-8-9
            else if (btnSeven.Text == ob.getUserOne() && btnEight.Text == ob.getUserOne() && btnNine.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
            }
            //player two
            //1-4-7
            if (btnOne.Text == ob.getUserTwo() && btnFour.Text == ob.getUserTwo() && btnSeven.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
            }
            //3-5-7
            else if (btnThree.Text == ob.getUserTwo() && btnFive.Text == ob.getUserTwo() && btnSeven.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
            }
            //7-8-9
            else if (btnSeven.Text == ob.getUserTwo() && btnEight.Text == ob.getUserTwo() && btnNine.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (ob.getToogleValue())
            {
                this.btnEight.Text = ob.getUserOne();
                this.btnEight.Enabled = false;
                ob.setToogleValue(false);
                lblInfo.Text = "Player Two turn";
            }
            else
            {
                this.btnEight.Text = ob.getUserTwo();
                this.btnEight.Enabled = false;
                ob.setToogleValue(true);
                lblInfo.Text = "Player One turn";
            }
            //conditions for player one
            //2-5-8
            if (btnTwo.Text == ob.getUserOne() && btnFive.Text == ob.getUserOne() && btnEight.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
            }
            //7-8-9
            else if (btnSeven.Text == ob.getUserOne() && btnEight.Text == ob.getUserOne() && btnNine.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
            }
            //conditions for player two
            //2-5-8
            if (btnTwo.Text == ob.getUserTwo() && btnFive.Text == ob.getUserTwo() && btnEight.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
            }
            //7-8-9
            else if (btnSeven.Text == ob.getUserTwo() && btnEight.Text == ob.getUserTwo() && btnNine.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (ob.getToogleValue())
            {
                this.btnNine.Text = ob.getUserOne();
                this.btnNine.Enabled = false;
                ob.setToogleValue(false);
                lblInfo.Text = "Player Two turn";
            }
            else
            {
                this.btnNine.Text = ob.getUserTwo();
                this.btnNine.Enabled = false;
                ob.setToogleValue(true);
                lblInfo.Text = "Player One turn";
            }
            //player one
            //1-5-9
            if (btnOne.Text == ob.getUserOne() && btnFive.Text == ob.getUserOne() && btnNine.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
            }
            //3-6-9
            else if (btnThree.Text == ob.getUserOne() && btnSix.Text == ob.getUserOne() && btnNine.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
            }
            //7-8-9
            else if (btnSeven.Text == ob.getUserOne() && btnEight.Text == ob.getUserOne() && btnNine.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
            }
            //player two
            //1-5-9
            else if (btnOne.Text == ob.getUserTwo() && btnFive.Text == ob.getUserTwo() && btnNine.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
            }
            //3-6-9
            else if (btnThree.Text == ob.getUserTwo() && btnSix.Text == ob.getUserTwo() && btnNine.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
            }
            //7-8-9
            else if (btnSeven.Text == ob.getUserTwo() && btnEight.Text == ob.getUserTwo() && btnNine.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
            }
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
