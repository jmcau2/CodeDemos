namespace PeoriaTechnologyIntakeSheet
{
    partial class databaseConfigurationSettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.databaseIPAddressTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.databaseUserTextBox = new System.Windows.Forms.TextBox();
            this.databasePasswordLabel = new System.Windows.Forms.Label();
            this.databasePasswordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.databaseToUseTextBox = new System.Windows.Forms.TextBox();
            this.updateDatabaseConfigurationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Configuration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Database IP Address:";
            // 
            // databaseIPAddressTextBox
            // 
            this.databaseIPAddressTextBox.Location = new System.Drawing.Point(195, 67);
            this.databaseIPAddressTextBox.Name = "databaseIPAddressTextBox";
            this.databaseIPAddressTextBox.Size = new System.Drawing.Size(174, 26);
            this.databaseIPAddressTextBox.TabIndex = 2;
            this.databaseIPAddressTextBox.Text = "localhost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Database User:";
            // 
            // databaseUserTextBox
            // 
            this.databaseUserTextBox.Location = new System.Drawing.Point(195, 105);
            this.databaseUserTextBox.Name = "databaseUserTextBox";
            this.databaseUserTextBox.Size = new System.Drawing.Size(174, 26);
            this.databaseUserTextBox.TabIndex = 4;
            // 
            // databasePasswordLabel
            // 
            this.databasePasswordLabel.AutoSize = true;
            this.databasePasswordLabel.Location = new System.Drawing.Point(12, 150);
            this.databasePasswordLabel.Name = "databasePasswordLabel";
            this.databasePasswordLabel.Size = new System.Drawing.Size(156, 20);
            this.databasePasswordLabel.TabIndex = 5;
            this.databasePasswordLabel.Text = "Database Password:";
            // 
            // databasePasswordTextBox
            // 
            this.databasePasswordTextBox.Location = new System.Drawing.Point(195, 147);
            this.databasePasswordTextBox.Name = "databasePasswordTextBox";
            this.databasePasswordTextBox.Size = new System.Drawing.Size(174, 26);
            this.databasePasswordTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Database to use:";
            // 
            // databaseToUseTextBox
            // 
            this.databaseToUseTextBox.Location = new System.Drawing.Point(195, 186);
            this.databaseToUseTextBox.Name = "databaseToUseTextBox";
            this.databaseToUseTextBox.Size = new System.Drawing.Size(174, 26);
            this.databaseToUseTextBox.TabIndex = 8;
            // 
            // updateDatabaseConfigurationButton
            // 
            this.updateDatabaseConfigurationButton.Location = new System.Drawing.Point(12, 279);
            this.updateDatabaseConfigurationButton.Name = "updateDatabaseConfigurationButton";
            this.updateDatabaseConfigurationButton.Size = new System.Drawing.Size(165, 30);
            this.updateDatabaseConfigurationButton.TabIndex = 9;
            this.updateDatabaseConfigurationButton.Text = "Save Changes";
            this.updateDatabaseConfigurationButton.UseVisualStyleBackColor = true;
            // 
            // databaseConfigurationSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 321);
            this.Controls.Add(this.updateDatabaseConfigurationButton);
            this.Controls.Add(this.databaseToUseTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.databasePasswordTextBox);
            this.Controls.Add(this.databasePasswordLabel);
            this.Controls.Add(this.databaseUserTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.databaseIPAddressTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "databaseConfigurationSettingsForm";
            this.Text = "databaseConfigurationSettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox databaseIPAddressTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox databaseUserTextBox;
        private System.Windows.Forms.Label databasePasswordLabel;
        private System.Windows.Forms.TextBox databasePasswordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox databaseToUseTextBox;
        private System.Windows.Forms.Button updateDatabaseConfigurationButton;
    }
}