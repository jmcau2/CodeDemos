namespace PeoriaTechnologyIntakeSheet
{
    partial class CustomerLookupForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_Number_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMail_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zip_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipment_Description_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accessories_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description_Of_Problems_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomingDate_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.First_Name_Column,
            this.Last_Name_Column,
            this.Phone_Number_Column,
            this.EMail_Column,
            this.Address_Column,
            this.City_Column,
            this.State_Column,
            this.Zip_Column,
            this.Equipment_Description_Column,
            this.Accessories_Column,
            this.Description_Of_Problems_Column,
            this.IncomingDate_Column});
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1340, 458);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // First_Name_Column
            // 
            this.First_Name_Column.DataPropertyName = "First_Name";
            this.First_Name_Column.HeaderText = "First Name";
            this.First_Name_Column.Name = "First_Name_Column";
            this.First_Name_Column.ReadOnly = true;
            // 
            // Last_Name_Column
            // 
            this.Last_Name_Column.HeaderText = "Last Name";
            this.Last_Name_Column.Name = "Last_Name_Column";
            this.Last_Name_Column.ReadOnly = true;
            // 
            // Phone_Number_Column
            // 
            this.Phone_Number_Column.HeaderText = "Phone Number";
            this.Phone_Number_Column.Name = "Phone_Number_Column";
            this.Phone_Number_Column.ReadOnly = true;
            // 
            // EMail_Column
            // 
            this.EMail_Column.HeaderText = "E-Mail";
            this.EMail_Column.Name = "EMail_Column";
            this.EMail_Column.ReadOnly = true;
            // 
            // Address_Column
            // 
            this.Address_Column.HeaderText = "Address";
            this.Address_Column.Name = "Address_Column";
            this.Address_Column.ReadOnly = true;
            // 
            // City_Column
            // 
            this.City_Column.HeaderText = "City";
            this.City_Column.Name = "City_Column";
            this.City_Column.ReadOnly = true;
            // 
            // State_Column
            // 
            this.State_Column.HeaderText = "State";
            this.State_Column.Name = "State_Column";
            this.State_Column.ReadOnly = true;
            // 
            // Zip_Column
            // 
            this.Zip_Column.HeaderText = "Zip";
            this.Zip_Column.Name = "Zip_Column";
            this.Zip_Column.ReadOnly = true;
            // 
            // Equipment_Description_Column
            // 
            this.Equipment_Description_Column.HeaderText = "Equipment Description";
            this.Equipment_Description_Column.Name = "Equipment_Description_Column";
            this.Equipment_Description_Column.ReadOnly = true;
            // 
            // Accessories_Column
            // 
            this.Accessories_Column.HeaderText = "Accessories";
            this.Accessories_Column.Name = "Accessories_Column";
            this.Accessories_Column.ReadOnly = true;
            // 
            // Description_Of_Problems_Column
            // 
            this.Description_Of_Problems_Column.HeaderText = "Description Of Problems";
            this.Description_Of_Problems_Column.Name = "Description_Of_Problems_Column";
            this.Description_Of_Problems_Column.ReadOnly = true;
            // 
            // IncomingDate_Column
            // 
            this.IncomingDate_Column.HeaderText = "Incoming Date";
            this.IncomingDate_Column.Name = "IncomingDate_Column";
            this.IncomingDate_Column.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Edit Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerLookupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 610);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerLookupForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.CustomerLookupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_Number_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMail_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn City_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn State_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zip_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipment_Description_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accessories_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description_Of_Problems_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomingDate_Column;
        private System.Windows.Forms.Button button1;

    }
}