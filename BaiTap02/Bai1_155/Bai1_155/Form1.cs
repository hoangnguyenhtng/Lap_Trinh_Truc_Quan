using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_155
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month = int.Parse(txtMonth.Text);
            int year = int.Parse(txtYear.Text);
            lbResult.Text = "Month: " + month + " Year: " + year +
                " has: " + DateTime.DaysInMonth(year, month) + " date";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMonth_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            YellowChange(txt);
        }

        private void txtMonth_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            WhiteChange(txt);
        }
        void YellowChange(TextBox t)
        {
            t.BackColor = Color.Yellow;
        }

        void WhiteChange(TextBox t)
        {
            t.BackColor = Color.White;
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        int count = 0;
        private void Form1_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 3 == 0) this.BackColor = Color.AliceBlue;
            else if (count % 3 == 1) this.BackColor = Color.AntiqueWhite;
            else this.BackColor = Color.Azure;
        }

        private void txtMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((Convert.ToInt16(e.KeyChar) < Convert.ToInt16('0') ||
            //    Convert.ToInt16(e.KeyChar) > Convert.ToInt16('9')) &&
            //    Convert.ToInt16(e.KeyChar) != 8)
            //{
            //    MessageBox.Show("enter a digit number, please!");
            //    e.Handled = true;
            //}
            if (!char.IsDigit(e.KeyChar) && Convert.ToInt16(e.KeyChar) != 8)
            {
                MessageBox.Show("enter a digit number, please!");
                e.Handled = true;
            }
        }

        private void txtMonth_TextChanged(object sender, EventArgs e)
        {
            if(txtMonth.Text.Trim() == "" || txtYear.Text.Trim() == "")
            {
                btnResult.Enabled = false;
            }
            else
            {
                btnResult.Enabled = true;

            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
