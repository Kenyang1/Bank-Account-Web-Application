using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*******************************************
Program: SharedData.cs
Purpose: Defines a static class to store shared data across the application.
Author: Kenyang Lual
Date: Feb 27, 2024
********************************************/

namespace BankAccountGUI
{
    // SharedData class to hold shared properties across forms
    internal class SharedData
    {
        // Static property to hold the current balance
        public static decimal Balance { get; set; } = 0;
    }
}

