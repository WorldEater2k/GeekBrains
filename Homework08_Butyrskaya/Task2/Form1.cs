using System;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            textBox.Text = numericUpDown.Value.ToString();
        }
    }
}
