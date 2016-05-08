namespace PeoriaTechnologyIntakeSheet
{
    partial class databaseConfigurationSettings
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
            this.databaseUserNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.databasePasswordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.databaseToUseTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Configuration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Database User Name:";
            // 
            // databaseUserNameTextBox
            // 
            this.databaseUserNameTextBox.Location = new System.Drawing.Point(185, 78);
            this.databaseUserNameTextBox.Name = "databaseUserNameTextBox";
            this.databaseUserNameTextBox.Size = new System.Drawing.Size(200, 26);
            this.databaseUserNameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Database Password:";
            // 
            // databasePasswordTextBox
            // 
            this.databasePasswordTextBox.Location = new System.Drawing.Point(185, 117);
            this.databasePasswordTextBox.Name = "databasePasswordTextBox";
            this.databasePasswordTextBox.Size = new System.Drawing.Size(200, 26);
            this.databasePasswordTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Database to use:";
            // 
            // databaseToUseTextBox
            // 
            this.databaseToUseTextBox.Location = new System.Drawing.Point(185, 157);
            this.databaseToUseTextBox.Name = "databaseToUseTextBox";
            this.databaseToUseTextBox.Size = new System.Drawing.Size(200, 26);
            this.databaseToUseTextBox.TabIndex = 6;
            // 
            // databaseConfigurationSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 506);
            this.Controls.Add(this.databaseToUseTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.databasePasswordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.databaseUserNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "databaseConfigurationSettings";
            this.Text = "databaseConfigurationSettings";
            this.Load += new System.EventHandler(this.databaseConfigurationSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox databaseUserNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox databasePasswordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox databaseToUseTextBox;
    }
}