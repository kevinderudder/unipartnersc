using ATM.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            UpdateOverview();
            UpdateMenu();
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
                UpdateMenu();
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

        private void UpdateMenu() {
            if (bankAccount.Deposit == 0)
            {
                WithdrawFromDepositButton.Enabled = false;
            }
            else {
                WithdrawFromDepositButton.Enabled = true;
            }

            WithdrawFromSavingsButton.Enabled = bankAccount.Savings > 0;
        }

        private void AddToSavingsButton_Click(object sender, EventArgs e)
        {
            HowMuchMoneyForm form = new HowMuchMoneyForm();
            if (form.ShowDialog() == DialogResult.OK) {
                bankAccount.AddToSavings(form.Amount);
                UpdateOverview();
                UpdateMenu();
            }
        }

        private void WithdrawFromDepositButton_Click(object sender, EventArgs e)
        {
            HowMuchMoneyForm form = new HowMuchMoneyForm();
            if (form.ShowDialog() == DialogResult.OK) {
                try {
                    bankAccount.WithdrawFromDeposit(form.Amount);
                    UpdateOverview();
                    UpdateMenu();
                }
                catch (InsufficientFundsException ifex) {
                    MessageBox.Show($"U hebt niet genoeg geld op je zichtrekening om deze actie te voltooien");
                }
            }
        }

        private void WithdrawFromSavingsButton_Click(object sender, EventArgs e)
        {
            HowMuchMoneyForm form = new HowMuchMoneyForm();
            try {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    bankAccount.WithdrawFromSavings(form.Amount);
                    UpdateOverview();
                    UpdateMenu();
                }
            }
            catch (InsufficientFundsException ifex) {
                MessageBox.Show($"U hebt niet genoeg geld op je spaarrekening om deze actie te voltooien");
                LogError(ifex);
            }
           
        }

        private void LogError(InsufficientFundsException ex) {
            using (EventLog eventLog = new EventLog("Application")) {
                eventLog.Source = "Application";
                eventLog.WriteEntry($"De gebruiker probeerde {ex.RequestedAmount} van zijn rekening te halen, er is echter maar {ex.AvailableAmount} beschikbaar", EventLogEntryType.Information);
            }
        }
    }
}
