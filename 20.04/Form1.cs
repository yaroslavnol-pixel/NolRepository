using System;
using System.Windows.Forms;

namespace MemeGallery
{
    public partial class Form1 : Form
    {
        private string[] memes = {
            Application.StartupPath + "\\memes\\meme1.jpg",
            Application.StartupPath + "\\memes\\meme2.jpg",
            Application.StartupPath + "\\memes\\meme3.jpg",
            Application.StartupPath + "\\memes\\meme4.jpg",
            Application.StartupPath + "\\memes\\meme5.jpg",
            Application.StartupPath + "\\memes\\meme6.jpg"
        };

        private int current = 0;

        public Form1()
        {
            InitializeComponent();
            ShowMeme();
        }

        private void ShowMeme()
        {
            pictureBox1.Image = Image.FromFile(memes[current]);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            current = (current + 1) % memes.Length;
            ShowMeme();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            current = (current - 1 + memes.Length) % memes.Length;
            ShowMeme();
        }
    }
}