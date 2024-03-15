
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*******************************************
Program: Withdraw.cs
Purpose: Defines the Withdraw class to handle withdrawals 
and update transaction history.
Author: Kenyang Lual
Date: Feb 27, 2024
********************************************/

namespace BankAccountGUI
{
    public partial class Withdraw : Form
    {
        private TransactionHistoryForm historyForm; // Reference to the transaction history form
        private string accountHolderName; // Hold the name of the account holder

        // Constructor for Withdraw form
        public Withdraw(TransactionHistoryForm T_historyForm, string accountHolder)
        {
            InitializeComponent();
            historyForm = T_historyForm; // Assign the transaction history form
            accountHolderName = accountHolder; // Set the account holder's name
        }

        // Handle the back button click event
        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the Withdraw form
        }

        // Handle the withdraw button click event
        private void withdraw_button_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(withdrawTextBox.Text, out decimal amount))
            {
                if (amount <= 0)
                {
                    MessageBox.Show("Enter a positive amount to withdraw."); // Error message for negative or zero amount
                }
                else if (amount > SharedData.Balance)
                {
                    MessageBox.Show("Insufficient Funds"); // Error message for insufficient balance
                }
                else
                {
                    if (SharedData.Balance == 0)
                    {
                        MessageBox.Show("Error: Balance is not initialized"); // Error message for uninitialized balance
                    }
                    else
                    {
                        SharedData.Balance -= amount; // Update the balance
                        MessageBox.Show($"Withdrawal: - ${amount}\nNew Balance: ${SharedData.Balance}"); // Show withdrawal information

                        // Add the transaction to the transaction history
                        historyForm.transactions.Add(new Transaction(accountHolderName, "Withdrawal", amount, DateTime.Now));
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid amount to withdraw."); // Error message for invalid input
            }
        }
    }
}

