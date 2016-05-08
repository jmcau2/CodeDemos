namespace PeoriaTechnologyIntakeSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.intakeSheetButton = new System.Windows.Forms.Button();
            this.customerLookupButton = new System.Windows.Forms.Button();
            this.serviceCallButton = new System.Windows.Forms.Button();
            this.upcomingServiceCallsDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_NumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Appointment_DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.techniciansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTechnicianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTechnicianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripHelpButton = new System.Windows.Forms.ToolStripButton();
            this.inStoreDataGridView = new System.Windows.Forms.DataGridView();
            this.inStoreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStoreLastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStoreIncomingDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStorePhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStoreEquipmentDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computersToDoLabel = new System.Windows.Forms.Label();
            this.dispatchButton = new System.Windows.Forms.Button();
            this.serviceCallCompleteButton = new System.Windows.Forms.Button();
            this.computerFinishedButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.timeClockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upcomingServiceCallsDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inStoreDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(230, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(751, 117);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // intakeSheetButton
            // 
            this.intakeSheetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.intakeSheetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intakeSheetButton.Location = new System.Drawing.Point(603, 462);
            this.intakeSheetButton.Name = "intakeSheetButton";
            this.intakeSheetButton.Size = new System.Drawing.Size(182, 53);
            this.intakeSheetButton.TabIndex = 1;
            this.intakeSheetButton.Text = "Create Intake Sheet";
            this.intakeSheetButton.UseVisualStyleBackColor = false;
            this.intakeSheetButton.Click += new System.EventHandler(this.intakeSheetButton_Click);
            // 
            // customerLookupButton
            // 
            this.customerLookupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customerLookupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLookupButton.Location = new System.Drawing.Point(791, 462);
            this.customerLookupButton.Name = "customerLookupButton";
            this.customerLookupButton.Size = new System.Drawing.Size(182, 53);
            this.customerLookupButton.TabIndex = 2;
            this.customerLookupButton.Text = "Customer Lookup";
            this.customerLookupButton.UseVisualStyleBackColor = false;
            this.customerLookupButton.Click += new System.EventHandler(this.customerLookupButton_Click);
            // 
            // serviceCallButton
            // 
            this.serviceCallButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.serviceCallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceCallButton.Location = new System.Drawing.Point(12, 462);
            this.serviceCallButton.Name = "serviceCallButton";
            this.serviceCallButton.Size = new System.Drawing.Size(182, 53);
            this.serviceCallButton.TabIndex = 3;
            this.serviceCallButton.Text = "Service Call";
            this.serviceCallButton.UseVisualStyleBackColor = false;
            this.serviceCallButton.Click += new System.EventHandler(this.serviceCallButton_Click);
            // 
            // upcomingServiceCallsDataGridView
            // 
            this.upcomingServiceCallsDataGridView.AllowUserToAddRows = false;
            this.upcomingServiceCallsDataGridView.AllowUserToDeleteRows = false;
            this.upcomingServiceCallsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.upcomingServiceCallsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.upcomingServiceCallsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.First_NameColumn,
            this.Last_NameColumn,
            this.Phone_NumberColumn,
            this.AddressColumn,
            this.Appointment_DateColumn,
            this.TimeColumn});
            this.upcomingServiceCallsDataGridView.Location = new System.Drawing.Point(12, 193);
            this.upcomingServiceCallsDataGridView.MultiSelect = false;
            this.upcomingServiceCallsDataGridView.Name = "upcomingServiceCallsDataGridView";
            this.upcomingServiceCallsDataGridView.ReadOnly = true;
            this.upcomingServiceCallsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.upcomingServiceCallsDataGridView.Size = new System.Drawing.Size(558, 236);
            this.upcomingServiceCallsDataGridView.TabIndex = 4;
            this.upcomingServiceCallsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.upcomingServiceCallsDataGridView_CellContentClick);
            // 
            // ID
            // 
            this.ID.FillWeight = 35.53299F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // First_NameColumn
            // 
            this.First_NameColumn.FillWeight = 110.7445F;
            this.First_NameColumn.HeaderText = "First Name";
            this.First_NameColumn.Name = "First_NameColumn";
            this.First_NameColumn.ReadOnly = true;
            // 
            // Last_NameColumn
            // 
            this.Last_NameColumn.FillWeight = 110.7445F;
            this.Last_NameColumn.HeaderText = "Last Name";
            this.Last_NameColumn.Name = "Last_NameColumn";
            this.Last_NameColumn.ReadOnly = true;
            // 
            // Phone_NumberColumn
            // 
            this.Phone_NumberColumn.FillWeight = 110.7445F;
            this.Phone_NumberColumn.HeaderText = "Phone Number";
            this.Phone_NumberColumn.Name = "Phone_NumberColumn";
            this.Phone_NumberColumn.ReadOnly = true;
            // 
            // AddressColumn
            // 
            this.AddressColumn.FillWeight = 110.7445F;
            this.AddressColumn.HeaderText = "Address";
            this.AddressColumn.Name = "AddressColumn";
            this.AddressColumn.ReadOnly = true;
            // 
            // Appointment_DateColumn
            // 
            this.Appointment_DateColumn.FillWeight = 110.7445F;
            this.Appointment_DateColumn.HeaderText = "Appointment Date";
            this.Appointment_DateColumn.Name = "Appointment_DateColumn";
            this.Appointment_DateColumn.ReadOnly = true;
            // 
            // TimeColumn
            // 
            this.TimeColumn.FillWeight = 110.7445F;
            this.TimeColumn.HeaderText = "Time";
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Upcoming Service Calls";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripHelpButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1265, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.techniciansToolStripMenuItem,
            this.timeClockToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseConfigurationToolStripMenuItem,
            this.programConfigurationToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // databaseConfigurationToolStripMenuItem
            // 
            this.databaseConfigurationToolStripMenuItem.Name = "databaseConfigurationToolStripMenuItem";
            this.databaseConfigurationToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.databaseConfigurationToolStripMenuItem.Text = "Database Configuration";
            this.databaseConfigurationToolStripMenuItem.Click += new System.EventHandler(this.databaseConfigurationToolStripMenuItem_Click);
            // 
            // programConfigurationToolStripMenuItem
            // 
            this.programConfigurationToolStripMenuItem.Name = "programConfigurationToolStripMenuItem";
            this.programConfigurationToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.programConfigurationToolStripMenuItem.Text = "Program Configuration";
            this.programConfigurationToolStripMenuItem.Click += new System.EventHandler(this.programConfigurationToolStripMenuItem_Click);
            // 
            // techniciansToolStripMenuItem
            // 
            this.techniciansToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTechnicianToolStripMenuItem,
            this.removeTechnicianToolStripMenuItem});
            this.techniciansToolStripMenuItem.Name = "techniciansToolStripMenuItem";
            this.techniciansToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.techniciansToolStripMenuItem.Text = "Technicians";
            // 
            // addTechnicianToolStripMenuItem
            // 
            this.addTechnicianToolStripMenuItem.Name = "addTechnicianToolStripMenuItem";
            this.addTechnicianToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addTechnicianToolStripMenuItem.Text = "Add Technician";
            // 
            // removeTechnicianToolStripMenuItem
            // 
            this.removeTechnicianToolStripMenuItem.Name = "removeTechnicianToolStripMenuItem";
            this.removeTechnicianToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.removeTechnicianToolStripMenuItem.Text = "Remove Technician";
            // 
            // toolStripHelpButton
            // 
            this.toolStripHelpButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripHelpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripHelpButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripHelpButton.Image")));
            this.toolStripHelpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripHelpButton.Name = "toolStripHelpButton";
            this.toolStripHelpButton.Size = new System.Drawing.Size(36, 22);
            this.toolStripHelpButton.Text = "Help";
            // 
            // inStoreDataGridView
            // 
            this.inStoreDataGridView.AllowUserToAddRows = false;
            this.inStoreDataGridView.AllowUserToDeleteRows = false;
            this.inStoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inStoreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inStoreID,
            this.inStoreLastNameColumn,
            this.inStoreIncomingDateColumn,
            this.inStorePhoneNumber,
            this.inStoreEquipmentDescription});
            this.inStoreDataGridView.Location = new System.Drawing.Point(603, 193);
            this.inStoreDataGridView.MultiSelect = false;
            this.inStoreDataGridView.Name = "inStoreDataGridView";
            this.inStoreDataGridView.ReadOnly = true;
            this.inStoreDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inStoreDataGridView.Size = new System.Drawing.Size(593, 236);
            this.inStoreDataGridView.TabIndex = 8;
            this.inStoreDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inStoreDataGridView_CellContentClick);
            // 
            // inStoreID
            // 
            this.inStoreID.HeaderText = "ID";
            this.inStoreID.Name = "inStoreID";
            this.inStoreID.ReadOnly = true;
            // 
            // inStoreLastNameColumn
            // 
            this.inStoreLastNameColumn.HeaderText = "Last Name";
            this.inStoreLastNameColumn.Name = "inStoreLastNameColumn";
            this.inStoreLastNameColumn.ReadOnly = true;
            // 
            // inStoreIncomingDateColumn
            // 
            this.inStoreIncomingDateColumn.HeaderText = "Incoming Date";
            this.inStoreIncomingDateColumn.Name = "inStoreIncomingDateColumn";
            this.inStoreIncomingDateColumn.ReadOnly = true;
            // 
            // inStorePhoneNumber
            // 
            this.inStorePhoneNumber.HeaderText = "Phone Number";
            this.inStorePhoneNumber.Name = "inStorePhoneNumber";
            this.inStorePhoneNumber.ReadOnly = true;
            // 
            // inStoreEquipmentDescription
            // 
            this.inStoreEquipmentDescription.HeaderText = "Equipment Description";
            this.inStoreEquipmentDescription.Name = "inStoreEquipmentDescription";
            this.inStoreEquipmentDescription.ReadOnly = true;
            this.inStoreEquipmentDescription.Width = 250;
            // 
            // computersToDoLabel
            // 
            this.computersToDoLabel.AutoSize = true;
            this.computersToDoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computersToDoLabel.Location = new System.Drawing.Point(599, 168);
            this.computersToDoLabel.Name = "computersToDoLabel";
            this.computersToDoLabel.Size = new System.Drawing.Size(149, 20);
            this.computersToDoLabel.TabIndex = 9;
            this.computersToDoLabel.Text = "Computers To Do";
            // 
            // dispatchButton
            // 
            this.dispatchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dispatchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispatchButton.Location = new System.Drawing.Point(200, 462);
            this.dispatchButton.Name = "dispatchButton";
            this.dispatchButton.Size = new System.Drawing.Size(158, 53);
            this.dispatchButton.TabIndex = 10;
            this.dispatchButton.Text = "Dispatch";
            this.dispatchButton.UseVisualStyleBackColor = false;
            this.dispatchButton.Click += new System.EventHandler(this.dispatchButton_Click);
            // 
            // serviceCallCompleteButton
            // 
            this.serviceCallCompleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.serviceCallCompleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceCallCompleteButton.Location = new System.Drawing.Point(364, 462);
            this.serviceCallCompleteButton.Name = "serviceCallCompleteButton";
            this.serviceCallCompleteButton.Size = new System.Drawing.Size(206, 53);
            this.serviceCallCompleteButton.TabIndex = 11;
            this.serviceCallCompleteButton.Text = "Service Call Complete";
            this.serviceCallCompleteButton.UseVisualStyleBackColor = false;
            this.serviceCallCompleteButton.Click += new System.EventHandler(this.serviceCallCompleteButton_Click);
            // 
            // computerFinishedButton
            // 
            this.computerFinishedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.computerFinishedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerFinishedButton.Location = new System.Drawing.Point(979, 462);
            this.computerFinishedButton.Name = "computerFinishedButton";
            this.computerFinishedButton.Size = new System.Drawing.Size(217, 53);
            this.computerFinishedButton.TabIndex = 12;
            this.computerFinishedButton.Text = "Computer Finished";
            this.computerFinishedButton.UseVisualStyleBackColor = false;
            this.computerFinishedButton.Click += new System.EventHandler(this.computerFinishedButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(1190, 28);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 13;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // timeClockToolStripMenuItem
            // 
            this.timeClockToolStripMenuItem.Name = "timeClockToolStripMenuItem";
            this.timeClockToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.timeClockToolStripMenuItem.Text = "Time Clock";
            this.timeClockToolStripMenuItem.Click += new System.EventHandler(this.timeClockToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1265, 527);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.computerFinishedButton);
            this.Controls.Add(this.serviceCallCompleteButton);
            this.Controls.Add(this.dispatchButton);
            this.Controls.Add(this.computersToDoLabel);
            this.Controls.Add(this.inStoreDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upcomingServiceCallsDataGridView);
            this.Controls.Add(this.serviceCallButton);
            this.Controls.Add(this.customerLookupButton);
            this.Controls.Add(this.intakeSheetButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Peoria Technology Point of Sale";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upcomingServiceCallsDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inStoreDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button intakeSheetButton;
        private System.Windows.Forms.Button customerLookupButton;
        private System.Windows.Forms.Button serviceCallButton;
        private System.Windows.Forms.DataGridView upcomingServiceCallsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem techniciansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTechnicianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTechnicianToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripHelpButton;
        private System.Windows.Forms.DataGridView inStoreDataGridView;
        private System.Windows.Forms.Label computersToDoLabel;
        private System.Windows.Forms.Button dispatchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_NumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Appointment_DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.Button serviceCallCompleteButton;
        private System.Windows.Forms.Button computerFinishedButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStoreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStoreLastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStoreIncomingDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStorePhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStoreEquipmentDescription;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ToolStripMenuItem timeClockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
    }
}

