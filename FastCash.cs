using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*******************************************
Program: FashCash.cs
Purpose: Defines the FashCash class to handle fast cash 
withdrawals and update transaction history.
Author: Kenyang Lual
Date: Feb 27, 2024
********************************************/

namespace BankAccountGUI

{
    public partial class FastCash : Form
    {
        private TransactionHistoryForm historyForm; // Reference to the transaction history form
        private string accountHolder; // Hold the name of the account holder

        // Constructor for FastCash form
        public FastCash(TransactionHistoryForm T_history, string accountHolderName)
        {
            InitializeComponent();
            UpdateBalanceLabel(); // Update the balance label
            historyForm = T_history; // Assign the transaction history form
            accountHolder = accountHolderName; // Set the account holder's name
        }

        // Handle the 10 dollar fast cash button click event
        private void fastCash10Button_Click(object sender, EventArgs e)
        {
            WithdrawFastCash(10); // Withdraw $10
        }

        // Handle the 50 dollar fast cash button click event
        private void fastCash50Button_Click(object sender, EventArgs e)
        {
            WithdrawFastCash(50); // Withdraw $50
        }

        // Handle the 100 dollar fast cash button click event
        private void fastCash100Button_Click(object sender, EventArgs e)
        {
            WithdrawFastCash(100); // Withdraw $100
        }

        // Handle the 500 dollar fast cash button click event
        private void fastCash500Button_Click(object sender, EventArgs e)
        {
            WithdrawFastCash(500); // Withdraw $500
        }

        // Handle the 1000 dollar fast cash button click event
        private void fastCash1000Button_Click(object sender, EventArgs e)
        {
            WithdrawFastCash(1000); // Withdraw $1000
        }

        // Handle the custom fast cash button click event
        private void button1_Click(object sender, EventArgs e)
        {
            WithdrawFastCash(200); // Withdraw $200
        }

        // Update the balance label with the current balance
        private void UpdateBalanceLabel()
        {
            balanceLabel.Text = $"Balance: ${SharedData.Balance}";
        }

        // Handle the back button click event
        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the FastCash form
        }

        // Withdraw a specified amount of fast cash
        private void WithdrawFastCash(decimal amount)
        {
            if (amount <= 0)
            {
                MessageBox.Show("Invalid fast cash amount."); // Error message for invalid amount
            }
            else if (amount > SharedData.Balance)
            {
                MessageBox.Show("Insufficient Funds"); // Error message for insufficient funds
            }
            else
            {
                SharedData.Balance -= amount; // Update the balance
                historyForm.transactions.Add(new Transaction(accountHolder, "Fast Cash Withdrawal", amount, DateTime.Now)); // Add transaction to history
                MessageBox.Show($"Fast Cash Withdrawal: - ${amount}\nNew Balance: ${SharedData.Balance}"); // Show withdrawal message
                UpdateBalanceLabel(); // Update the balance label
            }
        }
    }
}


