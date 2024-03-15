using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
/*******************************************
Program: Transaction.cs
Purpose: Defines the Transaction class to represent a single transaction, 
including its type, amount, timestamp, and related account holder's name.
Author: Kenyang Lual
Date: Feb 27,2024
********************************************/

namespace BankAccountGUI
{
    public class Transaction
    {
        public string Name { get; set; } // Name of the transaction
        public string Type { get; set; } // Type of the transaction (e.g., Deposit, Withdrawal)
        public decimal Amount { get; set; } // Amount involved in the transaction
        public DateTime Timestamp { get; set; } // Timestamp of the transaction

        // Constructor to initialize a new Transaction object
        public Transaction(string name, string type, decimal amount, DateTime timestamp)
        {
            Name = name; // Set the name
            Type = type; // Set the type
            Amount = amount; // Set the amount
            Timestamp = timestamp; // Set the timestamp
        }

        // Override the ToString method to provide a custom string representation of the transaction
        public override string ToString()
        {
            return $"{Timestamp} - {Type}: ${Amount} name: {Name}";
        }
    }
}
