namespace ATM.Win
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoadBankAccountButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BankAccountNumberTextbox = new System.Windows.Forms.TextBox();
            this.MenuGroupBox = new System.Windows.Forms.GroupBox();
            this.AddToDepositButton = new System.Windows.Forms.Button();
            this.AddToSavingsButton = new System.Windows.Forms.Button();
            this.WithdrawFromDepositButton = new System.Windows.Forms.Button();
            this.WithdrawFromSavingsButton = new System.Windows.Forms.Button();
            this.BankAccountOverviewPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DepositLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SavingsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.MenuGroupBox.SuspendLayout();
            this.BankAccountOverviewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "ATM";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 585);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1101, 32);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(60, 25);
            this.StatusLabel.Text = "Ready";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.LoadBankAccountButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BankAccountNumberTextbox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1077, 91);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STEP 1: Load Bankaccount";
            // 
            // LoadBankAccountButton
            // 
            this.LoadBankAccountButton.Enabled = false;
            this.LoadBankAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBankAccountButton.Location = new System.Drawing.Point(596, 46);
            this.LoadBankAccountButton.Name = "LoadBankAccountButton";
            this.LoadBankAccountButton.Size = new System.Drawing.Size(75, 33);
            this.LoadBankAccountButton.TabIndex = 2;
            this.LoadBankAccountButton.Text = "Load";
            this.LoadBankAccountButton.UseVisualStyleBackColor = true;
            this.LoadBankAccountButton.Click += new System.EventHandler(this.LoadBankAccountButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bankaccount number";
            // 
            // BankAccountNumberTextbox
            // 
            this.BankAccountNumberTextbox.Location = new System.Drawing.Point(21, 49);
            this.BankAccountNumberTextbox.Name = "BankAccountNumberTextbox";
            this.BankAccountNumberTextbox.Size = new System.Drawing.Size(569, 26);
            this.BankAccountNumberTextbox.TabIndex = 0;
            this.BankAccountNumberTextbox.TextChanged += new System.EventHandler(this.BankAccountNumberTextbox_TextChanged);
            // 
            // MenuGroupBox
            // 
            this.MenuGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuGroupBox.Controls.Add(this.AddToSavingsButton);
            this.MenuGroupBox.Controls.Add(this.WithdrawFromSavingsButton);
            this.MenuGroupBox.Controls.Add(this.WithdrawFromDepositButton);
            this.MenuGroupBox.Controls.Add(this.AddToDepositButton);
            this.MenuGroupBox.Enabled = false;
            this.MenuGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuGroupBox.Location = new System.Drawing.Point(12, 183);
            this.MenuGroupBox.Name = "MenuGroupBox";
            this.MenuGroupBox.Size = new System.Drawing.Size(1077, 247);
            this.MenuGroupBox.TabIndex = 3;
            this.MenuGroupBox.TabStop = false;
            this.MenuGroupBox.Text = "STEP 2: Menu";
            // 
            // AddToDepositButton
            // 
            this.AddToDepositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToDepositButton.Location = new System.Drawing.Point(21, 34);
            this.AddToDepositButton.Name = "AddToDepositButton";
            this.AddToDepositButton.Size = new System.Drawing.Size(506, 83);
            this.AddToDepositButton.TabIndex = 0;
            this.AddToDepositButton.Text = "+ Add to Deposit";
            this.AddToDepositButton.UseVisualStyleBackColor = true;
            this.AddToDepositButton.Click += new System.EventHandler(this.AddToDepositButton_Click);
            // 
            // AddToSavingsButton
            // 
            this.AddToSavingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToSavingsButton.Location = new System.Drawing.Point(548, 34);
            this.AddToSavingsButton.Name = "AddToSavingsButton";
            this.AddToSavingsButton.Size = new System.Drawing.Size(507, 83);
            this.AddToSavingsButton.TabIndex = 0;
            this.AddToSavingsButton.Text = "+ Add to Savings";
            this.AddToSavingsButton.UseVisualStyleBackColor = true;
            this.AddToSavingsButton.Click += new System.EventHandler(this.AddToSavingsButton_Click);
            // 
            // WithdrawFromDepositButton
            // 
            this.WithdrawFromDepositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawFromDepositButton.Location = new System.Drawing.Point(21, 140);
            this.WithdrawFromDepositButton.Name = "WithdrawFromDepositButton";
            this.WithdrawFromDepositButton.Size = new System.Drawing.Size(506, 83);
            this.WithdrawFromDepositButton.TabIndex = 0;
            this.WithdrawFromDepositButton.Text = "- Withdraw from Deposit";
            this.WithdrawFromDepositButton.UseVisualStyleBackColor = true;
            this.WithdrawFromDepositButton.Click += new System.EventHandler(this.WithdrawFromDepositButton_Click);
            // 
            // WithdrawFromSavingsButton
            // 
            this.WithdrawFromSavingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawFromSavingsButton.Location = new System.Drawing.Point(549, 140);
            this.WithdrawFromSavingsButton.Name = "WithdrawFromSavingsButton";
            this.WithdrawFromSavingsButton.Size = new System.Drawing.Size(506, 83);
            this.WithdrawFromSavingsButton.TabIndex = 0;
            this.WithdrawFromSavingsButton.Text = "- Withdraw from Savings";
            this.WithdrawFromSavingsButton.UseVisualStyleBackColor = true;
            this.WithdrawFromSavingsButton.Click += new System.EventHandler(this.WithdrawFromSavingsButton_Click);
            // 
            // BankAccountOverviewPanel
            // 
            this.BankAccountOverviewPanel.Controls.Add(this.SavingsLabel);
            this.BankAccountOverviewPanel.Controls.Add(this.label4);
            this.BankAccountOverviewPanel.Controls.Add(this.DepositLabel);
            this.BankAccountOverviewPanel.Controls.Add(this.label3);
            this.BankAccountOverviewPanel.Location = new System.Drawing.Point(12, 445);
            this.BankAccountOverviewPanel.Name = "BankAccountOverviewPanel";
            this.BankAccountOverviewPanel.Size = new System.Drawing.Size(1077, 120);
            this.BankAccountOverviewPanel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Deposit:";
            // 
            // DepositLabel
            // 
            this.DepositLabel.AutoSize = true;
            this.DepositLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositLabel.Location = new System.Drawing.Point(19, 47);
            this.DepositLabel.Name = "DepositLabel";
            this.DepositLabel.Size = new System.Drawing.Size(66, 46);
            this.DepositLabel.TabIndex = 1;
            this.DepositLabel.Text = "€0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Savings";
            // 
            // SavingsLabel
            // 
            this.SavingsLabel.AutoSize = true;
            this.SavingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingsLabel.Location = new System.Drawing.Point(557, 47);
            this.SavingsLabel.Name = "SavingsLabel";
            this.SavingsLabel.Size = new System.Drawing.Size(66, 46);
            this.SavingsLabel.TabIndex = 1;
            this.SavingsLabel.Text = "€0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 617);
            this.Controls.Add(this.BankAccountOverviewPanel);
            this.Controls.Add(this.MenuGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "ATM";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MenuGroupBox.ResumeLayout(false);
            this.BankAccountOverviewPanel.ResumeLayout(false);
            this.BankAccountOverviewPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LoadBankAccountButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BankAccountNumberTextbox;
        private System.Windows.Forms.GroupBox MenuGroupBox;
        private System.Windows.Forms.Button AddToSavingsButton;
        private System.Windows.Forms.Button WithdrawFromSavingsButton;
        private System.Windows.Forms.Button WithdrawFromDepositButton;
        private System.Windows.Forms.Button AddToDepositButton;
        private System.Windows.Forms.Panel BankAccountOverviewPanel;
        private System.Windows.Forms.Label SavingsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DepositLabel;
        private System.Windows.Forms.Label label3;
    }
}

