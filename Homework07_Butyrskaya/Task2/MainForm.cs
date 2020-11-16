using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);
            MessageBox.Show("Мы загадали число от 1 до 100. Попробуйте его отгадать!",
                            "Игра началась", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Guessing g = new Guessing(number);
            g.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
