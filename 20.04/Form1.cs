using System;
using System.Drawing;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        // Налаштування гри
        const int gridSize = 10;
        const int cellSize = 30;
        const int totalMines = 15;

        // Використовуємо '!' для ініціалізації пізніше, або створюємо відразу
        Button[,] buttons = new Button[gridSize, gridSize];
        bool[,] mines = new bool[gridSize, gridSize];
        bool isGameOver = false;

        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            isGameOver = false;
            gamePanel.Controls.Clear();
            mines = new bool[gridSize, gridSize];
            buttons = new Button[gridSize, gridSize];

            Random rnd = new Random();
            int placedMines = 0;
            while (placedMines < totalMines)
            {
                int x = rnd.Next(gridSize);
                int y = rnd.Next(gridSize);
                if (!mines[x, y])
                {
                    mines[x, y] = true;
                    placedMines++;
                }
            }

            for (int x = 0; x < gridSize; x++)
            {
                for (int y = 0; y < gridSize; y++)
                {
                    Button btn = new Button
                    {
                        Size = new Size(cellSize, cellSize),
                        Location = new Point(x * cellSize, y * cellSize),
                        Tag = new Point(x, y),
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        BackColor = Color.LightGray,
                        FlatStyle = FlatStyle.Standard
                    };

                    // Підписуємось на подію MouseUp (для підтримки правої кнопки)
                    btn.MouseUp += OnButtonClick;
                    buttons[x, y] = btn;
                    gamePanel.Controls.Add(btn);
                }
            }

            gamePanel.Size = new Size(gridSize * cellSize, gridSize * cellSize);
            lblMines.Text = $"💣 {totalMines}";
        }

        // ВИПРАВЛЕНО: Додано '?' для null-safety та безпечне розпакування Tag
        private void OnButtonClick(object? sender, MouseEventArgs e)
        {
            if (isGameOver || sender is not Button btn) return;

            // Безпечно отримуємо координати з Tag
            if (btn.Tag is not Point pos) return;

            if (e.Button == MouseButtons.Right)
            {
                btn.Text = btn.Text == "🚩" ? "" : "🚩";
                btn.ForeColor = Color.Red;
                return;
            }

            if (btn.Text == "🚩") return;

            if (mines[pos.X, pos.Y])
            {
                GameOver(false);
            }
            else
            {
                RevealCell(pos.X, pos.Y);
                CheckWin();
            }
        }

        private void RevealCell(int x, int y)
        {
            if (x < 0 || x >= gridSize || y < 0 || y >= gridSize) return;
            if (!buttons[x, y].Enabled) return;

            int count = CountAdjacentMines(x, y);
            buttons[x, y].Enabled = false;
            buttons[x, y].BackColor = Color.White;

            if (count > 0)
            {
                buttons[x, y].Text = count.ToString();
                SetColorForNumber(buttons[x, y], count);
            }
            else
            {
                for (int dx = -1; dx <= 1; dx++)
                {
                    for (int dy = -1; dy <= 1; dy++)
                    {
                        RevealCell(x + dx, y + dy);
                    }
                }
            }
        }

        private int CountAdjacentMines(int x, int y)
        {
            int count = 0;
            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    int nx = x + dx, ny = y + dy;
                    if (nx >= 0 && nx < gridSize && ny >= 0 && ny < gridSize && mines[nx, ny])
                        count++;
                }
            }
            return count;
        }

        private void GameOver(bool win)
        {
            isGameOver = true;
            foreach (var btn in buttons)
            {
                if (btn.Tag is Point p)
                {
                    if (mines[p.X, p.Y])
                    {
                        btn.Text = "💣";
                        btn.BackColor = Color.Red;
                    }
                }
                btn.Enabled = false;
            }
            MessageBox.Show(win ? "Ви перемогли!" : "Гра закінчена! Ви наступили на міну.");
        }

        private void CheckWin()
        {
            int opened = 0;
            foreach (var btn in buttons) if (!btn.Enabled) opened++;

            if (opened == gridSize * gridSize - totalMines)
            {
                GameOver(true);
            }
        }

        private void SetColorForNumber(Button btn, int num)
        {
            Color[] colors = { Color.Blue, Color.Green, Color.Red, Color.DarkBlue, Color.Brown, Color.Teal, Color.Black, Color.Gray };
            if (num > 0 && num <= colors.Length) btn.ForeColor = colors[num - 1];
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }
    }
}