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
        MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
        DialogResult messageBoxResult;

        public Form1()
        {
            InitializeComponent();
            ob.ToogleInitialTurn();
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
            //draw
            if (this.btnOne.Enabled == false && this.btnTwo.Enabled == false && this.btnThree.Enabled == false && this.btnFour.Enabled == false && this.btnFive.Enabled == false && this.btnSix.Enabled == false && this.btnSeven.Enabled == false && this.btnEight.Enabled == false && this.btnNine.Enabled == false)
                showDraw();
            //
            //player one
            //
            if (btnOne.Text == ob.getUserOne() && btnTwo.Text == ob.getUserOne() && btnThree.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
                showWinner("One");
            }
            else if (btnOne.Text==ob.getUserOne() && btnFour.Text==ob.getUserOne() && btnSeven.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
                showWinner("One");
            }
            else if (btnOne.Text == ob.getUserOne() && btnFive.Text == ob.getUserOne() && btnNine.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
                showWinner("One");
            }
            //
            //conditions for player two
            //
            if (btnOne.Text == ob.getUserTwo() && btnTwo.Text == ob.getUserTwo() && btnThree.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
                showWinner("Two");
            }
            else if (btnOne.Text == ob.getUserTwo() && btnFour.Text == ob.getUserTwo() && btnSeven.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
                showWinner("Two");
            }
            else if (btnOne.Text == ob.getUserTwo() && btnFive.Text == ob.getUserTwo() && btnNine.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
                showWinner("Two");
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
            //draw
            if (this.btnOne.Enabled == false && this.btnTwo.Enabled == false && this.btnThree.Enabled == false && this.btnFour.Enabled == false && this.btnFive.Enabled == false && this.btnSix.Enabled == false && this.btnSeven.Enabled == false && this.btnEight.Enabled == false && this.btnNine.Enabled == false)
                showDraw();
            //conditions for player one
            if (btnOne.Text == ob.getUserOne() && btnTwo.Text == ob.getUserOne() && btnThree.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
                showWinner("One");
            }
            else if (btnTwo.Text == ob.getUserOne() && btnFive.Text == ob.getUserOne() && btnEight.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
                showWinner("One");
            }
            //conditions for player two
            if (btnOne.Text == ob.getUserTwo() && btnTwo.Text == ob.getUserTwo() && btnThree.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
                showWinner("Two");
            }
            else if (btnTwo.Text == ob.getUserTwo() && btnFive.Text == ob.getUserTwo() && btnEight.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
                showWinner("Two");
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
            //draw
            if (this.btnOne.Enabled == false && this.btnTwo.Enabled == false && this.btnThree.Enabled == false && this.btnFour.Enabled == false && this.btnFive.Enabled == false && this.btnSix.Enabled == false && this.btnSeven.Enabled == false && this.btnEight.Enabled == false && this.btnNine.Enabled == false)
                showDraw();
            //conditions for player one
            //1-2-3
            if (btnOne.Text == ob.getUserOne() && btnTwo.Text == ob.getUserOne() && btnThree.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
                showWinner("One");
            }
            else if (btnThree.Text == ob.getUserOne() && btnFive.Text == ob.getUserOne() && btnSeven.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
                showWinner("One");
            }
            //3-6-9
            else if (btnThree.Text == ob.getUserOne() && btnSix.Text == ob.getUserOne() && btnNine.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
                showWinner("One");
            }
            //player two
            if (btnOne.Text == ob.getUserTwo() && btnTwo.Text == ob.getUserTwo() && btnThree.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
                showWinner("Two");
            }
            else if (btnThree.Text == ob.getUserTwo() && btnFive.Text == ob.getUserTwo() && btnSeven.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
                showWinner("Two");
            }
            //3-6-9
            else if (btnThree.Text == ob.getUserTwo() && btnSix.Text == ob.getUserTwo() && btnNine.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
                showWinner("Two");
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
            //draw
            if (this.btnOne.Enabled == false && this.btnTwo.Enabled == false && this.btnThree.Enabled == false && this.btnFour.Enabled == false && this.btnFive.Enabled == false && this.btnSix.Enabled == false && this.btnSeven.Enabled == false && this.btnEight.Enabled == false && this.btnNine.Enabled == false)
                showDraw();
            //player one
            if (btnOne.Text == ob.getUserOne() && btnFour.Text == ob.getUserOne() && btnSeven.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
                showWinner("One");
            }
            else if (btnFour.Text == ob.getUserOne() && btnFive.Text == ob.getUserOne() && btnSix.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
                showWinner("One");
            }
            //player two
            //1-4-7
            if (btnOne.Text == ob.getUserTwo() && btnFour.Text == ob.getUserTwo() && btnSeven.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
                showWinner("Two");
            }
            else if (btnFour.Text == ob.getUserTwo() && btnFive.Text == ob.getUserTwo() && btnSix.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
                showWinner("Two");
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
            //draw
            if (this.btnOne.Enabled == false && this.btnTwo.Enabled == false && this.btnThree.Enabled == false && this.btnFour.Enabled == false && this.btnFive.Enabled == false && this.btnSix.Enabled == false && this.btnSeven.Enabled == false && this.btnEight.Enabled == false && this.btnNine.Enabled == false)
                showDraw();
            //conditions for player one
            //2-5-8
            if (btnTwo.Text == ob.getUserOne() && btnFive.Text == ob.getUserOne() && btnEight.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
                showWinner("One");
            }
            //1-5-9
            else if (btnOne.Text == ob.getUserOne() && btnFive.Text == ob.getUserOne() && btnNine.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
                showWinner("One");
            }
            //4-5-6
            else if (btnFour.Text == ob.getUserOne() && btnFive.Text == ob.getUserOne() && btnSix.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
                showWinner("One");
            }
            //3-5-7
            else if (btnThree.Text == ob.getUserOne() && btnFive.Text == ob.getUserOne() && btnSeven.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
                showWinner("One");
            }
            //conditions for player two
            //2-5-8
            if (btnTwo.Text == ob.getUserTwo() && btnFive.Text == ob.getUserTwo() && btnEight.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
                showWinner("Two");
            }
            //1-5-9
            else if (btnOne.Text == ob.getUserTwo() && btnFive.Text == ob.getUserTwo() && btnNine.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
                showWinner("Two");
            }
            //4-5-6
            else if (btnFour.Text == ob.getUserTwo() && btnFive.Text == ob.getUserTwo() && btnSix.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
                showWinner("Two");
            }
            //3-5-7
            else if (btnThree.Text == ob.getUserTwo() && btnFive.Text == ob.getUserTwo() && btnSeven.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
                showWinner("Two");
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
            //draw
            if (this.btnOne.Enabled == false && this.btnTwo.Enabled == false && this.btnThree.Enabled == false && this.btnFour.Enabled == false && this.btnFive.Enabled == false && this.btnSix.Enabled == false && this.btnSeven.Enabled == false && this.btnEight.Enabled == false && this.btnNine.Enabled == false)
                showDraw();
            //player one
            //4-5-6
            if (btnFour.Text == ob.getUserOne() && btnFive.Text == ob.getUserOne() && btnSix.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
                showWinner("One");
            }
            //3-6-9
            else if (btnThree.Text == ob.getUserOne() && btnSix.Text == ob.getUserOne() && btnNine.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
                showWinner("One");
            }
            //player two
            //4-5-6
            if (btnFour.Text == ob.getUserTwo() && btnFive.Text == ob.getUserTwo() && btnSix.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
                showWinner("Two");
            }
            //3-6-9
            else if (btnThree.Text == ob.getUserTwo() && btnSix.Text == ob.getUserTwo() && btnNine.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
                showWinner("Two");
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
            //draw
            if (this.btnOne.Enabled == false && this.btnTwo.Enabled == false && this.btnThree.Enabled == false && this.btnFour.Enabled == false && this.btnFive.Enabled == false && this.btnSix.Enabled == false && this.btnSeven.Enabled == false && this.btnEight.Enabled == false && this.btnNine.Enabled == false)
                showDraw();
            //player one
            //1-4-7
            if (btnOne.Text == ob.getUserOne() && btnFour.Text == ob.getUserOne() && btnSeven.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player one wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
                showWinner("One");
            }
            //3-5-7
            else if (btnThree.Text == ob.getUserOne() && btnFive.Text == ob.getUserOne() && btnSeven.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
                showWinner("One");
            }
            //7-8-9
            else if (btnSeven.Text == ob.getUserOne() && btnEight.Text == ob.getUserOne() && btnNine.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
                showWinner("One");
            }
            //player two
            //1-4-7
            if (btnOne.Text == ob.getUserTwo() && btnFour.Text == ob.getUserTwo() && btnSeven.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
                showWinner("Two");
            }
            //3-5-7
            else if (btnThree.Text == ob.getUserTwo() && btnFive.Text == ob.getUserTwo() && btnSeven.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
                showWinner("Two");
            }
            //7-8-9
            else if (btnSeven.Text == ob.getUserTwo() && btnEight.Text == ob.getUserTwo() && btnNine.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
                showWinner("Two");
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
            //draw
            if (this.btnOne.Enabled == false && this.btnTwo.Enabled == false && this.btnThree.Enabled == false && this.btnFour.Enabled == false && this.btnFive.Enabled == false && this.btnSix.Enabled == false && this.btnSeven.Enabled == false && this.btnEight.Enabled == false && this.btnNine.Enabled == false)
                showDraw();
            //conditions for player one
            //2-5-8
            if (btnTwo.Text == ob.getUserOne() && btnFive.Text == ob.getUserOne() && btnEight.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
                showWinner("One");
            }
            //7-8-9
            else if (btnSeven.Text == ob.getUserOne() && btnEight.Text == ob.getUserOne() && btnNine.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
                showWinner("One");
            }
            //conditions for player two
            //2-5-8
            if (btnTwo.Text == ob.getUserTwo() && btnFive.Text == ob.getUserTwo() && btnEight.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
                showWinner("Two");
            }
            //7-8-9
            else if (btnSeven.Text == ob.getUserTwo() && btnEight.Text == ob.getUserTwo() && btnNine.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
                showWinner("Two");
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
            //draw
            if (this.btnOne.Enabled == false && this.btnTwo.Enabled == false && this.btnThree.Enabled == false && this.btnFour.Enabled == false && this.btnFive.Enabled == false && this.btnSix.Enabled == false && this.btnSeven.Enabled == false && this.btnEight.Enabled == false && this.btnNine.Enabled == false)
                showDraw();
            //player one
            //1-5-9
            if (btnOne.Text == ob.getUserOne() && btnFive.Text == ob.getUserOne() && btnNine.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
                showWinner("One");
            }
            //3-6-9
            else if (btnThree.Text == ob.getUserOne() && btnSix.Text == ob.getUserOne() && btnNine.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
                showWinner("One");
            }
            //7-8-9
            else if (btnSeven.Text == ob.getUserOne() && btnEight.Text == ob.getUserOne() && btnNine.Text == ob.getUserOne())
            {
                lblInfo.Text = "Player One wins";
                ob.increaseScoreOne();
                lblPlayerOneScore.Text = ob.getScoreOne().ToString();
                showWinner("One");
            }
            //player two
            //1-5-9
            else if (btnOne.Text == ob.getUserTwo() && btnFive.Text == ob.getUserTwo() && btnNine.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
                showWinner("Two");
            }
            //3-6-9
            else if (btnThree.Text == ob.getUserTwo() && btnSix.Text == ob.getUserTwo() && btnNine.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
                showWinner("Two");
            }
            //7-8-9
            else if (btnSeven.Text == ob.getUserTwo() && btnEight.Text == ob.getUserTwo() && btnNine.Text == ob.getUserTwo())
            {
                lblInfo.Text = "Player Two wins";
                ob.increaseScoreTwo();
                lblPlayerTwoScore.Text = ob.getScoreTwo().ToString();
                showWinner("Two");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void playAgain()
        {
            if (ob.getInitialTurn())
            {
                ob.setToogleValue(true);
                lblInfo.Text = "Player One turn";
            }
            else if(ob.getInitialTurn()==false)
            {
                ob.setToogleValue(false);
                lblInfo.Text = "Player Two turn";
            }

            this.btnOne.Text = "";
            this.btnOne.Enabled = true;

            this.btnTwo.Text = "";
            this.btnTwo.Enabled = true;

            this.btnThree.Text = "";
            this.btnThree.Enabled = true;

            this.btnFour.Text = "";
            this.btnFour.Enabled = true;

            this.btnFive.Text = "";
            this.btnFive.Enabled = true;

            this.btnSix.Text = "";
            this.btnSix.Enabled = true;

            this.btnSeven.Text = "";
            this.btnSeven.Enabled = true;

            this.btnEight.Text = "";
            this.btnEight.Enabled = true;

            this.btnNine.Text = "";
            this.btnNine.Enabled = true;

            ob.ToogleInitialTurn();
        }
        private void showWinner(string player)
        {
            if (player == "One")
            {
                messageBoxResult = MessageBox.Show("\tPlayer One wins!!!\n\nDo you want to play again?", "Congratulations", messageBoxButtons);
                if (messageBoxResult == DialogResult.No)
                    Application.Exit();
                else if (messageBoxResult == DialogResult.Yes)
                {
                    playAgain();
                }
            }
            else if(player=="Two")
            {
                messageBoxResult = MessageBox.Show("\tPlayer Two wins!!!\n\nDo you want to play again?", "Congratulations", messageBoxButtons);
                if (messageBoxResult == DialogResult.No)
                    Application.Exit();
                else if (messageBoxResult == DialogResult.Yes)
                {
                    playAgain();
                }
            }
            
        }
        private void showDraw()
        {
            messageBoxResult = MessageBox.Show("\tGame Draw!!!\n\nDo you want to play again?", "Message", messageBoxButtons);
            if (messageBoxResult == DialogResult.No)
                Application.Exit();
            else if (messageBoxResult == DialogResult.Yes)
            {
                playAgain();
            }
        }
    }
}
