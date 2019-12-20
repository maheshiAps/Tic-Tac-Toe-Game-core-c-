using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int player = 2;
        public int turns = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (player % 2 == 0)
                {
                    button.Text = "x";
                    player++;
                    turns++;
                }
                else
                {
                    button.Text = "o";
                    player++;
                    turns++;
                }
                if(CheckDrow()==true)
                {
                    MessageBox.Show("Tie Game");
                    sd++;
                    NewGame();
                }
                if(CheckWinner() == true)
                {
                    if(button.Text=="x")
                    {
                        MessageBox.Show("X won!");
                        s1++;
                        NewGame();
                    }
                    else
                    {
                        MessageBox.Show("O won!");
                        s2++;
                        NewGame();
                    }
                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XWin.Text = "X: " + s1;
            OWin.Text = "O: " + s2;
            Drows.Text = "Drows " + sd;
        }

        private void EButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        void NewGame()
        {
            player = 2;
            turns = 0;
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";
            XWin.Text = "X: " + s1;
            OWin.Text = "O: " + s2;
            Drows.Text = "Drows " + sd;
        }

        private void NGButton_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        bool CheckDrow()
        {
            if ((turns == 9) && CheckWinner()== false)
                return true;
            else
                return false;

        }
        bool CheckWinner()
        {

            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && (A00.Text != ""))
                return true;
            if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && (A10.Text != ""))
                return true;
            if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && (A20.Text != ""))
                return true;
            if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && (A00.Text != ""))
                return true;
            if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && (A01.Text != ""))
                return true;
            if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && (A02.Text != ""))
                return true;
            if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && (A00.Text != ""))
                return true;
            if ((A02.Text == A11.Text) && (A11.Text == A20.Text) && (A02.Text != ""))
                return true;
            else
                return false;
        }

        private void RButton_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NewGame();
        }
    }
}
