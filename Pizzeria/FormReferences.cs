using System;
using System.Windows.Forms;

namespace TextAnalyzer2
{
    public partial class FormReference : Form
    {
        public FormReference()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
         "Вы действительно хотите выйти ?",
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
