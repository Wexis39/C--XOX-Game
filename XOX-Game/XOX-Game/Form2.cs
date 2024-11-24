using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOX_Game
{
    public partial class Form2 : Form
    {
        public Form2(string wonPlayer)
        {
            if(wonPlayer == "X"||wonPlayer=="O")
            {
                InitializeComponent();
                lblWon.Text = $"{wonPlayer} Won !";
            }
            else
            {
                InitializeComponent();
                lblWon.Text = $"Draw !";
            }
        }

        Form1 mainForm = new Form1();

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void brnRestart_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
        }
    }
}
