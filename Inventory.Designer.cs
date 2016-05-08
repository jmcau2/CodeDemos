namespace PeoriaTechnologyIntakeSheet
{
    partial class Inventory
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
            this.addNewItemButton = new System.Windows.Forms.Button();
            this.changeQtyButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.updateItemButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewItemButton
            // 
            this.addNewItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewItemButton.Location = new System.Drawing.Point(12, 383);
            this.addNewItemButton.Name = "addNewItemButton";
            this.addNewItemButton.Size = new System.Drawing.Size(144, 33);
            this.addNewItemButton.TabIndex = 0;
            this.addNewItemButton.Text = "Add New Item";
            this.addNewItemButton.UseVisualStyleBackColor = true;
            this.addNewItemButton.Click += new System.EventHandler(this.addNewItemButton_Click);
            // 
            // changeQtyButton
            // 
            this.changeQtyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeQtyButton.Location = new System.Drawing.Point(312, 383);
            this.changeQtyButton.Name = "changeQtyButton";
            this.changeQtyButton.Size = new System.Drawing.Size(144, 33);
            this.changeQtyButton.TabIndex = 1;
            this.changeQtyButton.Text = "Change Qty";
            this.changeQtyButton.UseVisualStyleBackColor = true;
            this.changeQtyButton.Click += new System.EventHandler(this.changeQtyButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItemButton.Location = new System.Drawing.Point(162, 383);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(144, 33);
            this.removeItemButton.TabIndex = 2;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // updateItemButton
            // 
            this.updateItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateItemButton.Location = new System.Drawing.Point(462, 383);
            this.updateItemButton.Name = "updateItemButton";
            this.updateItemButton.Size = new System.Drawing.Size(144, 33);
            this.updateItemButton.TabIndex = 3;
            this.updateItemButton.Text = "Update Item";
            this.updateItemButton.UseVisualStyleBackColor = true;
            this.updateItemButton.Click += new System.EventHandler(this.updateItemButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ItemName,
            this.Qty,
            this.MinQty,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(28, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(563, 326);
            this.dataGridView1.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 20;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 300;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 50;
            // 
            // MinQty
            // 
            this.MinQty.HeaderText = "MinQty";
            this.MinQty.Name = "MinQty";
            this.MinQty.ReadOnly = true;
            this.MinQty.Width = 50;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 428);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.updateItemButton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.changeQtyButton);
            this.Controls.Add(this.addNewItemButton);
            this.Name = "Inventory";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewItemButton;
        private System.Windows.Forms.Button changeQtyButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button updateItemButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}