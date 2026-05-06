using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace _04
{
    public partial class Form1 : Form
    {
        private List<Movie> movies = new List<Movie>();
        private string filePath = "movies.json";
        private Random rng = new Random();

        public Form1()
        {
            InitializeComponent();
            txtSearch.TextChanged += (s, e) => RefreshGrid();
            cmbFilterGenre.SelectedIndexChanged += (s, e) => RefreshGrid();
            cmbSort.SelectedIndexChanged += (s, e) => RefreshGrid();
            LoadMovies();
            RefreshGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            if (string.IsNullOrEmpty(title)) { ShowErr("Введіть назву фільму!"); return; }
            if (cmbGenre.SelectedItem == null) { ShowErr("Оберіть жанр!"); return; }

            movies.Add(new Movie
            {
                Title = title,
                Genre = cmbGenre.SelectedItem.ToString(),
                Year = (int)nudYear.Value,
                Rating = (double)nudRating.Value,
                Description = txtDescription.Text.Trim()
            });

            SaveMovies();
            RefreshGrid();
            txtTitle.Clear();
            txtDescription.Clear();
            nudRating.Value = 7;
            nudYear.Value = 2026;
            txtTitle.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedRows.Count == 0) return;
            int idx = dgvMovies.SelectedRows[0].Index;
            var visible = GetFiltered();
            if (idx < 0 || idx >= visible.Count) return;

            if (MessageBox.Show($"Видалити «{visible[idx].Title}»?", "Підтвердження",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                movies.Remove(visible[idx]);
                SaveMovies();
                RefreshGrid();
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            var list = GetFiltered();
            if (list.Count == 0) { ShowErr("Немає фільмів для вибору!"); return; }
            var m = list[rng.Next(list.Count)];
            MessageBox.Show(
                $"{m.Title}\n{m.Genre}  |  {m.Year}  |  {m.Rating:F1}/10\n\n{m.Description}",
                "Сьогодні дивимось...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private List<Movie> GetFiltered()
        {
            string search = txtSearch.Text.Trim().ToLower();
            string genre = cmbFilterGenre.SelectedItem?.ToString() ?? "Усі жанри";

            var list = movies
                .Where(m => string.IsNullOrEmpty(search) || m.Title.ToLower().Contains(search))
                .Where(m => genre == "Усі жанри" || m.Genre == genre)
                .ToList();

            return (cmbSort.SelectedIndex) switch
            {
                0 => list.OrderByDescending(m => m.Rating).ToList(),
                1 => list.OrderBy(m => m.Rating).ToList(),
                2 => list.OrderByDescending(m => m.Year).ToList(),
                3 => list.OrderBy(m => m.Year).ToList(),
                4 => list.OrderBy(m => m.Title).ToList(),
                _ => list
            };
        }

        private void RefreshGrid()
        {
            dgvMovies.Rows.Clear();
            var list = GetFiltered();
            foreach (var m in list)
                dgvMovies.Rows.Add(m.Title, m.Genre, m.Year, $"{m.Rating:F1} / 10", m.Description);
            lblCount.Text = $"Фільмів: {list.Count} / {movies.Count}";
        }

        private void SaveMovies()
        {
            try
            {
                var json = JsonSerializer.Serialize(movies, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex) { ShowErr("Помилка збереження: " + ex.Message); }
        }

        private void LoadMovies()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var json = File.ReadAllText(filePath);
                    movies = JsonSerializer.Deserialize<List<Movie>>(json) ?? new List<Movie>();
                }
            }
            catch { movies = new List<Movie>(); }
        }

        private void ShowErr(string msg) =>
            MessageBox.Show(msg, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    public class Movie
    {
        public string Title { get; set; } = "";
        public string Genre { get; set; } = "";
        public int Year { get; set; }
        public double Rating { get; set; }
        public string Description { get; set; } = "";
    }
}