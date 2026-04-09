using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string studentClass = txtClass.Text;
            string subject = txtSubject.Text;

            
            if (name != "" && studentClass != "" && subject != "")
            {
                lblInfo.Text = "Учень " + name + " навчається у " + studentClass + " класі та найбільше любить " + subject;
            }
            else
            {
                MessageBox.Show("Заповніть всі поля!");
            }
        }
    }
}
