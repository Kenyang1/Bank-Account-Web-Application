using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BankAccount
{
    class BankAccount
    {
        private Person mPerson;
        private double mBalance;

        public BankAccount() { }

        public BankAccount(string firstName, string lastName)
        {
            mPerson = new Person(firstName, lastName, 0);
        }

        public BankAccount(string firstName, string lastName, double balance)
        {
            mPerson = new Person(firstName.Trim(), lastName.Trim(), 0);
            mBalance = balance;
        }

        public BankAccount(Person p, double balance)
        {
            mPerson = p;
            mBalance = balance;
        }

        public void SetBalance(double d)
        {
            mBalance = d;
        }

        public double GetBalance()
        {
            return mBalance;
        }

        // Worker functions

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                mBalance += amount;
                Console.WriteLine($"Deposit successful. New balance: {mBalance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && mBalance >= amount)
            {
                mBalance -= amount;
                Console.WriteLine($"Withdrawal successful. Remaining balance: {mBalance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
            }
        }

        public void Inquiry()
        {
            Console.WriteLine($"Current balance: {mBalance}");
        }

        public void Print()
        {
            Console.WriteLine($"Account holder: {mPerson.GetFirst()} {mPerson.GetLast()}");
            Console.WriteLine($"Balance: {mBalance}");
        }
    }
}
