namespace PeoriaTechnologyIntakeSheet
{
    partial class intakeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(intakeForm));
            this.incomingDateLabel = new System.Windows.Forms.Label();
            this.incomingDateTextbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.equipmentDescriptionLabel = new System.Windows.Forms.Label();
            this.equipmentDescriptionTextbox = new System.Windows.Forms.TextBox();
            this.accessoriesLabel = new System.Windows.Forms.Label();
            this.accessoriesTextBox = new System.Windows.Forms.TextBox();
            this.descriptionOfProblemsLabel = new System.Windows.Forms.Label();
            this.descriptionOfProblemsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveAndPrintButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label2 = new System.Windows.Forms.Label();
            this.addUpdateCustomerButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.customerIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // incomingDateLabel
            // 
            this.incomingDateLabel.AutoSize = true;
            this.incomingDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomingDateLabel.Location = new System.Drawing.Point(29, 198);
            this.incomingDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incomingDateLabel.Name = "incomingDateLabel";
            this.incomingDateLabel.Size = new System.Drawing.Size(107, 18);
            this.incomingDateLabel.TabIndex = 0;
            this.incomingDateLabel.Text = "Incoming Date:";
            // 
            // incomingDateTextbox
            // 
            this.incomingDateTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomingDateTextbox.Location = new System.Drawing.Point(142, 192);
            this.incomingDateTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.incomingDateTextbox.Name = "incomingDateTextbox";
            this.incomingDateTextbox.Size = new System.Drawing.Size(169, 24);
            this.incomingDateTextbox.TabIndex = 1;
            this.incomingDateTextbox.TextChanged += new System.EventHandler(this.incomingDateTextbox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(782, 125);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(327, 198);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(79, 18);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(414, 192);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(322, 24);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(142, 221);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(169, 24);
            this.firstNameTextBox.TabIndex = 5;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(51, 227);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(85, 18);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(322, 227);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(84, 18);
            this.lastNameLabel.TabIndex = 7;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(414, 221);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(322, 24);
            this.lastNameTextBox.TabIndex = 8;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(24, 254);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(112, 18);
            this.phoneNumberLabel.TabIndex = 9;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(142, 248);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(169, 24);
            this.phoneNumberTextBox.TabIndex = 10;
            this.phoneNumberTextBox.TextChanged += new System.EventHandler(this.phoneNumberTextBox_TextChanged);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(70, 282);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(66, 18);
            this.addressLabel.TabIndex = 11;
            this.addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(142, 279);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(488, 24);
            this.addressTextBox.TabIndex = 12;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(99, 316);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(37, 18);
            this.cityLabel.TabIndex = 13;
            this.cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(142, 310);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(169, 24);
            this.cityTextBox.TabIndex = 14;
            this.cityTextBox.TextChanged += new System.EventHandler(this.cityTextBox_TextChanged);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(327, 316);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(46, 18);
            this.stateLabel.TabIndex = 15;
            this.stateLabel.Text = "State:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(379, 310);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(52, 24);
            this.stateTextBox.TabIndex = 16;
            this.stateTextBox.TextChanged += new System.EventHandler(this.stateTextBox_TextChanged);
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(452, 316);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(32, 18);
            this.zipLabel.TabIndex = 17;
            this.zipLabel.Text = "Zip:";
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(490, 310);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(100, 24);
            this.zipTextBox.TabIndex = 18;
            this.zipTextBox.TextChanged += new System.EventHandler(this.zipTextBox_TextChanged);
            // 
            // equipmentDescriptionLabel
            // 
            this.equipmentDescriptionLabel.AutoSize = true;
            this.equipmentDescriptionLabel.Location = new System.Drawing.Point(24, 347);
            this.equipmentDescriptionLabel.Name = "equipmentDescriptionLabel";
            this.equipmentDescriptionLabel.Size = new System.Drawing.Size(161, 18);
            this.equipmentDescriptionLabel.TabIndex = 19;
            this.equipmentDescriptionLabel.Text = "Equipment Description:";
            // 
            // equipmentDescriptionTextbox
            // 
            this.equipmentDescriptionTextbox.Location = new System.Drawing.Point(191, 344);
            this.equipmentDescriptionTextbox.Name = "equipmentDescriptionTextbox";
            this.equipmentDescriptionTextbox.Size = new System.Drawing.Size(285, 24);
            this.equipmentDescriptionTextbox.TabIndex = 20;
            this.equipmentDescriptionTextbox.TextChanged += new System.EventHandler(this.equipmentDescriptionTextbox_TextChanged);
            // 
            // accessoriesLabel
            // 
            this.accessoriesLabel.AutoSize = true;
            this.accessoriesLabel.Location = new System.Drawing.Point(34, 376);
            this.accessoriesLabel.Name = "accessoriesLabel";
            this.accessoriesLabel.Size = new System.Drawing.Size(102, 18);
            this.accessoriesLabel.TabIndex = 21;
            this.accessoriesLabel.Text = "Acccessories:";
            // 
            // accessoriesTextBox
            // 
            this.accessoriesTextBox.Location = new System.Drawing.Point(142, 370);
            this.accessoriesTextBox.Name = "accessoriesTextBox";
            this.accessoriesTextBox.Size = new System.Drawing.Size(306, 24);
            this.accessoriesTextBox.TabIndex = 22;
            this.accessoriesTextBox.TextChanged += new System.EventHandler(this.accessoriesTextBox_TextChanged);
            // 
            // descriptionOfProblemsLabel
            // 
            this.descriptionOfProblemsLabel.AutoSize = true;
            this.descriptionOfProblemsLabel.Location = new System.Drawing.Point(34, 413);
            this.descriptionOfProblemsLabel.Name = "descriptionOfProblemsLabel";
            this.descriptionOfProblemsLabel.Size = new System.Drawing.Size(172, 18);
            this.descriptionOfProblemsLabel.TabIndex = 23;
            this.descriptionOfProblemsLabel.Text = "Description of Problems:";
            // 
            // descriptionOfProblemsTextBox
            // 
            this.descriptionOfProblemsTextBox.Location = new System.Drawing.Point(26, 445);
            this.descriptionOfProblemsTextBox.Multiline = true;
            this.descriptionOfProblemsTextBox.Name = "descriptionOfProblemsTextBox";
            this.descriptionOfProblemsTextBox.Size = new System.Drawing.Size(710, 168);
            this.descriptionOfProblemsTextBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "Work Order";
            // 
            // saveAndPrintButton
            // 
            this.saveAndPrintButton.Location = new System.Drawing.Point(13, 829);
            this.saveAndPrintButton.Name = "saveAndPrintButton";
            this.saveAndPrintButton.Size = new System.Drawing.Size(127, 38);
            this.saveAndPrintButton.TabIndex = 26;
            this.saveAndPrintButton.Text = "Save And Print";
            this.saveAndPrintButton.UseVisualStyleBackColor = true;
            this.saveAndPrintButton.Click += new System.EventHandler(this.saveAndPrintButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(352, 254);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(54, 18);
            this.emailLabel.TabIndex = 27;
            this.emailLabel.Text = "E-Mail:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(414, 248);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(285, 24);
            this.emailTextBox.TabIndex = 28;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 626);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(776, 180);
            this.label2.TabIndex = 29;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // addUpdateCustomerButton
            // 
            this.addUpdateCustomerButton.Location = new System.Drawing.Point(146, 829);
            this.addUpdateCustomerButton.Name = "addUpdateCustomerButton";
            this.addUpdateCustomerButton.Size = new System.Drawing.Size(165, 38);
            this.addUpdateCustomerButton.TabIndex = 30;
            this.addUpdateCustomerButton.Text = "Add/Update Customer";
            this.addUpdateCustomerButton.UseVisualStyleBackColor = true;
            this.addUpdateCustomerButton.Click += new System.EventHandler(this.addUpdateCustomerButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "Customer ID:";
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Location = new System.Drawing.Point(540, 151);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(0, 18);
            this.customerIDLabel.TabIndex = 32;
            // 
            // intakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(796, 870);
            this.Controls.Add(this.customerIDLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addUpdateCustomerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.saveAndPrintButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionOfProblemsTextBox);
            this.Controls.Add(this.descriptionOfProblemsLabel);
            this.Controls.Add(this.accessoriesTextBox);
            this.Controls.Add(this.accessoriesLabel);
            this.Controls.Add(this.equipmentDescriptionTextbox);
            this.Controls.Add(this.equipmentDescriptionLabel);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.incomingDateTextbox);
            this.Controls.Add(this.incomingDateLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "intakeForm";
            this.Text = "intakeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label incomingDateLabel;
        private System.Windows.Forms.TextBox incomingDateTextbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Label equipmentDescriptionLabel;
        private System.Windows.Forms.TextBox equipmentDescriptionTextbox;
        private System.Windows.Forms.Label accessoriesLabel;
        private System.Windows.Forms.TextBox accessoriesTextBox;
        private System.Windows.Forms.Label descriptionOfProblemsLabel;
        private System.Windows.Forms.TextBox descriptionOfProblemsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveAndPrintButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addUpdateCustomerButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label customerIDLabel;
    }
}