using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("You want to exit?","Exit",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                Application.Exit();
            }
            
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor=Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor=DefaultBackColor;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor =DefaultBackColor;
        }
    }
}
