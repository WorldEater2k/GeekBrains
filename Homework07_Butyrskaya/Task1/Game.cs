using System;
using System.Windows.Forms;

namespace Task1
{
    public partial class Game : Form
    {
        int _number;
        int[] _previous = { -1, -1, -1 };
        public Game(int number)
        {
            InitializeComponent();
            _number = number;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            RememberValue();
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            IncreaseCounter();
            CheckNumber();
        }
        private void RememberValue()
        {
            int value = int.Parse(lblNumber.Text);
            if (_previous[0] == -1)
                _previous[0] = value;
            else if (_previous[1] == -1)
                _previous[1] = value;
            else if (_previous[2] == -1)
                _previous[2] = value;
            else
            {
                _previous[0] = _previous[1];
                _previous[1] = _previous[2];
                _previous[2] = value;
            }
        }
        private void btnMulti_Click(object sender, EventArgs e)
        {
            RememberValue();
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            IncreaseCounter();
            CheckNumber();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            RememberValue();
            lblNumber.Text = "0";
            IncreaseCounter();
        }
        private void IncreaseCounter()
        {
            lblCounter.Text = (int.Parse(lblCounter.Text) + 1).ToString();
        }
        private void CheckNumber()
        {
            if (int.Parse(lblNumber.Text) == _number)
            {
                MessageBox.Show($"Вы смогли получить число за {lblCounter.Text} действий.", "Поздравляем!", MessageBoxButtons.OK);
                DialogResult = DialogResult.Yes;
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (_previous[2] != -1)
            {
                lblNumber.Text = _previous[2].ToString();
                _previous[2] = -1;
                IncreaseCounter();
            }
            else if (_previous[1] != -1)
            {
                lblNumber.Text = _previous[1].ToString();
                _previous[1] = -1;
                IncreaseCounter();
            }
            else if (_previous[0] != -1)
            {
                lblNumber.Text = _previous[0].ToString();
                _previous[0] = -1;
                IncreaseCounter();
            }
        }
    }
}
