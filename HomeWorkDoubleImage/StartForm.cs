using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkDoubleImage
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void ratingBtn_Click(object sender, EventArgs e) => new RatingForm().ShowDialog();

        private void playBtn_Click(object sender, EventArgs e)
        {
            if (nicknameTextBox.Text.Equals("Ваш никнейм") || nicknameTextBox.Text.Equals(""))
            {
                MessageBox.Show("Введите свой никнейм!","Ошибка");
                return;
            }
            GameForm gameForm = new GameForm(nicknameTextBox.Text);
            gameForm.FormClosed += HideFix;
            Hide();
            gameForm.Show();
        }

        private void HideFix(object sender, EventArgs e) => Show();

        private void nicknameTextBox_Enter(object sender, EventArgs e)
        {
            if (nicknameTextBox.Text.Equals("Ваш никнейм"))
            {
                nicknameTextBox.Text = "";
            }
        }

        private void nicknameTextBox_Leave(object sender, EventArgs e)
        {
            if (nicknameTextBox.Text.Equals(""))
            {
                nicknameTextBox.Text = "Ваш никнейм";
            }
        }
    }
}
