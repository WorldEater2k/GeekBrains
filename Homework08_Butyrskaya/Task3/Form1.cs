using System;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        TrueFalse database;
        public Form1()
        {
            InitializeComponent();
            nudNumber.Maximum = 0;
        }
        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Файлы XML (*.xml)|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("123", true);
                database.SaveXml();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            }
        }
        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            tbQuestion.Text = database[(int)nudNumber.Value - 1].Text;
            cbTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных.", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum > 1 && database != null)
            {
                database.Remove((int)nudNumber.Value - 1);
                if (nudNumber.Value > 1)
                    nudNumber.Value--;
                else
                {
                    tbQuestion.Text = database[0].Text;
                    cbTrue.Checked = database[0].TrueFalse;
                }
                nudNumber.Maximum--;
            }
            else
                MessageBox.Show("В коллекции должен быть хотя бы 1 элемент.", "Ошибка");
        }
        private void miSave_Click(object sender, EventArgs e)
        {
            if (database != null)
                database.SaveXml();
            else
                MessageBox.Show("База данных не создана.", "Ошибка");
        }
        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Файлы XML (*.xml)|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.LoadXml();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }
        }
        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                database[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
                database[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;
            }
            else
                MessageBox.Show("База данных не создана.", "Ошибка");
        }
        private void miSaveAs_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Файлы XML (*.xml)|*.xml";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    database.FileName = sfd.FileName;
                    database.SaveXml();
                }
            }
            else
                MessageBox.Show("База данных не создана.", "Ошибка");
        }
        private void miVersion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия программы: 1.2.0.0.", "Информация");
        }
        private void miAuthors_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Основа программы взята из материалов GeekBrains.\n\n---\n\nДоработала: Бутырская Е.Д.", "Информация");
        }
        private void miHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Перед началом работы создайте новую базу данных с вопросами или " +
                "откройте существующую. Нажмите кнопку \"Добавить\", в тектовом поле введите " +
                "высказывание, отметьте, правдиво оно или нет, и нажмите кнопку \"Сохранить\". " +
                "Чтобы удалить вопрос, введите его порядковый номер и нажмите кнопку \"Удалить\". " +
                "По окончании редактирования не забудьте сохранить файл.", "Информация");
        }
    }
}
