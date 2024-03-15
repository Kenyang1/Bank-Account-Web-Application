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
Program: BalanceForm.cs
Purpose: Defines the BalanceForm class to display the 
account balance and account holder's information.
Author: Kenyang Lual
Date: Feb 27, 2024
********************************************/

namespace BankAccountGUI
{
    public partial class BalanceForm : Form
    {
        private decimal _balance; // Variable to store the balance
        private Person accountHolder; // Instance of the account holder

        // Constructor for BalanceForm
        public BalanceForm(decimal balance)
        {
            InitializeComponent();
            this._balance = balance; // Set the initial balance

            accountHolder = new Person("Jimmy", "Neutron", 11); // Initialize the account holder

            UpdateBalanceLabel(); // Update the balance label
            UpdateAccountHolderLabel(); // Update the account holder label
        }

        // Update the balance label with the current balance
        private void UpdateBalanceLabel()
        {
            balanceLabel.Text = $"Balance: ${SharedData.Balance}";
        }

        // Update the account holder label with the account holder's name
        private void UpdateAccountHolderLabel()
        {
            accountHolderLabel.Text = $"Account Holder: {accountHolder.FirstName} {accountHolder.LastName}";
        }

        // Event handler for the form load event
        private void BalanceForm_Load(object sender, EventArgs e)
        {
            // Additional logic for form load, if needed
        }

        // Event handler for the back button click event
        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the BalanceForm
        }

        // Event handler for the account number label click event
        private void accNum_Click(object sender, EventArgs e)
        {
            // Additional logic for account number label click, if needed
        }

        // Event handler for the balance label click event
        private void balanceLabel_Click(object sender, EventArgs e)
        {
            // Additional logic for balance label click, if needed
        }

        // Event handler for the back button click event (overload)
        private void back_button_Click_1(object sender, EventArgs e)
        {
            this.Close(); // Close the BalanceForm
        }
    }
}
