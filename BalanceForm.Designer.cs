namespace BankAccountGUI
{
    partial class BalanceForm
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
            this.account_label = new System.Windows.Forms.Label();
            this.yourbalance = new System.Windows.Forms.Label();
            this.accountHolderLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // account_label
            // 
            this.account_label.AutoSize = true;
            this.account_label.Location = new System.Drawing.Point(49, 85);
            this.account_label.Name = "account_label";
            this.account_label.Size = new System.Drawing.Size(199, 32);
            this.account_label.TabIndex = 0;
            this.account_label.Text = "Account Name";
            // 
            // yourbalance
            // 
            this.yourbalance.AutoSize = true;
            this.yourbalance.Location = new System.Drawing.Point(49, 210);
            this.yourbalance.Name = "yourbalance";
            this.yourbalance.Size = new System.Drawing.Size(182, 32);
            this.yourbalance.TabIndex = 1;
            this.yourbalance.Text = "Your balance";
            // 
            // accountHolderLabel
            // 
            this.accountHolderLabel.AutoSize = true;
            this.accountHolderLabel.Location = new System.Drawing.Point(380, 85);
            this.accountHolderLabel.Name = "accountHolderLabel";
            this.accountHolderLabel.Size = new System.Drawing.Size(120, 32);
            this.accountHolderLabel.TabIndex = 2;
            this.accountHolderLabel.Text = "AccNum";
            this.accountHolderLabel.Click += new System.EventHandler(this.accNum_Click);
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(380, 210);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(157, 32);
            this.balanceLabel.TabIndex = 3;
            this.balanceLabel.Text = "Balancein$";
            this.balanceLabel.Click += new System.EventHandler(this.balanceLabel_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(267, 305);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(165, 70);
            this.back_button.TabIndex = 20;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click_1);
            // 
            // BalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.accountHolderLabel);
            this.Controls.Add(this.yourbalance);
            this.Controls.Add(this.account_label);
            this.Name = "BalanceForm";
            this.Text = "BalanceForm";
            this.Load += new System.EventHandler(this.BalanceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label account_label;
        private System.Windows.Forms.Label yourbalance;
        private System.Windows.Forms.Label accountHolderLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Button back_button;
    }
}