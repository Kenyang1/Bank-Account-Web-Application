using System;

namespace BankAccountGUI
{
    partial class Withdraw
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.withdrawTextBox = new System.Windows.Forms.TextBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.amount_deposit = new System.Windows.Forms.Label();
            this.available_balance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // withdrawTextBox
            // 
            this.withdrawTextBox.Location = new System.Drawing.Point(507, 99);
            this.withdrawTextBox.Name = "withdrawTextBox";
            this.withdrawTextBox.Size = new System.Drawing.Size(165, 38);
            this.withdrawTextBox.TabIndex = 16;
            this.withdrawTextBox.TextChanged += new System.EventHandler(this.withdraw_Textbox_TextChanged);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(507, 178);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(202, 75);
            this.withdrawButton.TabIndex = 15;
            this.withdrawButton.Text = "WITHDRAW";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdraw_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(352, 281);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(165, 70);
            this.back_button.TabIndex = 14;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // amount_deposit
            // 
            this.amount_deposit.AutoSize = true;
            this.amount_deposit.Location = new System.Drawing.Point(311, 105);
            this.amount_deposit.Name = "amount_deposit";
            this.amount_deposit.Size = new System.Drawing.Size(135, 32);
            this.amount_deposit.TabIndex = 13;
            this.amount_deposit.Text = "AMOUNT";
            // 
            // available_balance
            // 
            this.available_balance.AutoSize = true;
            this.available_balance.Location = new System.Drawing.Point(50, 178);
            this.available_balance.Name = "available_balance";
            this.available_balance.Size = new System.Drawing.Size(243, 32);
            this.available_balance.TabIndex = 17;
            this.available_balance.Text = "Available Balance";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.available_balance);
            this.Controls.Add(this.withdrawTextBox);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.amount_deposit);
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void withdraw_Textbox_TextChanged(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox withdrawTextBox;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label amount_deposit;
        private System.Windows.Forms.Label available_balance;
    }
}