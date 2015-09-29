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
    
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button21.Text = "";
            button22.Text = "";
            button23.Text = "";
            button31.Text = "";
            button32.Text = "";
            button33.Text = "";
            Focus.Select();
            SetText(1);
        }

        private void checkWinner()
        {
            if (button11.Text != "" && button12.Text != "" && button13.Text != "" &
                button21.Text != "" && button22.Text != "" && button23.Text != "" &
                button31.Text != "" && button32.Text != "" && button33.Text != "")
            {
                SetText(5);
                return;
            }

           if (button11.Text == button12.Text && button12.Text == button13.Text && button11.Text != "")
            {
                if (button11.Text == "X")
                    SetText(3);
                else
                    SetText(4);
            }
            if (button21.Text == button22.Text && button22.Text == button23.Text && button21.Text != "")
            {
                if (button21.Text == "X")
                    SetText(3);
                else
                    SetText(4);
            }
            if (button31.Text == button32.Text && button32.Text == button33.Text && button31.Text != "")
            {
                if (button31.Text == "X")
                    SetText(3);
                else
                    SetText(4);
            }
            if (button11.Text == button21.Text && button21.Text == button31.Text && button11.Text != "")
            {
                if (button11.Text == "X")
                    SetText(3);
                else
                    SetText(4);
            }
            if (button12.Text == button22.Text && button22.Text == button32.Text && button12.Text != "")
            {
                if (button12.Text == "X")
                    SetText(3);
                else
                    SetText(4);
            }
            if (button13.Text == button23.Text && button23.Text == button33.Text && button13.Text != "")
            {
                if (button13.Text == "X")
                    SetText(3);
                else
                    SetText(4);
            }
            if (button11.Text == button22.Text && button22.Text == button33.Text && button11.Text != "")
            {
                if (button11.Text == "X")
                    SetText(3);
                else
                    SetText(4);
            }
            if (button13.Text == button22.Text && button22.Text == button31.Text && button13.Text != "")
            {
                if (button13.Text == "X")
                    SetText(3);
                else
                    SetText(4);
            }
            return;
        }

        private void SetText(int i) //1 = P1Turn, 2 = P2Turn, 3 = P1Win, 4 = P2Win, 5 = Tie
        {
            if (i == 1)
            {
                Turn.Text = "Player 1's Turn";
                Turn.ForeColor = Color.DarkSlateBlue;
                return;
            }
            if (i == 2)
            {
                Turn.Text = "Player 2's Turn";
                Turn.ForeColor = Color.DarkGreen;
                return;
            }
            if (i == 3)
            {
                Turn.Text = "Player 1 has won!";
                Turn.ForeColor = Color.LawnGreen;
                return;
            }
            if (i == 4)
            {
                Turn.Text = "Player 2 has won!";
                Turn.ForeColor = Color.LawnGreen;
                return;
            }
            if (i == 5)
            {
                Turn.Text = "The game has ended in a tie!";
                Turn.ForeColor = Color.Aqua;
                return;
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (Turn.Text == "It's a tie!")
                return;
            if (button11.Text == "")
            {
                if (Turn.Text == "Player 1's Turn")
                {
                    button11.Text = "X";
                    SetText(2);
                }
                else
                {
                    button11.Text = "O";
                    SetText(1);
                }
            }
            else
                return;
            checkWinner();
            return;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Turn.Text == "The game has ended in a tie!")
                return;
            if (button12.Text == "")
            {
                if (Turn.Text == "Player 1's Turn")
                {
                    button12.Text = "X";
                    SetText(2);
                }
                else
                {
                    button12.Text = "O";
                    SetText(1);
                }
            }
            else
                return;
            checkWinner();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Turn.Text == "The game has ended in a tie!")
                return;
            if (button13.Text == "")
            {
                if (Turn.Text == "Player 1's Turn")
                {
                    button13.Text = "X";
                    SetText(2);
                }
                else
                {
                    button13.Text = "O";
                    SetText(1);
                }
            }
            else
                return;
            checkWinner();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (Turn.Text == "The game has ended in a tie!")
                return;
            if (button21.Text == "")
            {
                if (Turn.Text == "Player 1's Turn")
                {
                    button21.Text = "X";
                    SetText(2);
                }
                else
                {
                    button21.Text = "O";
                    SetText(1);
                }
            }
            else
                return;
            checkWinner();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (Turn.Text == "The game has ended in a tie!")
                return;
            if (button22.Text == "")
            {
                if (Turn.Text == "Player 1's Turn")
                {
                    button22.Text = "X";
                    SetText(2);
                }
                else
                {
                    button22.Text = "O";
                    SetText(1);
                }
            }
            else
                return;
            checkWinner();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (Turn.Text == "The game has ended in a tie!")
                return;
            if (button23.Text == "")
            {
                if (Turn.Text == "Player 1's Turn")
                {
                    button23.Text = "X";
                    SetText(2);
                }
                else
                {
                    button23.Text = "O";
                    SetText(1);
                }
            }
            else
                return;
            checkWinner();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (Turn.Text == "The game has ended in a tie!")
                return;
            if (button31.Text == "")
            {
                if (Turn.Text == "Player 1's Turn")
                {
                    button31.Text = "X";
                    SetText(2);
                }
                else
                {
                    button31.Text = "O";
                    SetText(1);
                }
            }
            else
                return;
            checkWinner();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (Turn.Text == "The game has ended in a tie!")
                return;
            if (button32.Text == "")
            {
                if (Turn.Text == "Player 1's Turn")
                {
                    button32.Text = "X";
                    SetText(2);
                }
                else
                {
                    button32.Text = "O";
                    SetText(1);
                }
            }
            else
                return;
            checkWinner();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (Turn.Text == "The game has ended in a tie!")
                return;
            if (button33.Text == "")
            {
                if (Turn.Text == "Player 1's Turn")
                {
                    button33.Text = "X";
                    SetText(2);
                }
                else
                {
                    button33.Text = "O";
                    SetText(1);
                }
            }
            else
                return;
            checkWinner();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button21.Text = "";
            button22.Text = "";
            button23.Text = "";
            button31.Text = "";
            button32.Text = "";
            button33.Text = "";
            Focus.Select();
            SetText(1);
        }
    }
}
