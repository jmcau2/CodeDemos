namespace PeoriaTechnologyIntakeSheet
{
    partial class TimeClock
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
            this.employeeIDBox = new System.Windows.Forms.TextBox();
            this.clockInButton = new System.Windows.Forms.Button();
            this.ClockOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID:";
            // 
            // employeeIDBox
            // 
            this.employeeIDBox.Location = new System.Drawing.Point(157, 27);
            this.employeeIDBox.MaxLength = 6;
            this.employeeIDBox.Name = "employeeIDBox";
            this.employeeIDBox.Size = new System.Drawing.Size(179, 20);
            this.employeeIDBox.TabIndex = 1;
            this.employeeIDBox.TextChanged += new System.EventHandler(this.employeeIDBox_TextChanged);
            // 
            // clockInButton
            // 
            this.clockInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockInButton.Location = new System.Drawing.Point(12, 216);
            this.clockInButton.Name = "clockInButton";
            this.clockInButton.Size = new System.Drawing.Size(127, 38);
            this.clockInButton.TabIndex = 2;
            this.clockInButton.Text = "Clock In";
            this.clockInButton.UseVisualStyleBackColor = true;
            this.clockInButton.Click += new System.EventHandler(this.clockInButton_Click);
            // 
            // ClockOutButton
            // 
            this.ClockOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockOutButton.Location = new System.Drawing.Point(315, 216);
            this.ClockOutButton.Name = "ClockOutButton";
            this.ClockOutButton.Size = new System.Drawing.Size(146, 38);
            this.ClockOutButton.TabIndex = 3;
            this.ClockOutButton.Text = "Clock Out";
            this.ClockOutButton.UseVisualStyleBackColor = true;
            this.ClockOutButton.Click += new System.EventHandler(this.ClockOutButton_Click);
            // 
            // TimeClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 262);
            this.Controls.Add(this.ClockOutButton);
            this.Controls.Add(this.clockInButton);
            this.Controls.Add(this.employeeIDBox);
            this.Controls.Add(this.label1);
            this.Name = "TimeClock";
            this.Text = "TimeClock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox employeeIDBox;
        private System.Windows.Forms.Button clockInButton;
        private System.Windows.Forms.Button ClockOutButton;
    }
}