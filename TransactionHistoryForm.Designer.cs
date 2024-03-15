namespace BankAccountGUI
{
    partial class TransactionHistoryForm
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
            this.components = new System.ComponentModel.Container();
            this.back_button = new System.Windows.Forms.Button();
            this.transaction_historyLabel = new System.Windows.Forms.Label();
            this.dataGridViewTransactions = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.transactionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionHistoryFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionHistoryFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(487, 791);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(165, 70);
            this.back_button.TabIndex = 15;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // transaction_historyLabel
            // 
            this.transaction_historyLabel.AutoSize = true;
            this.transaction_historyLabel.Location = new System.Drawing.Point(394, 41);
            this.transaction_historyLabel.Name = "transaction_historyLabel";
            this.transaction_historyLabel.Size = new System.Drawing.Size(258, 32);
            this.transaction_historyLabel.TabIndex = 17;
            this.transaction_historyLabel.Text = "Transaction History";
            // 
            // dataGridViewTransactions
            // 
            this.dataGridViewTransactions.AutoGenerateColumns = false;
            this.dataGridViewTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.timestampDataGridViewTextBoxColumn});
            this.dataGridViewTransactions.DataSource = this.transactionBindingSource2;
            this.dataGridViewTransactions.Location = new System.Drawing.Point(158, 143);
            this.dataGridViewTransactions.Name = "dataGridViewTransactions";
            this.dataGridViewTransactions.RowHeadersWidth = 102;
            this.dataGridViewTransactions.RowTemplate.Height = 40;
            this.dataGridViewTransactions.Size = new System.Drawing.Size(890, 522);
            this.dataGridViewTransactions.TabIndex = 18;
            this.dataGridViewTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTransactions_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 143;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 131;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 166;
            // 
            // timestampDataGridViewTextBoxColumn
            // 
            this.timestampDataGridViewTextBoxColumn.DataPropertyName = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.HeaderText = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.timestampDataGridViewTextBoxColumn.Name = "timestampDataGridViewTextBoxColumn";
            this.timestampDataGridViewTextBoxColumn.Width = 208;
            // 
            // transactionBindingSource2
            // 
            this.transactionBindingSource2.DataSource = typeof(BankAccountGUI.Transaction);
            // 
            // transactionBindingSource1
            // 
            this.transactionBindingSource1.DataSource = typeof(BankAccountGUI.Transaction);
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(BankAccountGUI.Transaction);
            // 
            // transactionHistoryFormBindingSource
            // 
            this.transactionHistoryFormBindingSource.DataSource = typeof(BankAccountGUI.TransactionHistoryForm);
            // 
            // TransactionHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 904);
            this.Controls.Add(this.dataGridViewTransactions);
            this.Controls.Add(this.transaction_historyLabel);
            this.Controls.Add(this.back_button);
            this.Name = "TransactionHistoryForm";
            this.Text = "TransactionHistoryForm";
            this.Load += new System.EventHandler(this.TransactionHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionHistoryFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label transaction_historyLabel;
        private System.Windows.Forms.DataGridView dataGridViewTransactions;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.BindingSource transactionHistoryFormBindingSource;
        private System.Windows.Forms.BindingSource transactionBindingSource1;
        private System.Windows.Forms.BindingSource transactionBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn;
    }
}