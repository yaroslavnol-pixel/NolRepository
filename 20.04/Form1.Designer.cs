namespace Minesweeper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMines = new Label();
            lblStatus = new Label();
            btnRestart = new Button();
            gamePanel = new Panel();
            SuspendLayout();
            // 
            // lblMines
            // 
            lblMines.AutoSize = true;
            lblMines.Location = new Point(80, 22);
            lblMines.Name = "lblMines";
            lblMines.Size = new Size(34, 15);
            lblMines.TabIndex = 0;
            lblMines.Text = "💣 15";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(80, 22);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 1;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(159, 405);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(157, 23);
            btnRestart.TabIndex = 2;
            btnRestart.Text = "🔄 Нова гра";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // gamePanel
            // 
            gamePanel.Location = new Point(80, 59);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(388, 226);
            gamePanel.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gamePanel);
            Controls.Add(btnRestart);
            Controls.Add(lblStatus);
            Controls.Add(lblMines);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMines;
        private Label lblStatus;
        private Button btnRestart;
        private Panel gamePanel;
    }
}
