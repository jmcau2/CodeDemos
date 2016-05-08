namespace PeoriaTechnologyIntakeSheet
{
    partial class DBConfiguration
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dbURLTextBox = new System.Windows.Forms.TextBox();
            this.dbToUseTextBox = new System.Windows.Forms.TextBox();
            this.dbPassword = new System.Windows.Forms.TextBox();
            this.dbUser = new System.Windows.Forms.TextBox();
            this.phpFolderTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.testConfigButton = new System.Windows.Forms.Button();
            this.updateConfig = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Database Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Database URL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Database to use:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Database User:";
            // 
            // dbURLTextBox
            // 
            this.dbURLTextBox.Location = new System.Drawing.Point(138, 94);
            this.dbURLTextBox.Name = "dbURLTextBox";
            this.dbURLTextBox.Size = new System.Drawing.Size(334, 20);
            this.dbURLTextBox.TabIndex = 8;
            this.dbURLTextBox.TextChanged += new System.EventHandler(this.dbURLTextBox_TextChanged);
            // 
            // dbToUseTextBox
            // 
            this.dbToUseTextBox.Location = new System.Drawing.Point(138, 120);
            this.dbToUseTextBox.Name = "dbToUseTextBox";
            this.dbToUseTextBox.Size = new System.Drawing.Size(334, 20);
            this.dbToUseTextBox.TabIndex = 9;
            this.dbToUseTextBox.TextChanged += new System.EventHandler(this.dbToUseTextBox_TextChanged);
            // 
            // dbPassword
            // 
            this.dbPassword.Location = new System.Drawing.Point(174, 151);
            this.dbPassword.Name = "dbPassword";
            this.dbPassword.Size = new System.Drawing.Size(298, 20);
            this.dbPassword.TabIndex = 10;
            this.dbPassword.TextChanged += new System.EventHandler(this.dbPassword_TextChanged);
            // 
            // dbUser
            // 
            this.dbUser.Location = new System.Drawing.Point(139, 180);
            this.dbUser.Name = "dbUser";
            this.dbUser.Size = new System.Drawing.Size(334, 20);
            this.dbUser.TabIndex = 11;
            this.dbUser.TextChanged += new System.EventHandler(this.dbUser_TextChanged);
            // 
            // phpFolderTextBox
            // 
            this.phpFolderTextBox.Location = new System.Drawing.Point(138, 206);
            this.phpFolderTextBox.Name = "phpFolderTextBox";
            this.phpFolderTextBox.Size = new System.Drawing.Size(334, 20);
            this.phpFolderTextBox.TabIndex = 12;
            this.phpFolderTextBox.TextChanged += new System.EventHandler(this.phpFolderTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "PHP Folder:";
            // 
            // testConfigButton
            // 
            this.testConfigButton.Location = new System.Drawing.Point(348, 544);
            this.testConfigButton.Name = "testConfigButton";
            this.testConfigButton.Size = new System.Drawing.Size(124, 31);
            this.testConfigButton.TabIndex = 14;
            this.testConfigButton.Text = "Test Configuration";
            this.testConfigButton.UseVisualStyleBackColor = true;
            this.testConfigButton.Click += new System.EventHandler(this.testConfigButton_Click);
            // 
            // updateConfig
            // 
            this.updateConfig.Location = new System.Drawing.Point(12, 544);
            this.updateConfig.Name = "updateConfig";
            this.updateConfig.Size = new System.Drawing.Size(163, 31);
            this.updateConfig.TabIndex = 15;
            this.updateConfig.Text = "Update Configuration";
            this.updateConfig.UseVisualStyleBackColor = true;
            this.updateConfig.Click += new System.EventHandler(this.updateConfig_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(380, 39);
            this.label6.TabIndex = 16;
            this.label6.Text = "Database Configuration";
            // 
            // DBConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 587);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.updateConfig);
            this.Controls.Add(this.testConfigButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phpFolderTextBox);
            this.Controls.Add(this.dbUser);
            this.Controls.Add(this.dbPassword);
            this.Controls.Add(this.dbToUseTextBox);
            this.Controls.Add(this.dbURLTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DBConfiguration";
            this.Text = "DBConfiguration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dbURLTextBox;
        private System.Windows.Forms.TextBox dbToUseTextBox;
        private System.Windows.Forms.TextBox dbPassword;
        private System.Windows.Forms.TextBox dbUser;
        private System.Windows.Forms.TextBox phpFolderTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button testConfigButton;
        private System.Windows.Forms.Button updateConfig;
        private System.Windows.Forms.Label label6;
    }
}