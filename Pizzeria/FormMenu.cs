using System;
using System.IO;
using System.Windows.Forms;

namespace TextAnalyzer2
{
    public partial class FormMenu : Form
    {
        string[] payment =
            {
                "Картой курьеру",
                "На сайте онлайн",
                "Наличные"
            };
        public FormMenu()
        {
            InitializeComponent();

            for (int i = 0; i < 3; i++)
            {
                cbPaymentMethods.Items.Add(payment[i]);
            }
        }
        private void lblHawaiianStructure_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Состав:Ветчина, ананасы, моцарелла, томатный соус", "Cостав",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
        private void lblCaesarStructure_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Состав:Свежие листья салата айсберг, цыплёнок, томаты черри, сыры чеддер и пармезан, моцарелла, сливочный соус, соус цезарь", "Cостав",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
        private void lblVillageStructure_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Состав:Шампиньоны, томаты, сладкий перец, красный лук, маслины, кубики брынзы, моцарелла, томатный соус, итальянские травы", "Cостав",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
        private void lbPepperoniStructured_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Состав:Пикантная пепперони, увеличенная порция моцареллы, томатный соус", "Cостав",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
        private void lbMargaritaStructured_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Состав:Увеличенная порция моцареллы, томаты, итальянские травы, томатный соус", "Cостав",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            #region Подсчет без промокода


