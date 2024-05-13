using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustNumber
{

    public partial class Form1 : Form
    {
        private SearchJastNumber c  = new SearchJastNumber();
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = numberBox;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            workBox.Text = c.Calcucation(Convert.ToInt32(numberBox.Text));
            numberBox.Text = "";
        }

        private void numberBox_KeyPress(object sender, KeyPressEventArgs e) 
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13 && (e.KeyChar < 96 || e.KeyChar > 105)) { e.Handled = true; }
            if (e.KeyChar == 13)
            {
                workBox.Text = c.Calcucation(Convert.ToInt32(numberBox.Text));
                numberBox.Text = "";
            }
        }
    } 
}
