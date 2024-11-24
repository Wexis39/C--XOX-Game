namespace XOX_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        bool isContinue = true;

        string[,] gamePosition = new string[3, 3]
        {
                {"","",""},
                {"","",""},
                {"","",""},
        };
        private void btn00_Click(object sender, EventArgs e)
        {
            string btnText = btn00.Text;
            bool isOkey;
            isOkey = MakeMove(btnText);
            if (isOkey)
            {
                btn00.Text = "X";
                btn00.ForeColor = Color.Red;
                gamePosition[0, 0] = "X";
                CheckWin("X");
                OpponentMove();
            }
        }

        private bool MakeMove(string buttonText)
        {
            if (!(buttonText == "X" || buttonText == "O"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void OpponentMove()
        {
            if (isContinue)
            {
                Random rnd = new Random();
                int opponentRandomPositionX, opponentRandomPositionY;

                opponentRandomPositionX = rnd.Next(0, 3);
                opponentRandomPositionY = rnd.Next(0, 3);

                while (gamePosition[opponentRandomPositionX, opponentRandomPositionY] == "X" || gamePosition[opponentRandomPositionX, opponentRandomPositionY] == "O")
                {
                    opponentRandomPositionX = rnd.Next(0, 3);
                    opponentRandomPositionY = rnd.Next(0, 3);
                }

                gamePosition[opponentRandomPositionX, opponentRandomPositionY] = "O";
                string btnName = $"btn{opponentRandomPositionX}{opponentRandomPositionY}";

                Button button = this.Controls[btnName] as Button;

                button.Text = "O";
                button.ForeColor = Color.Blue;

                CheckWin("O");
            }
        }
        private void CheckWin(string player)
        {
            Form2 gameOverForm = new Form2(player);

            for (int i = 0; i < 3; i++)
            {
                if (gamePosition[i, 0] == player && gamePosition[i, 1] == player && gamePosition[i, 2] == player)
                {
                    isContinue = false;
                    gameOverForm.Show();
                    this.Hide();
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (gamePosition[0, i] == player && gamePosition[1, i] == player && gamePosition[2, i] == player)
                {
                    isContinue = false;
                    gameOverForm.Show();
                    this.Hide();
                }
            }

            if (gamePosition[0, 0] == player && gamePosition[1, 1] == player && gamePosition[2, 2] == player)
            {
                isContinue = false;
                gameOverForm.Show();
                this.Hide();
            }
            if (gamePosition[0, 2] == player && gamePosition[1, 1] == player && gamePosition[2, 0] == player)
            {
                isContinue = false;
                gameOverForm.Show();
                this.Hide();
            }

            int drawPos = 0;
            foreach (var item in gamePosition)
            {
                if (item == "X" || item == "O")
                {
                    drawPos++;
                }
            }
            if (drawPos == 9&&isContinue==true)
            {
                player = "Draw";
                gameOverForm = new Form2(player);
                isContinue = false;
                gameOverForm.Show();
                this.Hide();
            }
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            string btnText = btn01.Text;
            bool isOkey;
            isOkey = MakeMove(btnText);
            if (isOkey)
            {
                btn01.Text = "X";
                btn01.ForeColor = Color.Red;
                gamePosition[0, 1] = "X";
                CheckWin("X");
                OpponentMove();
            }
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            string btnText = btn02.Text;
            bool isOkey;
            isOkey = MakeMove(btnText);
            if (isOkey)
            {
                btn02.Text = "X";
                btn02.ForeColor = Color.Red;
                gamePosition[0, 2] = "X";
                CheckWin("X");
                OpponentMove();
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            string btnText = btn10.Text;
            bool isOkey;
            isOkey = MakeMove(btnText);
            if (isOkey)
            {
                btn10.Text = "X";
                btn10.ForeColor = Color.Red;
                gamePosition[1, 0] = "X";
                CheckWin("X");
                OpponentMove();
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            string btnText = btn11.Text;
            bool isOkey;
            isOkey = MakeMove(btnText);
            if (isOkey)
            {
                btn11.Text = "X";
                btn11.ForeColor = Color.Red;
                gamePosition[1, 1] = "X";
                CheckWin("X");
                OpponentMove();
            }

        }

        private void btn12_Click(object sender, EventArgs e)
        {
            string btnText = btn12.Text;
            bool isOkey;
            isOkey = MakeMove(btnText);
            if (isOkey)
            {
                btn12.Text = "X";
                btn12.ForeColor = Color.Red;
                gamePosition[1, 2] = "X";
                CheckWin("X");
                OpponentMove();
            }
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            string btnText = btn20.Text;
            bool isOkey;
            isOkey = MakeMove(btnText);
            if (isOkey)
            {
                btn20.Text = "X";
                btn20.ForeColor = Color.Red;
                gamePosition[2, 0] = "X";
                CheckWin("X");
                OpponentMove();
            }
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            string btnText = btn21.Text;
            bool isOkey;
            isOkey = MakeMove(btnText);
            if (isOkey)
            {
                btn21.Text = "X";
                btn21.ForeColor = Color.Red;
                gamePosition[2, 1] = "X";
                CheckWin("X");
                OpponentMove();
            }
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            string btnText = btn22.Text;
            bool isOkey;
            isOkey = MakeMove(btnText);
            if (isOkey)
            {
                btn22.Text = "X";
                btn22.ForeColor = Color.Red;
                gamePosition[2, 2] = "X";
                CheckWin("X");
                OpponentMove();
            }
        }

    }
}
