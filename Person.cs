using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*******************************************
Program: Person.cs
Purpose: To establish a Person Class capable of 
storing the account holder's information, including their name and age.
Author: Kenyang Lual
Date: Feb 27,2024
********************************************/
namespace BankAccount
{
    internal class Person
    {
        private string firstName, lastName;
        private int age;

        // Default constructor initializes with default values
        public Person()
        {
            firstName = "Blank";
            lastName = "Blank";
            age = 0;
        }

        // Parameterized constructor with input validation
        public Person(string firstName, string lastName, int age)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                Console.WriteLine("Error: First name cannot be empty.");
            }
            else
            {
                this.firstName = firstName;
            }

            if (string.IsNullOrEmpty(lastName))
            {
                Console.WriteLine("Error: Last name cannot be empty.");
            }
            else
            {
                this.lastName = lastName;
            }

            if (age < 0)
            {
                Console.WriteLine("Error: Age cannot be negative.");
            }
            else
            {
                this.age = age;
            }
        }

        // Public properties for read-only access
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public int Age { get { return age; } }

        // Method to set the person's information
        public void SetPerson(string pFirstName, string pLastName, int pAge)
        {
            firstName = pFirstName;
            lastName = pLastName;
            age = pAge;
        }

        // Method to print the person's information
        public void Print()
        {
            Console.WriteLine("First name: " + FirstName);
            Console.WriteLine("Last name: " + LastName);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine(" ");
        }

        // Method to get the first name
        internal object GetFirst()
        {
            throw new NotImplementedException();
        }

        // Method to get the last name
        internal object GetLast()
        {
            throw new NotImplementedException();
        }
    }
}

