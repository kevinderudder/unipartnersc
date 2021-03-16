namespace calculatorApp
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
            this.Value1Textbox = new System.Windows.Forms.TextBox();
            this.Value2Textbox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SolutionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Value1Textbox
            // 
            this.Value1Textbox.Location = new System.Drawing.Point(12, 12);
            this.Value1Textbox.Name = "Value1Textbox";
            this.Value1Textbox.Size = new System.Drawing.Size(776, 26);
            this.Value1Textbox.TabIndex = 0;
            // 
            // Value2Textbox
            // 
            this.Value2Textbox.Location = new System.Drawing.Point(12, 44);
            this.Value2Textbox.Name = "Value2Textbox";
            this.Value2Textbox.Size = new System.Drawing.Size(776, 26);
            this.Value2Textbox.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(713, 85);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 43);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SolutionLabel
            // 
            this.SolutionLabel.AutoSize = true;
            this.SolutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolutionLabel.Location = new System.Drawing.Point(159, 85);
            this.SolutionLabel.Name = "SolutionLabel";
            this.SolutionLabel.Size = new System.Drawing.Size(0, 340);
            this.SolutionLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SolutionLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Value2Textbox);
            this.Controls.Add(this.Value1Textbox);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Value1Textbox;
        private System.Windows.Forms.TextBox Value2Textbox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label SolutionLabel;
    }
}

