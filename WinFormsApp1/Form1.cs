using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turnCount = 0;
        string currentFilePath = "";

        private string[] board = new string[9];
        private string currentPlayer = "X";
        private Button[] gameButtons = null!;
        private bool gameOver = false;

        public Form1()
        {
            InitializeComponent();
            button1.MouseEnter += new EventHandler(button1_MouseEnter);

            gameButtons = new Button[] {
                button2, button3, button4,
                button5, button6, button7,
                button8, button9, button10
            };

            ResetGame();
        }

        private void button1_Click(object sender, EventArgs e) { }

        private void button1_MouseEnter(object? sender, EventArgs e)
        {
            Random rnd = new Random();
            int newX = rnd.Next(0, ClientSize.Width - button1.Width);
            int newY = rnd.Next(0, ClientSize.Height - button1.Height);
            button1.Location = new Point(newX, newY);
        }

        private void ResetGame()
        {
            board = new string[9];
            currentPlayer = "X";
            gameOver = false;
            turnCount = 0;
            turn = true;

            for (int i = 0; i < gameButtons.Length; i++)
            {
                gameButtons[i].Text = "";
                gameButtons[i].Enabled = true;
                gameButtons[i].BackColor = SystemColors.Control;
            }

            label1.Text = "Хрестики-Ноліки | Хід: X";
        }

        private void GameButtonClick(object sender, EventArgs e)
        {
            if (gameOver) return;

            Button clicked = (Button)sender;
            int index = Array.IndexOf(gameButtons, clicked);

            if (!string.IsNullOrEmpty(board[index])) return;

            board[index] = currentPlayer;
            clicked.Text = currentPlayer;
            clicked.ForeColor = currentPlayer == "X" ? Color.Blue : Color.Red;
            clicked.Enabled = false;

            turnCount++;

            if (CheckWinner(currentPlayer))
            {
                label1.Text = $"Переміг: {currentPlayer}! 🎉";
                gameOver = true;
                MessageBox.Show($"Переміг {currentPlayer}!\nНатисніть OK для нової гри.");
                ResetGame();
                return;
            }

            if (turnCount == 9)
            {
                label1.Text = "Нічия!";
                gameOver = true;
                MessageBox.Show("Нічия!\nНатисніть OK для нової гри.");
                ResetGame();
                return;
            }

            currentPlayer = currentPlayer == "X" ? "O" : "X";
            label1.Text = $"Хрестики-Ноліки | Хід: {currentPlayer}";
        }

        private bool CheckWinner(string player)
        {
            int[,] wins = {
                {0,1,2}, {3,4,5}, {6,7,8},
                {0,3,6}, {1,4,7}, {2,5,8},
                {0,4,8}, {2,4,6}
            };

            for (int i = 0; i < wins.GetLength(0); i++)
            {
                if (board[wins[i, 0]] == player &&
                    board[wins[i, 1]] == player &&
                    board[wins[i, 2]] == player)
                    return true;
            }
            return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = ofd.FileName;
                textBox1.Text = File.ReadAllText(currentFilePath);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                using SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text files (*.txt)|*.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                    currentFilePath = sfd.FileName;
                else
                    return;
            }

            File.WriteAllText(currentFilePath, textBox1.Text);
            MessageBox.Show("Збережено! ✅");
        }
    }
}