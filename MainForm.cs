using BankAccount;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*******************************************
Program: MainForm.cs
Purpose: Main form of the Bank Account application, 
providing access to various functionalities.
Author: Kenyang Lual
Date: Feb 27, 2024
********************************************/
namespace BankAccountGUI
{
    public partial class MainForm : Form
    {
        // Variables to hold account information
        private string accountHolder;
        private decimal balance = 0;

        // Handlers for deposit, withdraw, balance, and transaction history forms
        private DepositForm depositHandler;
        private Withdraw withdrawHandler;
        private BalanceForm balanceHandler;
        public TransactionHistoryForm historyForm;

        // List to store transaction history
        public List<Transaction> transactions = new List<Transaction>();

        // Constructor
        public MainForm()
        {
            InitializeComponent();

            accountHolder = "Jimmy Neutron";

            // Create instance of BalanceForm for displaying balance
            balanceHandler = new BalanceForm(balance);
        }

        // Event handler for logout button click
        private void logout_button_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }

        // Event handler for balance button click
        private void balance_button_Click(object sender, EventArgs e)
        {
            // Show BalanceForm to display current balance
            BalanceForm bal = new BalanceForm(balance);
            bal.ShowDialog();
        }

        // Event handler for MainForm load event
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Create instance of TransactionHistoryForm
            historyForm = new TransactionHistoryForm();
        }

        // Event handler for deposit button click
        private void deposit_button_Click(object sender, EventArgs e)
        {
            // Show DepositForm for depositing money
            DepositForm depositForm = new DepositForm(historyForm, accountHolder);
            depositForm.Show();
        }

        // Event handler for withdraw button click
        private void withdraw_button_Click(object sender, EventArgs e)
        {
            // Show WithdrawForm for withdrawing money
            Withdraw withdrawForm = new Withdraw(historyForm, accountHolder);
            withdrawForm.Show();
        }

        // Event handler for fast cash button click
        private void fastcash_button_Click(object sender, EventArgs e)
        {
            // Show FastCash form for quick withdrawals
            FastCash fashCashForm = new FastCash(historyForm, accountHolder);
            fashCashForm.Show();
        }

        // Event handler for transaction history button click
        private void transactionhistory_button_Click(object sender, EventArgs e)
        {
            // Show TransactionHistoryForm to display transaction history
            historyForm.ShowDialog();
        }
    }
}
