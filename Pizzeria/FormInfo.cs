using System;
using System.Windows.Forms;

namespace TextAnalyzer2
{
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
         "Вы действительно хотите выйти",
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
