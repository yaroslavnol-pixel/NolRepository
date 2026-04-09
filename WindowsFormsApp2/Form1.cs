using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtSide.Text, out double side) && side > 0)
            {
                double perimeter = 4 * side;
                double area = side * side;

                lblPerimeter.Text = "Периметр: " + perimeter.ToString();
                lblArea.Text = "Площа: " + area.ToString();
            }
            else
            {
                MessageBox.Show("Помилка! Введіть додатне число.");
            }
        }
    }
}
