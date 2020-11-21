using System;
using System.Windows.Forms;

namespace Task2
{
    public partial class Guessing : Form
    {
        int _number;
        public Guessing(int number)
        {
            InitializeComponent();
            _number = number;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int answer;
            if (int.TryParse(tbAnswer.Text, out answer))
            {
                if (answer < 1 || answer > 100)
                    MessageBox.Show("Будьте внимательнее. Число должно быть в промежутке от 1 до 100.",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (answer == _number)
                {
                    lblCount.Text = (int.Parse(lblCount.Text) + 1).ToString();
                    MessageBox.Show($"Вы смогли отгадать число за {int.Parse(lblCount.Text)} попыток.", "Поздравляем!", MessageBoxButtons.OK);
                    DialogResult = DialogResult.Yes;
                }
                else
                {
                    MessageBox.Show("Вы не угадали. Попробуйте ещё раз.", "Упс", MessageBoxButtons.OK);
                    lblCount.Text = (int.Parse(lblCount.Text) + 1).ToString();
                }
            }
            else
                MessageBox.Show("Вы должны ввести число от 1 до 100.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Ладно, расколемся: было загадано число {_number}.", "Конец игры", MessageBoxButtons.OK);
            DialogResult = DialogResult.No;
        }
    }
}
