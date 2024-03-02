using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UseBank
{
    public partial class FAuth : Form
    {
        Bank bank;
        FBank fbank;
        public FAuth()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.ToLower();
            string password = textBoxPassword.Text.ToLower();

            if (textBoxLogin.Text.Contains(" "))
            {
                MessageBox.Show("Вы не можете указать логин, где есть пробелы");
                return;
            }
            else if (textBoxPassword.Text.Contains(" "))
            {
                MessageBox.Show("Вы не можете указать пароль, где есть пробелы");
                return;
            }

            if (login != "" && password != "")
            {
                if (Bank.getValidiLogin(login))
                {
                    bank = new Bank(login, password);
                    bank.registration();
                    fbank = new FBank(bank);
                    fbank.Show();
                }
                else
                    MessageBox.Show("Такой логин уже занят!");
            }
            else
                MessageBox.Show("Не все поля заполнены!");
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.ToLower();
            string password = textBoxPassword.Text.ToLower();

            if (textBoxLogin.Text.Contains(" "))
            {
                MessageBox.Show("Вы не можете указать логин, где есть пробелы");
                return;
            }
            else if (textBoxPassword.Text.Contains(" "))
            {
                MessageBox.Show("Вы не можете указать пароль, где есть пробелы");
                return;
            }

            if (login != "" && password != "")
            {
                bank = new Bank(login, password);
                if (!bank.authorization())
                {
                    MessageBox.Show("Неправильный логин или пароль!");
                    bank = null;
                }
                else
                {
                    fbank = new FBank(bank);
                    fbank.Show();
                }
            }
            else
                MessageBox.Show("Не все поля заполнены!");
        }
    }
}