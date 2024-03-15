namespace BankAccountGUI
{
    partial class DepositForm
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
            this.amount_deposit = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // amount_deposit
            // 
            this.amount_deposit.AutoSize = true;
            this.amount_deposit.Location = new System.Drawing.Point(98, 142);
            this.amount_deposit.Name = "amount_deposit";
            this.amount_deposit.Size = new System.Drawing.Size(135, 32);
            this.amount_deposit.TabIndex = 0;
            this.amount_deposit.Text = "AMOUNT";
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(322, 317);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(165, 70);
            this.back_button.TabIndex = 10;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(477, 214);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(165, 75);
            this.depositButton.TabIndex = 11;
            this.depositButton.Text = "DEPOSIT";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // depositTextBox
            // 
            this.depositTextBox.Location = new System.Drawing.Point(477, 135);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(165, 38);
            this.depositTextBox.TabIndex = 12;
            this.depositTextBox.TextChanged += new System.EventHandler(this.depositTextBox_TextChanged);
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.depositTextBox);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.amount_deposit);
            this.Name = "DepositForm";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.DepositForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label amount_deposit;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox depositTextBox;
    }
}