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
Program: DepositForm.cs
Purpose: Defines the DepositForm class to handle deposit operations 
for the bank account, including updating the balance and adding a deposit transaction.
Author: Kenyang Lual
Date: Feb 27, 2024
********************************************/

namespace BankAccountGUI
{
    public partial class DepositForm : Form
    {
        private string accountHolder; // Hold the name of the account holder
        private TransactionHistoryForm historyForm; // Reference to the transaction history form

        // Constructor for DepositForm
        public DepositForm(TransactionHistoryForm T_historyForm, string accountHolderName)
        {
            historyForm = T_historyForm; // Assign the transaction history form
            InitializeComponent();
            accountHolder = accountHolderName; // Set the account holder's name
        }

        // Handle the back button click event
        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the DepositForm
        }

        // Handle the deposit button click event
        private void depositButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(depositTextBox.Text, out decimal amount))
            {
                if (amount <= 0)
                {
                    MessageBox.Show("Enter a positive amount to deposit."); // Error message for negative or zero amount
                }
                else
                {
                    SharedData.Balance += amount; // Update the balance
                    MessageBox.Show($"Deposited: ${amount}\nNew Balance: ${SharedData.Balance}"); // Show deposit information

                    // Add the transaction to the transaction history
                    historyForm.transactions.Add(new Transaction(accountHolder, "Deposit", amount, DateTime.Now));
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid amount to deposit."); // Error message for invalid input
            }
        }

        private void depositTextBox_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event if needed
        }

        private void DepositForm_Load(object sender, EventArgs e)
        {
            // Perform actions when the DepositForm is loaded
        }
    }
}