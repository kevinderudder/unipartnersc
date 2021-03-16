using ATM.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.Win
{
    public partial class Form1 : Form
    {
        BankAccount bankAccount;

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadBankAccountButton_Click(object sender, EventArgs e)
        {
            ChangeStatus("Loading Bank Account");
            string bankAccountNumber = BankAccountNumberTextbox.Text;
            LoadBankAccount(bankAccountNumber);
            MenuGroupBox.Enabled = true;
            ChangeStatus("Ready");
        }

        private void LoadBankAccount(string accountNumber) {
            bankAccount = new BankAccount(accountNumber);
        }

        private void BankAccountNumberTextbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BankAccountNumberTextbox.Text))
            {
                LoadBankAccountButton.Enabled = false;
            }
            else {
                LoadBankAccountButton.Enabled = true;
            }

            //LoadBankAccountButton.Enabled = !string.IsNullOrEmpty(BankAccountNumberTextbox.Text);
        }

        private void ChangeStatus(string statusText) {
            StatusLabel.Text = statusText;
        }

        private void AddToDepositButton_Click(object sender, EventArgs e)
        {
            HowMuchMoneyForm form = new HowMuchMoneyForm();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                // ok knop is gebruikt
                bankAccount.AddToDeposit(form.Amount);
                UpdateOverview();
            }
            else if (result == DialogResult.Cancel) { 
                // cancel knop is gebruikt
            }

            //if(form.ShowDialog() == DialogResult.OK) { 
            
            //}
        }

        private void UpdateOverview() {
            DepositLabel.Text = "€" + bankAccount.Deposit.ToString();
            SavingsLabel.Text = "€" + bankAccount.Savings.ToString();
        }
    }
}
