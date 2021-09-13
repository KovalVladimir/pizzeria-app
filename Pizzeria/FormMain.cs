using System;
using System.Windows.Forms;

namespace TextAnalyzer2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        //Открытие формы "Меню"
        private void btnMain_Click(object sender, EventArgs e)
        {
            FormMenu main = new FormMenu();
            main.ShowDialog();
        }
        //Открытие формы "О нас"
        private void btnInfo_Click(object sender, EventArgs e)
        {
            FormInfo info = new FormInfo();
            info.ShowDialog();
        }
        //Открытие формы "Справка"
        private void btnReference_Click(object sender, EventArgs e)
        {
            FormReference reference = new FormReference();
            reference.ShowDialog();
        }

        //Кнопка выхода из программы
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
         "Вы действительно хотите выйти из программы?",
         "Завершение программы",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Warning
        );
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }


    }
}
