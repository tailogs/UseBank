using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;


namespace UseBank
{
    public partial class FBank : Form
    {
        Bank bank;
        public FBank(Bank bank)
        {
            this.bank = bank;
            InitializeComponent();
        }

        private void btnReplenishMoney_Click(object sender, EventArgs e)
        {
            if (textBoxSum.Text == "")
            {
                MessageBox.Show("Вы не ввели количество монет!");
                return;
            }
            double balance = double.Parse(textBoxSum.Text);
            textBoxSum.Text = "";
            if (bank.replenishMoney(balance))
                MessageBox.Show("Счет успешно пополнен");
            else
                MessageBox.Show("Ошибка пополнения счета");
            lblBalance.Text = "Баланс: " + bank.getBalance() + " монет";
        }

        private void btnWithdrawMoney_Click(object sender, EventArgs e)
        {
            if (textBoxSum.Text == "")
            {
                MessageBox.Show("Вы не ввели количество монет!");
                return;
            }
            if (textBoxSum.Text.Contains(" "))
            {
                MessageBox.Show("Вы не можете указать счет монет с пробелами");
                return;
            }
            double balance = double.Parse(textBoxSum.Text);
            textBoxSum.Text = "";
            if (bank.withdrawMoney(balance))
                MessageBox.Show("Успешно снятие счета");
            else
                MessageBox.Show("Ошибка cнятия счета");
            lblBalance.Text = "Баланс: " + bank.getBalance() + " монет";
        }

        private void btnTransferMoney_Click(object sender, EventArgs e)
        {
            if (textBoxSum.Text == "")
            {
                MessageBox.Show("Вы не ввели количество монет!");
                return;
            }
            if (textBoxLoginTransfer.Text == "")
            {
                MessageBox.Show("Вы не ввели логин другого пользователя!");
                return;
            }
            if (textBoxLoginTransfer.Text == bank.getLogin())
            {
                MessageBox.Show("Вы не можете перевести деньги самому себе!");
                return;
            }
            if (textBoxLoginTransfer.Text.Contains(" "))
            {
                MessageBox.Show("Логин другого пользователя не может содержать пробелы");
                return;
            }

            double balance = double.Parse(textBoxSum.Text);
            textBoxSum.Text = "";
            string user = textBoxLoginTransfer.Text;
            if (bank.transferMoney(user, balance))
                MessageBox.Show("Вы успешно перевели деньги!");
            else
                MessageBox.Show("Пользователя которому вы переводите не существует");
            lblBalance.Text = "Баланс: " + bank.getBalance() + " монет";
        }

        private void btnExitAccount_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FBank_Load(object sender, EventArgs e)
        {
            lblUserLogin.Text = "Пользователь: " + bank.getLogin();
            lblBalance.Text = "Баланс: " + bank.getBalance() + " монет";
        }

        private void textBoxSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true; // Останавливает ввод символа если это не цифра
        }

        private void btnHistoryOperations_Click(object sender, EventArgs e)
        {
            HistoryOperations ho = new HistoryOperations();
            ho.Show();
        }
    }
}
