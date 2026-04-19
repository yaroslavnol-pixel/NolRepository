namespace WinFormsApp1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();

            button1.Location = new Point(112, 234);
            button1.Name = "button1";
            button1.Size = new Size(115, 23);
            button1.TabIndex = 0;
            button1.Text = "спіймай мене";
            button1.UseVisualStyleBackColor = true;

            button2.Location = new Point(241, 105);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "";
            button2.UseVisualStyleBackColor = true;
            button2.Click += GameButtonClick;

            button3.Location = new Point(322, 105);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "";
            button3.UseVisualStyleBackColor = true;
            button3.Click += GameButtonClick;

            button4.Location = new Point(403, 105);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "";
            button4.UseVisualStyleBackColor = true;
            button4.Click += GameButtonClick;

            button5.Location = new Point(241, 134);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "";
            button5.UseVisualStyleBackColor = true;
            button5.Click += GameButtonClick;

            button6.Location = new Point(322, 134);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 5;
            button6.Text = "";
            button6.UseVisualStyleBackColor = true;
            button6.Click += GameButtonClick;

            button7.Location = new Point(403, 134);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 6;
            button7.Text = "";
            button7.UseVisualStyleBackColor = true;
            button7.Click += GameButtonClick;

            button8.Location = new Point(241, 163);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 7;
            button8.Text = "";
            button8.UseVisualStyleBackColor = true;
            button8.Click += GameButtonClick;

            button9.Location = new Point(322, 163);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 8;
            button9.Text = "";
            button9.UseVisualStyleBackColor = true;
            button9.Click += GameButtonClick;

            button10.Location = new Point(403, 163);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 9;
            button10.Text = "";
            button10.UseVisualStyleBackColor = true;
            button10.Click += GameButtonClick;

            button11.Location = new Point(112, 24);
            button11.Name = "button11";
            button11.Size = new Size(140, 41);
            button11.TabIndex = 10;
            button11.Text = "відкрити файл";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;

            button12.Location = new Point(241, 247);
            button12.Name = "button12";
            button12.Size = new Size(123, 45);
            button12.TabIndex = 11;
            button12.Text = "зберегти файл";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;

            textBox1.Location = new Point(446, 293);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 23);
            textBox1.TabIndex = 12;
            textBox1.Text = "";

            label1.AutoSize = true;
            label1.Location = new Point(59, 95);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 13;
            label1.Text = "Хрестики-Ноліки | Хід: X";
            label1.Click += label1_Click;

            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 14;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
    }
}