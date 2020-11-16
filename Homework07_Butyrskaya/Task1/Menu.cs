using System;
using System.Windows.Forms;

namespace Task1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);
            string msg = String.Format($"Попробуйте получить число {number}.");
            MessageBox.Show(msg, "Начинаем игру!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Game formGame = new Game(number);
            formGame.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
