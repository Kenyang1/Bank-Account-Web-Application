namespace BankAccountGUI
{
    partial class FastCash
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
            this.fastCash10Button = new System.Windows.Forms.Button();
            this.fastCash200Button = new System.Windows.Forms.Button();
            this.fastCash50Button = new System.Windows.Forms.Button();
            this.fastCash500Button = new System.Windows.Forms.Button();
            this.fastCash100Button = new System.Windows.Forms.Button();
            this.fastCash1000Button = new System.Windows.Forms.Button();
            this.available_balance = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fastCash10Button
            // 
            this.fastCash10Button.Location = new System.Drawing.Point(89, 104);
            this.fastCash10Button.Name = "fastCash10Button";
            this.fastCash10Button.Size = new System.Drawing.Size(147, 62);
            this.fastCash10Button.TabIndex = 0;
            this.fastCash10Button.Text = "$10";
            this.fastCash10Button.UseVisualStyleBackColor = true;
            this.fastCash10Button.Click += new System.EventHandler(this.fastCash10Button_Click);
            // 
            // fastCash200Button
            // 
            this.fastCash200Button.Location = new System.Drawing.Point(89, 209);
            this.fastCash200Button.Name = "fastCash200Button";
            this.fastCash200Button.Size = new System.Drawing.Size(147, 62);
            this.fastCash200Button.TabIndex = 1;
            this.fastCash200Button.Text = "$200";
            this.fastCash200Button.UseVisualStyleBackColor = true;
            this.fastCash200Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // fastCash50Button
            // 
            this.fastCash50Button.Location = new System.Drawing.Point(319, 115);
            this.fastCash50Button.Name = "fastCash50Button";
            this.fastCash50Button.Size = new System.Drawing.Size(147, 62);
            this.fastCash50Button.TabIndex = 2;
            this.fastCash50Button.Text = "$50";
            this.fastCash50Button.UseVisualStyleBackColor = true;
            this.fastCash50Button.Click += new System.EventHandler(this.fastCash50Button_Click);
            // 
            // fastCash500Button
            // 
            this.fastCash500Button.Location = new System.Drawing.Point(319, 218);
            this.fastCash500Button.Name = "fastCash500Button";
            this.fastCash500Button.Size = new System.Drawing.Size(147, 62);
            this.fastCash500Button.TabIndex = 3;
            this.fastCash500Button.Text = "$500";
            this.fastCash500Button.UseVisualStyleBackColor = true;
            this.fastCash500Button.Click += new System.EventHandler(this.fastCash500Button_Click);
            // 
            // fastCash100Button
            // 
            this.fastCash100Button.Location = new System.Drawing.Point(544, 115);
            this.fastCash100Button.Name = "fastCash100Button";
            this.fastCash100Button.Size = new System.Drawing.Size(147, 62);
            this.fastCash100Button.TabIndex = 4;
            this.fastCash100Button.Text = "$100";
            this.fastCash100Button.UseVisualStyleBackColor = true;
            this.fastCash100Button.Click += new System.EventHandler(this.fastCash100Button_Click);
            // 
            // fastCash1000Button
            // 
            this.fastCash1000Button.Location = new System.Drawing.Point(544, 218);
            this.fastCash1000Button.Name = "fastCash1000Button";
            this.fastCash1000Button.Size = new System.Drawing.Size(147, 62);
            this.fastCash1000Button.TabIndex = 5;
            this.fastCash1000Button.Text = "$1000";
            this.fastCash1000Button.UseVisualStyleBackColor = true;
            this.fastCash1000Button.Click += new System.EventHandler(this.fastCash1000Button_Click);
            // 
            // available_balance
            // 
            this.available_balance.AutoSize = true;
            this.available_balance.Location = new System.Drawing.Point(51, 32);
            this.available_balance.Name = "available_balance";
            this.available_balance.Size = new System.Drawing.Size(243, 32);
            this.available_balance.TabIndex = 18;
            this.available_balance.Text = "Available Balance";
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(319, 327);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(165, 70);
            this.back_button.TabIndex = 19;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(390, 32);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(157, 32);
            this.balanceLabel.TabIndex = 20;
            this.balanceLabel.Text = "Balancein$";
            // 
            // FastCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.available_balance);
            this.Controls.Add(this.fastCash1000Button);
            this.Controls.Add(this.fastCash100Button);
            this.Controls.Add(this.fastCash500Button);
            this.Controls.Add(this.fastCash50Button);
            this.Controls.Add(this.fastCash200Button);
            this.Controls.Add(this.fastCash10Button);
            this.Name = "FastCash";
            this.Text = "FastCash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fastCash10Button;
        private System.Windows.Forms.Button fastCash200Button;
        private System.Windows.Forms.Button fastCash50Button;
        private System.Windows.Forms.Button fastCash500Button;
        private System.Windows.Forms.Button fastCash100Button;
        private System.Windows.Forms.Button fastCash1000Button;
        private System.Windows.Forms.Label available_balance;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label balanceLabel;
    }
}