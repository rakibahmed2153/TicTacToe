using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private bool isPlayerOneTurn;
        private int buttonClickesCount;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnabledButtons(true);
            startGameToolStripMenuItem.Enabled = false;
            newGameToolStripMenuItem.Enabled = true;
            EnabledPlayerOptions(false);

            isPlayerOneTurn = radioButton1.Checked;
            buttonClickesCount = 0;
        }
     
        private void EnabledButtons(bool enable)
        {

            button1.Enabled = enable;
            button2.Enabled = enable;
            button3.Enabled = enable;
            button4.Enabled = enable;
            button5.Enabled = enable;
            button6.Enabled = enable;
            button7.Enabled = enable;
            button8.Enabled = enable;
            button9.Enabled = enable;

        }
        private void ResetGame()
        {
            EnabledButtons(false);
            startGameToolStripMenuItem.Enabled = true;
            newGameToolStripMenuItem.Enabled = false;

            EnabledPlayerOptions(true);

            ClearButton();
        }

        private void ClearButton()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        private void EnabledPlayerOptions(bool enable)
        {

            groupBox3.Enabled = enable;
            groupBox1.Enabled = enable;
            groupBox2.Enabled = enable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnabledButtons(false);

            startGameToolStripMenuItem.Enabled = true;
            newGameToolStripMenuItem.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Button b =(Button)sender;
            if (isPlayerOneTurn == true)
            {
                if (radioButton3.Checked)

                    b.Text = "X";
                  //  b.ForeColor.GetBrightness();
                else
                    b.Text = "O";
                     
                isPlayerOneTurn = false;
                b.Enabled = false;

            }

            else
            {
                if (radioButton4.Checked)

                    b.Text = "X";
                else
                    b.Text = "O";

                
                isPlayerOneTurn = true;
                b.Enabled = false;







            }
            buttonClickesCount++;

            CheckTheWinner();
           
        }
    
        private void CheckTheWinner()
        {
            bool isWinner = false;
            if (buttonClickesCount == 9)
            {
                MessageBox.Show("The Game Is Drawn,Please Reset The Game", " Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetGame();
            }
            else
            {

                if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (!button1.Enabled))
                    isWinner = true;

                else
                    if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button4.Enabled))
                        isWinner = true;

                else
                    if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (!button7.Enabled))
                        isWinner = true;
                else
                    if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button7.Enabled))
                        isWinner = true;
                else
                    if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button2.Enabled))
                        isWinner = true;
                else
                    if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button9.Enabled))
                         isWinner = true;
                else
                    if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button9.Enabled))
                        isWinner = true;
                else
                    if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button7.Enabled))
                         isWinner = true;

                if (isWinner == true)
                {
                    if (isPlayerOneTurn == false)
                        MessageBox.Show(textBox1.Text + " Is the Winner", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(textBox2.Text + " Is the Winner", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetGame();

                }
            }
        }

       
    }
}
