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
Program: TransactionHistoryForm.cs
Purpose: Form to display transaction history using a DataGridView.
Author: Kenyang Lual
Date: Feb 27, 2024
********************************************/

namespace BankAccountGUI
{
    public partial class TransactionHistoryForm : Form
    {
        public List<Transaction> transactions = new List<Transaction>(); // List to store transaction history

        // Constructor for TransactionHistoryForm
        public TransactionHistoryForm()
        {
            InitializeComponent();
            InitializeDataGridView(); // Initialize the DataGridView

            DisplayTransactionHistory(); // Display transaction history in the DataGridView
        }

        // Initialize the DataGridView
        private void InitializeDataGridView()
        {
            dataGridViewTransactions.AutoGenerateColumns = false;
            dataGridViewTransactions.DataSource = null; // Clear the DataSource
        }

        // Display transaction history in the DataGridView
        public void DisplayTransactionHistory()
        {
            dataGridViewTransactions.DataSource = transactions; // Set the DataSource to the transactions list

            // Iterate through each transaction and add it to the DataGridView
            foreach (Transaction transaction in transactions)
            {
                int rowIndex = dataGridViewTransactions.Rows.Add();
                dataGridViewTransactions.Rows[rowIndex].Cells["Account Name"].Value = transaction.Name;
                dataGridViewTransactions.Rows[rowIndex].Cells["Type"].Value = transaction.Type;
                dataGridViewTransactions.Rows[rowIndex].Cells["Amount"].Value = transaction.Amount;
                dataGridViewTransactions.Rows[rowIndex].Cells["Date"].Value = transaction.Timestamp;
            }
        }

        // Load data into the TransactionHistoryForm
        public void LoadData(List<Transaction> transactions)
        {
            this.transactions = transactions; // Set the transactions list
            DisplayTransactionHistory(); // Display transaction history in the DataGridView
        }

        // Add a new transaction to the transactions list
        private void AddTransaction(Transaction transaction)
        {
            if (transactions.Count >= 100)
            {
                transactions.RemoveAt(0); // Remove the oldest transaction if list exceeds 100 items
            }
            transactions.Add(transaction); // Add the new transaction
            DisplayTransactionHistory(); // Display updated transaction history in the DataGridView
        }

        // Handle the back button click event
        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the TransactionHistoryForm
        }

        // Event handler for DataGridView cell content click
        private void dataGridViewTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Additional logic for handling cell content click, if needed
        }

        // Event handler for DataGridView cell content click (overload)
        private void dataGridViewTransactions_CellContentClick(object sender, EventArgs e)
        {
            // Additional logic for handling cell content click, if needed
        }

        // Event handler for form load
        private void TransactionHistoryForm_Load(object sender, EventArgs e)
        {
            // Additional logic for form load, if needed
        }
    }
}

