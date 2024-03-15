using System;

namespace BankAccountGUI
{
    partial class MainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deposit_button = new System.Windows.Forms.Button();
            this.withdraw_button = new System.Windows.Forms.Button();
            this.balance_button = new System.Windows.Forms.Button();
            this.fastcash_button = new System.Windows.Forms.Button();
            this.transactionhistory_button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankAccountGUI.Properties.Resources.Southern_New_Hampshire_University_seal_svg;
            this.pictureBox1.Location = new System.Drawing.Point(519, 353);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bank Management System";
            // 
            // deposit_button
            // 
            this.deposit_button.Location = new System.Drawing.Point(160, 257);
            this.deposit_button.Name = "deposit_button";
            this.deposit_button.Size = new System.Drawing.Size(165, 70);
            this.deposit_button.TabIndex = 3;
            this.deposit_button.Text = "deposit";
            this.deposit_button.UseVisualStyleBackColor = true;
            this.deposit_button.Click += new System.EventHandler(this.deposit_button_Click);
            // 
            // withdraw_button
            // 
            this.withdraw_button.Location = new System.Drawing.Point(518, 257);
            this.withdraw_button.Name = "withdraw_button";
            this.withdraw_button.Size = new System.Drawing.Size(165, 70);
            this.withdraw_button.TabIndex = 4;
            this.withdraw_button.Text = "withdraw";
            this.withdraw_button.UseVisualStyleBackColor = true;
            this.withdraw_button.Click += new System.EventHandler(this.withdraw_button_Click);
            // 
            // balance_button
            // 
            this.balance_button.Location = new System.Drawing.Point(912, 257);
            this.balance_button.Name = "balance_button";
            this.balance_button.Size = new System.Drawing.Size(165, 70);
            this.balance_button.TabIndex = 5;
            this.balance_button.Text = "balance";
            this.balance_button.UseVisualStyleBackColor = true;
            this.balance_button.Click += new System.EventHandler(this.balance_button_Click);
            // 
            // fastcash_button
            // 
            this.fastcash_button.Location = new System.Drawing.Point(160, 620);
            this.fastcash_button.Name = "fastcash_button";
            this.fastcash_button.Size = new System.Drawing.Size(165, 70);
            this.fastcash_button.TabIndex = 6;
            this.fastcash_button.Text = "fast cash";
            this.fastcash_button.UseVisualStyleBackColor = true;
            this.fastcash_button.Click += new System.EventHandler(this.fastcash_button_Click);
            // 
            // transactionhistory_button
            // 
            this.transactionhistory_button.Location = new System.Drawing.Point(488, 620);
            this.transactionhistory_button.Name = "transactionhistory_button";
            this.transactionhistory_button.Size = new System.Drawing.Size(224, 70);
            this.transactionhistory_button.TabIndex = 7;
            this.transactionhistory_button.Text = "mini history";
            this.transactionhistory_button.UseVisualStyleBackColor = true;
            this.transactionhistory_button.Click += new System.EventHandler(this.transactionhistory_button_Click);
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(912, 620);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(165, 70);
            this.logout_button.TabIndex = 8;
            this.logout_button.Text = "logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1286, 900);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.transactionhistory_button);
            this.Controls.Add(this.fastcash_button);
            this.Controls.Add(this.balance_button);
            this.Controls.Add(this.withdraw_button);
            this.Controls.Add(this.deposit_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deposit_button;
        private System.Windows.Forms.Button withdraw_button;
        private System.Windows.Forms.Button balance_button;
        private System.Windows.Forms.Button fastcash_button;
        private System.Windows.Forms.Button transactionhistory_button;
        private System.Windows.Forms.Button logout_button;
    }
}