            if (tbPromokod.Text == "")
            {
                double s = 0;
                if (cbPriceHawaiian.Checked == true)
                {
                    if (tbAmountHawaiian.Text == "")
                    {
                        MessageBox.Show("Вы не выбрали количество для Гавайской пиццы!", "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    if (tbAmountHawaiian.Text != "")
                    {
                        s += (Convert.ToInt32(tbAmountHawaiian.Text) * 249);
                    }

                }
                if (cbPriceCaesar.Checked == true)
                {
                    if (tbAmountCaesar.Text == "")
                    {
                        MessageBox.Show("Вы не выбрали количество для пиццы Цезарь!", "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    if (tbAmountCaesar.Text != "")
                    {
                        s += (Convert.ToInt32(tbAmountCaesar.Text)) * 399;
                    }

                }
                if (cbPriceVillage.Checked == true)
                {
                    if (tbAmountVillage.Text == "")
                    {
                        MessageBox.Show("Вы не выбрали количество для пиццы Деревенская!", "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    if (tbAmountVillage.Text != "")
                    {
                        s += 199 * (Convert.ToInt32(tbAmountVillage.Text));
                    }

                }

                if (cbPricePepperoni.Checked == true)
                {
                    if (tbAmountPepperoni.Text == "")
                    {
                        MessageBox.Show("Вы не выбрали количество для пиццы Пепперони!", "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    if (tbAmountPepperoni.Text != "")
                    {
                        s += 350 * (Convert.ToInt32(tbAmountPepperoni.Text));
                    }

                }
                if (cbPriceMargarita.Checked == true)
                {
                    if (tbAmountMargarita.Text == "")
                    {
                        MessageBox.Show("Вы не выбрали количество для пиццы !", "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    if (tbAmountMargarita.Text != "")
                    {
                        s += 299 * (Convert.ToInt32(tbAmountMargarita.Text));
                    }
                }
                if (cbColaPrice.Checked == true)
                {
                    if (tbAmountCola.Text == "")
                    {
                        MessageBox.Show("Вы не выбрали количество для Кока-Колы!", "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    if (tbAmountCola.Text != "")
                    {
                        s += 99 * (Convert.ToInt32(tbAmountCola.Text));
                    }

                }
                if (cbSpritePrice.Checked == true)
                {
                    if (tbAmountSprite.Text == "")
                    {
                        MessageBox.Show("Вы не выбрали количество для Спрайта!", "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    if (tbAmountSprite.Text != "")
                    {
                        s += 99 * (Convert.ToInt32(tbAmountSprite.Text));
                    }
                }
                if (cbFantaPrice.Checked == true)
                {
                    if (tbAmountFanta.Text == "")
                    {
                        MessageBox.Show("Вы не выбрали количество для Фанты!", "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    if (tbAmountFanta.Text != "")
                    {
                        s += 99 * (Convert.ToInt32(tbAmountFanta.Text));
                    }
                }
                tbSum.Text = Convert.ToString(s) + " рублей";

                if (cbColaPrice.Checked == false & cbPriceHawaiian.Checked == false
                    & cbPriceCaesar.Checked == false & cbPriceVillage.Checked == false &
                    cbPricePepperoni.Checked == false & cbPriceMargarita.Checked == false &
                    cbSpritePrice.Checked == false & cbFantaPrice.Checked == false)

                {
                    tbSum.Text = null;
                    MessageBox.Show("Вы ничего не выбрали!", "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }



            }
            #endregion

            #region промокод на скидку 20%
            else if (tbPromokod.Text == "2020")
            {
                double s = 0;
                if (cbPriceHawaiian.Checked == true)
                {
                    if (tbAmountHawaiian.Text == "")
                    {
                        MessageBox.Show("Вы не выбрали количество для Гавайской пиццы!", "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    if (tbAmountHawaiian.Text != "")
                    {
                        s += (Convert.ToInt32(tbAmountHawaiian.Text) * 249);
                    }

                }
                if (cbPriceCaesar.Checked == true)
                {
                    if (tbAmountCaesar.Text == "")
                    {
                        MessageBox.Show("Вы не выбрали количество для пиццы Цезарь!", "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    if (tbAmountCaesar.Text != "")
                    {
                        s += (Convert.ToInt32(tbAmountCaesar.Text)) * 399;
                    }

                }
                if (cbPriceVillage.Checked == true)
                {
                    if (tbAmountVillage.Text == "")
                    {
                        MessageBox.Show("Вы не выбрали количество для пиццы Деревенская!", "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    if (tbAmountVillage.Text != "")
                    {
                        s += 199 * (Convert.ToInt32(tbAmountVillage.Text));
                    }

                }

                if (cbPricePepperoni.Checked == true)
                {
                    if (tbAmountPepperoni.Text == "")
                    {
                        MessageBox.Show("Вы не выбрали количество для пиццы Пепперони!", "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    if (tbAmountPepperoni.Text != "")
                    {
                        s += 350 * (Convert.ToInt32(tbAmountPepperoni.Text));
                    }

                }
                if (cbPriceMargarita.Checked == true)
                {
                    if (tbAmountMargarita.Text == "")
                    {
                        MessageBox.Show("Вы не выбрали количество для пиццы !", "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    if (tbAmountMargarita.Text != "")
                    {
                        s += 299 * (Convert.ToInt32(tbAmountMargarita.Text));
                    }
                }
                if (cbColaPrice.Checked == true)
                {
                    if (tbAmountCola.Text == "")
                    {
                        MessageBox.Show("Вы не выбрали количество для Кока-Колы!", "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    if (tbAmountCola.Text != "")
                    {
                        s += 99 * (Convert.ToInt32(tbAmountCola.Text));
                    }

                }
                if (cbSpritePrice.Checked == true)
                {
                    if (tbAmountSprite.Text == "")
                    {
                        MessageBox.Show("Вы не выбрали количество для Спрайта!", "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    if (tbAmountSprite.Text != "")
                    {
                        s += 99 * (Convert.ToInt32(tbAmountSprite.Text));
                    }
                }
                if (cbFantaPrice.Checked == true)
                {
                    if (tbAmountFanta.Text == "")
                    {
                        MessageBox.Show("Вы не выбрали количество для Фанты!", "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    if (tbAmountFanta.Text != "")
                    {
                        s += 99 * (Convert.ToInt32(tbAmountFanta.Text));
                    }
                }
                tbSum.Text = Convert.ToString(s - (s * 0.2)) + " рублей";

                if (cbColaPrice.Checked == false & cbPriceHawaiian.Checked == false
                    & cbPriceCaesar.Checked == false & cbPriceVillage.Checked == false &
                    cbPricePepperoni.Checked == false & cbPriceMargarita.Checked == false &
                    cbSpritePrice.Checked == false & cbFantaPrice.Checked == false)

                {
                    tbSum.Text = null;
                    MessageBox.Show("Вы ничего не выбрали!", "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            else
            {
                tbPromokod.Text = null;
                MessageBox.Show("Данного промокода не существует", "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
            #endregion
        }
        public void btnBuy_Click(object sender, EventArgs e)
        {

            if (tbSum.Text == "")
            {
                MessageBox.Show("Вы не подсчитали сумму!", "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else if (cbPaymentMethods.Text == "")
            {
                MessageBox.Show("Вы не выбрали способ оплаты!", "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialog = MessageBox.Show(
                "Желаете сохранить чек?",
                "Сохранение чека",
                  MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
                if (dialog == DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog
                    {
                        FileName = "Чек",
                        Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*",
                        Title = "Сохранение чека"
                    };
                    if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                        return;

                    string filename = saveFileDialog1.FileName;

                    File.WriteAllText(filename, "*****Чек*****" + Environment.NewLine + "ООО 'FoodHunters'" + Environment.NewLine + "950545, город Москва, ул. Деревенская 450" + Environment.NewLine + "----------------------------------" +
                        "-------------" + Environment.NewLine + "Контакты для обращения goodgame@gmail.com " + Environment.NewLine +
                        " -----------------------------------------------" +
                        Environment.NewLine + tbSum.Text + " - сумма вашей покупки." + Environment.NewLine + "Благодарим вас за покупку.Приятного Аппетита!");

                    MessageBox.Show("Оплата была успешно произведена, чек сохранен. Cпасибо за покупку!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Оплата была успешно произведена. Cпасибо за покупку!");
                    Clear();
                }  
            }
        }

        public void btnClear_Click(object sender, EventArgs e)
        {
            cbPricePepperoni.Checked = false;
            cbPriceMargarita.Checked = false;
            cbPriceHawaiian.Checked = false;
            cbPriceCaesar.Checked = false;
            cbPriceVillage.Checked = false;
            cbColaPrice.Checked = false;
            cbSpritePrice.Checked = false;
            cbFantaPrice.Checked = false;
            tbSum.Text = null;
            tbAmountHawaiian.Text = null;
            tbAmountCaesar.Text = null;
            tbAmountVillage.Text = null;
            tbAmountPepperoni.Text = null;
            tbAmountMargarita.Text = null;
            tbAmountCola.Text = null;
            tbAmountSprite.Text = null;
            tbAmountFanta.Text = null;
            tbPromokod.Text = null;
        }

        private void tbAmountHawaiian_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void tbSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void tbAmountCola_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void tbAmountSprite_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void tbAmountFanta_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
       private void tbAmountCaesar_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void tbAmountlVillage_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void tbAmountPepperoni_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void tbAmountMargarita_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void tbPromokod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void Clear()
        {
            cbPricePepperoni.Checked = false;
            cbPriceMargarita.Checked = false;
            cbPriceHawaiian.Checked = false;
            cbPriceCaesar.Checked = false;
            cbPriceVillage.Checked = false;
            cbColaPrice.Checked = false;
            cbSpritePrice.Checked = false;
            cbFantaPrice.Checked = false;
            tbSum.Text = null;
            tbAmountHawaiian.Text = null;
            tbAmountCaesar.Text = null;
            tbAmountVillage.Text = null;
            tbAmountPepperoni.Text = null;
            tbAmountMargarita.Text = null;
            tbAmountCola.Text = null;
            tbAmountSprite.Text = null;
            tbAmountFanta.Text = null;
            tbPromokod.Text = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
         "Вы действительно хотите покинуть меню?",
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






