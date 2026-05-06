namespace _04
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblGenre = new Label();
            lblYear = new Label();
            lblRating = new Label();
            lblDesc = new Label();
            lblSearch = new Label();
            lblFilterGenre = new Label();
            lblSort = new Label();
            lblCount = new Label();
            txtTitle = new TextBox();
            txtSearch = new TextBox();
            txtDescription = new TextBox();
            cmbGenre = new ComboBox();
            cmbFilterGenre = new ComboBox();
            cmbSort = new ComboBox();
            nudYear = new NumericUpDown();
            nudRating = new NumericUpDown();
            btnAdd = new Button();
            btnDelete = new Button();
            btnRandom = new Button();
            dgvMovies = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            SuspendLayout();

            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Назва:";

            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(12, 50);
            lblGenre.Name = "lblGenre";
            lblGenre.Text = "Жанр:";

            lblYear.AutoSize = true;
            lblYear.Location = new Point(12, 85);
            lblYear.Name = "lblYear";
            lblYear.Text = "Рік:";

            lblRating.AutoSize = true;
            lblRating.Location = new Point(12, 120);
            lblRating.Name = "lblRating";
            lblRating.Text = "Рейтинг:";

            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(12, 155);
            lblDesc.Name = "lblDesc";
            lblDesc.Text = "Опис:";

            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(12, 230);
            lblSearch.Name = "lblSearch";
            lblSearch.Text = "Пошук:";

            lblFilterGenre.AutoSize = true;
            lblFilterGenre.Location = new Point(12, 265);
            lblFilterGenre.Name = "lblFilterGenre";
            lblFilterGenre.Text = "Жанр:";

            lblSort.AutoSize = true;
            lblSort.Location = new Point(12, 300);
            lblSort.Name = "lblSort";
            lblSort.Text = "Сорт:";

            lblCount.AutoSize = true;
            lblCount.Location = new Point(12, 335);
            lblCount.Name = "lblCount";
            lblCount.Text = "";

            txtTitle.Location = new Point(80, 12);
            txtTitle.Width = 200;
            txtTitle.Name = "txtTitle";

            txtSearch.Location = new Point(80, 227);
            txtSearch.Width = 200;
            txtSearch.Name = "txtSearch";

            txtDescription.Location = new Point(80, 152);
            txtDescription.Width = 200;
            txtDescription.Height = 60;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";

            cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenre.Items.AddRange(new object[] { "Бойовик", "Комедія", "Драма", "Жахи", "Фантастика", "Мелодрама", "Аніме", "Документальний" });
            cmbGenre.Location = new Point(80, 47);
            cmbGenre.Width = 150;
            cmbGenre.Name = "cmbGenre";
            cmbGenre.SelectedIndex = 0;

            cmbFilterGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterGenre.Items.AddRange(new object[] { "Усі жанри", "Бойовик", "Комедія", "Драма", "Жахи", "Фантастика", "Мелодрама", "Аніме", "Документальний" });
            cmbFilterGenre.Location = new Point(80, 262);
            cmbFilterGenre.Width = 150;
            cmbFilterGenre.Name = "cmbFilterGenre";
            cmbFilterGenre.SelectedIndex = 0;

            cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSort.Items.AddRange(new object[] { "За рейтингом ↓", "За рейтингом ↑", "За роком ↓", "За роком ↑", "За назвою А-Я" });
            cmbSort.Location = new Point(80, 297);
            cmbSort.Width = 150;
            cmbSort.Name = "cmbSort";
            cmbSort.SelectedIndex = 0;

            nudYear.Location = new Point(80, 82);
            nudYear.Width = 100;
            nudYear.Minimum = 1900;
            nudYear.Maximum = 2030;
            nudYear.Value = 2026;
            nudYear.Name = "nudYear";

            nudRating.Location = new Point(80, 117);
            nudRating.Width = 100;
            nudRating.Minimum = 1;
            nudRating.Maximum = 10;
            nudRating.Value = 7;
            nudRating.DecimalPlaces = 1;
            nudRating.Increment = 0.1m;
            nudRating.Name = "nudRating";

            btnAdd.Location = new Point(12, 370);
            btnAdd.Size = new Size(90, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;

            btnDelete.Location = new Point(110, 370);
            btnDelete.Size = new Size(90, 30);
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;

            btnRandom.Location = new Point(210, 370);
            btnRandom.Size = new Size(130, 30);
            btnRandom.Name = "btnRandom";
            btnRandom.Text = "Випадковий фільм";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;

            dgvMovies.Location = new Point(360, 12);
            dgvMovies.Size = new Size(800, 420);
            dgvMovies.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovies.RowHeadersVisible = false;
            dgvMovies.AllowUserToAddRows = false;
            dgvMovies.AllowUserToDeleteRows = false;
            dgvMovies.ReadOnly = true;
            dgvMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovies.MultiSelect = false;
            dgvMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovies.Name = "dgvMovies";
            dgvMovies.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTitle", HeaderText = "Назва", FillWeight = 25 });
            dgvMovies.Columns.Add(new DataGridViewTextBoxColumn { Name = "colGenre", HeaderText = "Жанр", FillWeight = 13 });
            dgvMovies.Columns.Add(new DataGridViewTextBoxColumn { Name = "colYear", HeaderText = "Рік", FillWeight = 8 });
            dgvMovies.Columns.Add(new DataGridViewTextBoxColumn { Name = "colRating", HeaderText = "Рейтинг", FillWeight = 10 });
            dgvMovies.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDesc", HeaderText = "Опис", FillWeight = 44 });

            ClientSize = new Size(1180, 480);
            Controls.Add(dgvMovies);
            Controls.Add(btnRandom);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(nudRating);
            Controls.Add(nudYear);
            Controls.Add(cmbSort);
            Controls.Add(cmbFilterGenre);
            Controls.Add(cmbGenre);
            Controls.Add(txtDescription);
            Controls.Add(txtSearch);
            Controls.Add(txtTitle);
            Controls.Add(lblCount);
            Controls.Add(lblSort);
            Controls.Add(lblFilterGenre);
            Controls.Add(lblSearch);
            Controls.Add(lblDesc);
            Controls.Add(lblRating);
            Controls.Add(lblYear);
            Controls.Add(lblGenre);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Каталог фільмів";
            ((System.ComponentModel.ISupportInitialize)nudYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblGenre;
        private Label lblYear;
        private Label lblRating;
        private Label lblDesc;
        private Label lblSearch;
        private Label lblFilterGenre;
        private Label lblSort;
        private Label lblCount;
        private TextBox txtTitle;
        private TextBox txtSearch;
        private TextBox txtDescription;
        private ComboBox cmbGenre;
        private ComboBox cmbFilterGenre;
        private ComboBox cmbSort;
        private NumericUpDown nudYear;
        private NumericUpDown nudRating;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnRandom;
        private DataGridView dgvMovies;
    }
}